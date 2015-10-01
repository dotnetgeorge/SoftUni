namespace LoggerApp
{
    using Layouts;
    using Appenders;
    using Loggers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BasicLoggerApp
    {
        static void Main(string[] args)
        {
            var layout = new SimpleLayout();
            //var appender = new ConsoleAppender(layout);
            //var logger = new Logger(appender);
            var fileAppender = new FileAppender(layout);
            
            fileAppender.File = "log.txt";

            var logger = new Logger(fileAppender);

            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));
        }
    }
}
