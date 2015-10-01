namespace LoggerApp.Layouts
{
    using static System.Console;

    class SimpleLayout : Layout
    {
        public SimpleLayout()
        { }


        public override void PrintMessage()
        {
            WriteLine($"{base.Date} - {base.ReportLevel} - {base.Message}");
        }
    }
}