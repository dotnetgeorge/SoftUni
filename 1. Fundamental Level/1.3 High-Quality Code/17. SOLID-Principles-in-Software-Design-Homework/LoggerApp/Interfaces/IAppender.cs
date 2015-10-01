namespace LoggerApp.Interfaces
{
    public interface IAppender
    {
        ILayout Layout { get; set; }

        void Console();

        void FileWriter();

        void Network();
    }
}
