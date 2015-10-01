namespace LoggerApp.Appenders
{
    using Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) 
            : base(layout)
        {

        }

        public override void Console()
        {
            base.Layout.PrintMessage();
        }
    }
}
