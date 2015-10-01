using HTMLDispatcherApp.Data;

namespace HTMLDispatcherApp.Data
{
    public class HTMLDispatcher
    {
        /// <summary>
        /// Creates the image.
        /// </summary>
        /// <param name="imageSource">The image source.</param>
        /// <param name="alt">The alt.</param>
        /// <param name="title">The title.</param>
        /// <returns></returns>
        public static ElementBuilder CreateImage(string imageSource, string alt, string title)
        {
            var image = new ElementBuilder("img");
            image.AddAttribute("src", imageSource);
            image.AddAttribute("alt", alt);
            image.AddAttribute("title", title);

            return image;
        }

        /// <summary>
        /// Creates the URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="title">The title.</param>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static ElementBuilder CreateUrl(string url, string title, string text)
        {
            var urlTag = new ElementBuilder("a");
            
            urlTag.AddAttribute("href", url);
            urlTag.AddAttribute("title", title);
            urlTag.AddContent(text);

            return urlTag;
        }

        /// <summary>
        /// Creates the input.
        /// </summary>
        /// <param name="inputType">Type of the input.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static ElementBuilder CreateInput(string inputType, string name, string value)
        {
            var input = new ElementBuilder("input");

            input.AddAttribute("type", inputType);
            input.AddAttribute("name", name);
            input.AddAttribute("value", value);

            return input;
        }
    }
}
