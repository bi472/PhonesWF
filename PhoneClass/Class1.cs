using System;
using System.Drawing; // Для использования класса Color

namespace PhoneClass
{
    public abstract class AbstractPhone
    {
        public string Manufacturer { get; protected set; }
        public int SimCardCount { get; protected set; }
        public double ScreenSizeInInches { get; protected set; }
        public int BatteryCapacityInmAh { get; protected set; }
        public string OperatingSystem { get; protected set; }
        public DateTime ReleaseDate { get; protected set; }

        public abstract string GetInfo();
        public abstract decimal CalculateRepairCost();
    }

    public class Phone:AbstractPhone
    {

        public static readonly Color BackColor;

        private string _model;

        public virtual string Model
        {
            get { return _model; }
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

        public override string GetInfo()
        {
            return "Base phone class";
        }

        public override string ToString()
        {
            return "Phone: " + Manufacturer + " " + Model;
        }

        public override decimal CalculateRepairCost()
        {
            return 50m;
        }

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

        public Phone(string manufacturer, int simCardCount, string model)
        {
            Manufacturer = manufacturer;
            SimCardCount = simCardCount;
            Model = model;
            ScreenSizeInInches = 0.0;
            BatteryCapacityInmAh = 0;
            OperatingSystem = "";
            ReleaseDate = DateTime.MinValue;
        }

        public Phone()
        {
            Manufacturer = "Unknown";
            SimCardCount = 1;
            Model = "Unknown";
            ScreenSizeInInches = 0.0;
            BatteryCapacityInmAh = 0;
            OperatingSystem = "";
            ReleaseDate = DateTime.MinValue;
        }
    }

    public class Smartphone : Phone
    {
        public override decimal CalculateRepairCost()
        {
            return base.CalculateRepairCost() + 100m;
        }

        public bool HasTouchScreen { get; private set; }
        public int CameraMegapixels { get; private set; }
        public bool HasBluetooth { get; private set; }

        public override string GetInfo()
        {
            return $"This smartphone has touchscreen:{HasTouchScreen}, camera megapixels: {CameraMegapixels}, has bluetooth: {HasBluetooth}";
        }

        public sealed override string ToString()
        {
            return "Smartphone: " + Manufacturer + " " + Model + ", Camera: " + CameraMegapixels + "MP";
        }

        public Smartphone() : base("DefaultManufacturer", 1, "DefaultModel")
        {
            HasTouchScreen = true;
            CameraMegapixels = 12;
            HasBluetooth = true;
        }

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


        public new string GetInfo()
        {
            return $"FeaturePhone screen type: {ScreenType}";
        }

        public new string ToString()
        {
            return "FeaturePhone: " + Manufacturer + " " + Model + ", Screen Type: " + ScreenType;
        }

        

        public FeaturePhone() : base("DefaultManufacturer", 1, "DefaultModel")
        {
            HasPhysicalKeyboard = true;
            ScreenType = "LCD";
        }

        public FeaturePhone(string manufacturer, int simCardCount, string model, bool hasPhysicalKeyboard, string screenType)
            : base(manufacturer, simCardCount, model)
        {
            HasPhysicalKeyboard = hasPhysicalKeyboard;
            ScreenType = screenType;
        }
    }
}
