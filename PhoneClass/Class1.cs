using System;

namespace PhoneClass
{
    public class Phone
    {
        public string Manufacturer { get; private set; }
        public int SimCardCount { get; private set; }

        private string _model;

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && char.IsLower(value[0]))
                {
                    _model = char.ToUpper(value[0]) + value.Substring(1);
                }
                else
                {
                    _model = value;
                }
            }
        }

        public double ScreenSizeInInches { get; private set; }
        public int BatteryCapacityInmAh { get; private set; }
        public string OperatingSystem { get; private set; }
        public DateTime ReleaseDate { get; private set; }

        // Конструктор, принимающий все свойства
        public Phone(string manufacturer, int simCardCount, string model, double screenSize, int batteryCapacity, string os, DateTime releaseDate)
        {
            Manufacturer = manufacturer;
            SimCardCount = simCardCount;
            Model = model;
            ScreenSizeInInches = screenSize;
            BatteryCapacityInmAh = batteryCapacity;
            OperatingSystem = os;
            ReleaseDate = releaseDate;
        }

        // Конструктор, принимающий только базовые свойства
        public Phone(string manufacturer, int simCardCount, string model)
        {
            Manufacturer = manufacturer;
            SimCardCount = simCardCount;
            Model = model;
            // Устанавливаем остальные свойства в значения по умолчанию
            ScreenSizeInInches = 0.0;
            BatteryCapacityInmAh = 0;
            OperatingSystem = "";
            ReleaseDate = DateTime.MinValue; // Устанавливаем минимальное значение для DateTime
        }

        // Конструктор по умолчанию
        public Phone()
        {
            Manufacturer = "Unknown";
            SimCardCount = 1;
            Model = "Unknown";
            ScreenSizeInInches = 0.0;
            BatteryCapacityInmAh = 0;
            OperatingSystem = "";
            ReleaseDate = DateTime.MinValue; // Устанавливаем минимальное значение для DateTime
        }
    }
}
