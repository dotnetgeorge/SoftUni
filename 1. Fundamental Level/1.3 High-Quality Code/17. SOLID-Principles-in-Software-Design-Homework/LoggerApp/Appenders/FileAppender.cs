namespace LoggerApp.Appenders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;
    using System.IO;

    public class FileAppender : Appender
    {
        private string _file;

        public FileAppender(ILayout layout) 
            : base(layout)
        {
        }

        public string File
        {
            get
            {
                return this._file;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "File name should be at least 1 character!");
                }

                this._file = value;
            }
        }


        public async override void FileWriter()
        {
            var message = $"{base.Layout.Date} - {base.Layout.ReportLevel} - {base.Layout.Message}";

            using (var writer = new StreamWriter(this.File, true))
            {
                await writer.WriteLineAsync(message);
            }
        }
    }
}
