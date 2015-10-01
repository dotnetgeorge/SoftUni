namespace LoggerApp.Loggers
{
    using System;
    using Interfaces;

    public class Logger : ILogger
    {
        protected IAppender _firstAppender;
        protected IAppender _secondAppender;
        protected IAppender _thirdAppender;

        public Logger(IAppender appender)
        {
            this.Appender = appender;
        }

        public Logger(IAppender firstAppender, IAppender secondAppender)
        { }

        public Logger(IAppender firstAppender, IAppender secondAppender, IAppender thirdAppender)
        {

        }

        public IAppender Appender { get; set; }


        public void Critical(string message)
        {
            this.Appender.Layout.Message = "Critical";
            this.Appender.Console();
        }

        public void Error(string message)
        {
            this.Appender.Layout.Message = message;
            this.Appender.Layout.ReportLevel = "Error";
            this.Appender.Network();
            this.Appender.FileWriter();
            this.Appender.Console();
        }

        public void Fatal(string message)
        {
            this.Appender.Layout.Message = "Fatal";
            this.Appender.Console();
        }

        public void Info(string message)
        {
            this.Appender.Layout.Message = message;
            this.Appender.Layout.ReportLevel = "Info";
            //this.Appender.FileWriter();
            this.Appender.Console();
            this.Appender.FileWriter();

        }

        public void Warning(string message)
        {
            this.Appender.Layout.Message = "Warning";
            this.Appender.Console();
        }

        void ILogger.Execute(string message, string reportLevel)
        {
            this.Appender.Layout.Message = message;
            this.Appender.Layout.ReportLevel = reportLevel;

            this.Appender.Console();
            this.Appender.FileWriter();
            this.Appender.Network();
        }
    }
}
