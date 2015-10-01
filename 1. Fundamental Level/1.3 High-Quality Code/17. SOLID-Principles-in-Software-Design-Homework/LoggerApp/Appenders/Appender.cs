namespace LoggerApp.Appenders
{
    using Interfaces;

    public abstract class Appender : IAppender
    {
        protected ILayout _layout;

        public Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout
        {
            get
            {
                return this._layout;
            }
            set
            {
                this._layout = value;
            }
        }
        
        public virtual void Console()
        { }
        public virtual void FileWriter()
        { }
        public virtual void Network()
        { }
    }
}
