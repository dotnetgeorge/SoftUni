namespace PCCatalog.Data
{
    using System;
    using System.Text;

    public class Computer
    {
        private string _name;
        //private Component motherboard;
        //private Component processor;
        //private Component ram;
        //private Component hdd;
        //private Component graphicsCard;
        //private Component power;

        public Computer(string name, Component motherboard, Component processor, Component ram, Component hdd, Component graphicsCard, Component power)
        {
            _name = name;
            Motherboard = motherboard;
            Processor = processor;
            Ram = ram;
            Hdd = hdd;
            GraphicsCard = graphicsCard;
            Power = power;
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
                    throw new ArgumentNullException(nameof(value), "Name of computer can't be empty!");
                }

                _name = value;
            }
        }
        public Component Motherboard { get; set; }
        public Component Processor { get; set; }
        public Component Ram { get; set; }
        public Component Hdd { get; set; }
        public Component GraphicsCard { get; set; }
        public Component Power { get; set; }


        public override string ToString()
        {
            var fullInfo = new StringBuilder();
            var totalPrice = 0.0m;

            if (!string.IsNullOrEmpty(Name) || !string.IsNullOrWhiteSpace(Name))
            {
                fullInfo.AppendFormat("Name: {0}\n", Name);
            }
            if (Motherboard.Name != null)
            {
                fullInfo.Append(Motherboard);
                totalPrice += Motherboard.Price;
            }
            if (Processor.Name != null)
            {
                fullInfo.Append(Processor);
                totalPrice += Processor.Price;
            }
            if (Ram.Name != null)
            {
                fullInfo.Append(Ram);
                totalPrice += Ram.Price;
            }
            if (Hdd.Name != null)
            {
                fullInfo.Append(Hdd);
                totalPrice += Hdd.Price;
            }
            if (GraphicsCard.Name != null)
            {
                fullInfo.Append(GraphicsCard);
                totalPrice += GraphicsCard.Price;
            }
            if (Power.Name != null)
            {
                fullInfo.Append(Power);
                totalPrice += Power.Price;
            }

            fullInfo.AppendFormat("Total computer price is: {0:F2}\n", totalPrice);

            return fullInfo.ToString();
        } 
    }
}
