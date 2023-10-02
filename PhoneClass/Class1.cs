namespace PhoneClass
{
    public class Phone
    {
        public string Manufacturer { get; private set; }
        public int SimCardCount { get; private set; }
        public string Model { get; private set; }
        public double ScreenSizeInInches { get; private set; }
        public int BatteryCapacityInmAh { get; private set; }
        public string OperatingSystem { get; private set; }

        // Конструктор, принимающий все свойства
        public Phone(string manufacturer, int simCardCount, string model, double screenSize, int batteryCapacity, string os)
        {
            Manufacturer = manufacturer;
            SimCardCount = simCardCount;
            Model = model;
            ScreenSizeInInches = screenSize;
            BatteryCapacityInmAh = batteryCapacity;
            OperatingSystem = os;
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
        }

        // Конструктор по умолчанию
        // Конструктор по умолчанию без аргументов
        public Phone()
        {
            Manufacturer = "Unknown";
            SimCardCount = 1;
            Model = "Unknown";
            ScreenSizeInInches = 0.0;
            BatteryCapacityInmAh = 0;
            OperatingSystem = "";
        }

    }

}