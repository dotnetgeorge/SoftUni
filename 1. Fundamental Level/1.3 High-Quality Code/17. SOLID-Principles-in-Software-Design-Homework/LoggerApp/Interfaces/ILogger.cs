namespace LoggerApp.Interfaces
{
    interface ILogger
    {
        void Info(string message);

        void Warning(string message);

        void Error(string message);

        void Critical(string message);

        void Fatal(string message);

        void Execute(string message, string reportLevel);
    }
}
