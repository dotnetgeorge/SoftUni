namespace GalacticGPSApp.Data
{
    using System;

    struct Location
    {
        private double _latitude;
        private double _longitute;

        public Location(double latitude, double longitude, Planet planet) : this()
        {
            Latitude = latitude;
            Longitude = longitude;
            Planet = planet;
        }


        public double Latitude
        {
            get { return _latitude; }
            set
            {
                if (value < -90.00 || 90.00 < value)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Latitude should be in range[-90..90]!");
                }

                _latitude = value;
            }
        }

        public double Longitude
        {
            get { return _longitute; }
            set
            {
                if (value < -180.00 || 180.00 < value)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Longitute should be in range [-180..180]!");
                }

                _longitute = value;
            }
        }

        public Planet Planet { get; set; }

        public override string ToString() => $"{Latitude} {Longitude} - {Planet}";
    }
}
