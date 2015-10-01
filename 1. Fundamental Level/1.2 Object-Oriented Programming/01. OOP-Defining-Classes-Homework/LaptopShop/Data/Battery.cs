namespace LaptopsShop.Data
{
    using System;

    public class Battery
    {
        private string _batteryType;
        private string _batteryLife;

        public Battery(string batteryType, string batteryLife)
        {
            _batteryType = batteryType;
            _batteryLife = batteryLife;
        }

        public string BatteryType
        {
            get
            {
                return _batteryType;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Battery type can't be empty!");
                }

                _batteryType = value;
            }
        }

        public string BatteryLife
        {
            get
            {
                return _batteryLife;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Battery life can't be empty!");
                }

                _batteryLife = value;
            }
        }

        public override string ToString()
        { 
            
            var result = "Battery Type: " + BatteryType + "\n";
            result += "Battery Life: " + BatteryLife + "\n";

            if(string.IsNullOrEmpty(BatteryType) && string.IsNullOrEmpty(BatteryLife))
            {
                result = null;
            }  

            return result;
        }
    }
}
