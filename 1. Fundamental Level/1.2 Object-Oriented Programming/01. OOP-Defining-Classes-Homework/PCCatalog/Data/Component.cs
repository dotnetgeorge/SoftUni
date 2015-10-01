namespace PCCatalog.Data
{
    using System;
    using System.Text;

    public class Component
    {
        private string _name;
        private string _details;
        private decimal _price;

        public Component(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public Component(string name, string details, decimal price)
        {
            _name = name;
            _details = details;
            _price = price;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Component Name can't be empty!");
                }

                _name = value;
            }
        }

        public string Details
        {
            get
            {
                return _details;
            }
            set
            {
                _details = value;
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
                if(_price < 1.0m || _price > 15000.0m)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Please enter a real price for Component!");
                }

                _price = value;
            }
        }

        public override string ToString()
        {
            var info = new StringBuilder();

            if (!string.IsNullOrEmpty(Name) || !string.IsNullOrWhiteSpace(Name))
            {
                info.AppendFormat("Component Name: {0}", Name).AppendLine();
            }

            if(!string.IsNullOrEmpty(Details) || !string.IsNullOrWhiteSpace(Details) || Details == "\n")
            {
                info.AppendFormat("Component Details: {0}", Details).AppendLine();
            }

            if (Price > 0 && _price < 15000)
            {
                info.AppendFormat("Component Price: {0}", Price).AppendLine();
            }
            
            return info.ToString();
        }
    }
}
