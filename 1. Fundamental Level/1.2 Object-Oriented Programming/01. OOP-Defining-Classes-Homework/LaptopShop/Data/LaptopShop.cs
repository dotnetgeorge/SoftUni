namespace LaptopsShop.Data
{
    using System;
    using System.Text;

    public class LaptopShop
    {
        private string _model;
        private string _manufacturer;
        private string _processor;
        private double _ram;
        private string _graphicsCard;
        private string _hdd;
        private string _screen;
        private Battery _batteryInfo;
        private decimal _price;

        public LaptopShop() { }

        public LaptopShop(string model, decimal price)
        {
            _model = model;
            _price = price;
        }

        public LaptopShop(string model, string manufacturer, string processor, double ram, string graphicsCard, string hdd, string screen, Battery batteryInfo, decimal price)
        {
            _model = model;
            _manufacturer = manufacturer;
            _processor = processor;
            _ram = ram;
            _graphicsCard = graphicsCard;
            _hdd = hdd;
            _screen = screen;
            _batteryInfo = batteryInfo;
            _price = price;
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Model can't be empty!");
                }

                _model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Manufacturer can't be empty!");
                }

                _manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return _processor;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Processor can't be empty!");
                }

                _processor = value;
            }
        }

        public double Ram
        {
            get
            {
                return _ram;
            }
            set
            {
                if (value > 32 && value < 1)
                {
                    throw new ArgumentOutOfRangeException("RAM must be between [1-32] GB!");
                }

                _ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return _graphicsCard;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Graphics card can't be empty!");
                }

                _graphicsCard = value;
            }
        }

        public string Hdd
        {
            get
            {
                return _hdd;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("HDD can't be empty!");
                }

                _hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return _screen;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Screen can't be empty!");
                }

                _screen = value;
            }
        }
        public Battery BatteryInfo
        {
            get
            {
                return _batteryInfo;
            }
            set
            {
                _batteryInfo = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0 || value > 15000)
                {
                    throw new ArgumentOutOfRangeException("Price must be between [1-15 000] lv.!");
                }

                _price = value;
            }
        }


        public override string ToString()
        {
            var info = new StringBuilder();

            if (!string.IsNullOrEmpty(Model))
            {
                info.AppendFormat("Model: {0}\n", Model);
            }
            if (!string.IsNullOrEmpty(Manufacturer))
            {
                info.AppendFormat("Manufacturer: {0}\n", Manufacturer);
            }
            if (!string.IsNullOrEmpty(Processor))
            {
                info.AppendFormat("Processor: {0}\n", Processor);
            }
            if (Ram > 0 && Ram < 33)
            {
                info.AppendFormat("RAM: {0} GB\n", Ram);
            }
            if (!string.IsNullOrEmpty(GraphicsCard))
            {
                info.AppendFormat("Graphics Card: {0}\n", GraphicsCard);
            }
            if (!string.IsNullOrEmpty(Hdd))
            {
                info.AppendFormat("HDD: {0}\n", Hdd);
            }
            if (BatteryInfo != null)
            {
                info.Append(BatteryInfo);
            }
            if (Price > 0 && Price < 15000)
            {
                info.AppendFormat("Price: {0} lv.\n", Price);
            }

            return info.ToString();
        }
    }
}