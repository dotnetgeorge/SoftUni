namespace BookStore
{
    using Engine;

    public class BookStoreMain
    {
        public static void Main()
        {
            var engine = new BookStoreEngine();

            engine.Run();
        }
    }
}
