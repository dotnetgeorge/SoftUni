namespace LoggerApp.Layouts
{
    using Interfaces;
    using System;

    abstract class Layout : ILayout
    {
        private string _message;
        private string _reportLevel;

        public Layout()
        { }

        public DateTime Date => DateTime.Now;

        public string Message
        {
            get
            {
                return this._message;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Message can not be null or empty!");
                }

                this._message = value;
            }
        }

        public string ReportLevel
        {
            get
            {
                return this._reportLevel;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Report Level can not be null or empty!");
                }
                this._reportLevel = value;
            }
        }

        public abstract void PrintMessage();
    }
}
