using Microsoft.VisualBasic;
using System;
using System.ComponentModel;

namespace PhoneClass
{
    public class Phone
    {
        public string Manufacturer { get; private set; }
        public int SimCardCount { get; private set; }

        public String imagePath { get; private set; }

        public static readonly Color BackColor;
        public double ScreenSizeInInches { get; private set; }
        public int BatteryCapacityInmAh { get; private set; }
        public string OperatingSystem { get; private set; }
        public DateTime ReleaseDate { get; private set; }

        static Phone()
        {
            DateTime now = DateTime.Now;
            if (now.DayOfWeek == DayOfWeek.Tuesday)
            {
                Phone.BackColor = Color.Green;
            }
            else
            {
                Phone.BackColor = Color.White;
            }
        }

        public override string ToString()
        {
            return "Phone: " + Manufacturer + " " + Model;
        }



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

    public class Smartphone : Phone
    {
        public bool HasTouchScreen { get; private set; }
        public int CameraMegapixels { get; private set; }
        public bool HasBluetooth { get; private set; }

        public override string ToString()
        {
            return "Smartphone: " + Manufacturer + " " + Model + ", Camera: " + CameraMegapixels + "MP";
        }


        // Добавленный конструктор по умолчанию
        public Smartphone() : base("DefaultManufacturer", 1, "DefaultModel")
        {
            HasTouchScreen = true;
            CameraMegapixels = 12;
            HasBluetooth = true;
        }

        // Конструктор для Smartphone
        public Smartphone(string manufacturer, int simCardCount, string model, double screenSize, int batteryCapacity, string os, DateTime releaseDate, bool hasTouchScreen, int cameraMegapixels, bool hasBluetooth)
            : base(manufacturer, simCardCount, model, screenSize, batteryCapacity, os, releaseDate)
        {
            HasTouchScreen = hasTouchScreen;
            CameraMegapixels = cameraMegapixels;
            HasBluetooth = hasBluetooth;
        }
    }

    public class FeaturePhone : Phone
    {
        public bool HasPhysicalKeyboard { get; private set; }
        public string ScreenType { get; private set; }

        public override string ToString()
        {
            return "FeaturePhone: " + Manufacturer + " " + Model + ", Screen Type: " + ScreenType;
        }


        // Добавленный конструктор по умолчанию
        public FeaturePhone() : base("DefaultManufacturer", 1, "DefaultModel")
        {
            HasPhysicalKeyboard = true;
            ScreenType = "LCD";
        }

        // Конструктор для FeaturePhone
        public FeaturePhone(string manufacturer, int simCardCount, string model, bool hasPhysicalKeyboard, string screenType)
            : base(manufacturer, simCardCount, model)
        {
            HasPhysicalKeyboard = hasPhysicalKeyboard;
            ScreenType = screenType;
        }
    }
}