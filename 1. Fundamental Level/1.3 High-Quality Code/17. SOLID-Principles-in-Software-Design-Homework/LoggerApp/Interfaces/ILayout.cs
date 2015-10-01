namespace LoggerApp.Interfaces
{
    using System;

    public interface ILayout
    {
        DateTime Date { get; }

        string ReportLevel { get; set; }

        string Message { get; set; }

        void PrintMessage();
    }
}
