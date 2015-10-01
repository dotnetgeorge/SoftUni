using System;
using HTMLDispatcherApp.Data;

namespace HTMLDispatcherApp
{
    class  TestHTMLDispatcherApp
    {
        static void Main()
        {
            var div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");

            Console.WriteLine(div * 2);

            var img = HTMLDispatcher.CreateImage("http://example.com/firstImg.jpg", "First image", "The First Image");
            var url = HTMLDispatcher.CreateUrl("http://example.com/", "Example.com", "This is simple web site.");
            var input = HTMLDispatcher.CreateInput("email", "email", "Enter your e-mail.");

            Console.WriteLine(img);
            Console.WriteLine(url);
            Console.WriteLine(input);
        }
    }
}
