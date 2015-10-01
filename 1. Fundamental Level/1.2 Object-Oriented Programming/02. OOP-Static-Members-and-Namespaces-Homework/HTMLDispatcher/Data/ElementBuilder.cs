namespace HTMLDispatcherApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text; 

    public class ElementBuilder
    {
        private HashSet<string> _selfClosingTags = new HashSet<string>()
        {
           "area", "base", "br", "col", "command",
           "embed", "hr", "img", "input", "keygen",
           "link", "meta", "param", "source", "track", "wbr"
        }; 
        
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _element;
        private string _content;

        /// <summary>
        /// Initializes a new instance of the <see cref="ElementBuilder"/> class.
        /// </summary>
        /// <param name="element">The element.</param>
        public ElementBuilder(string element)
        {
            Element = element;
        }

        /// <summary>
        /// Gets or sets the element.
        /// </summary>
        /// <value>
        /// The element.
        /// </value>
        /// <exception cref="System.ArgumentNullException">Element can't be null or empty!</exception>
        public string Element
        {
            get
            {
                return _element;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Element can't be null or empty!");
                }

                _element = value;
            }
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        /// <exception cref="System.ArgumentNullException">Content can not be null or empty!</exception>
        public string Content
        {
            get { return _content; }
            protected set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Content can not be null or empty!");
                }

                _content = value;
            }
        }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public Dictionary<string, string> Attributes => _attributes;

        /// <summary>
        /// Adds the attribute.
        /// </summary>
        /// <param name="attribute">The attribute.</param>
        /// <param name="value">The value.</param>
        public void AddAttribute(string attribute, string value)
        {
            var checkAttribute = string.IsNullOrEmpty(attribute) || string.IsNullOrWhiteSpace(attribute);
            var checkValue = string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);

            if (checkAttribute)
            {
                throw new ArgumentNullException(nameof(attribute), "Attribute can not be null or empty!");
            }
            if (checkValue)
            {
                throw new ArgumentNullException(nameof(value), "Value can not be null or empty!");
            }

            if (_attributes.ContainsKey(attribute))
            {
                _attributes[attribute] += " " + value;
            }
            else
            {
                _attributes.Add(attribute, value);
            }
        }

        /// <summary>
        /// Adds the content.
        /// </summary>
        /// <param name="content">The content.</param>
        public void AddContent(string content)
        {
            Content += $"{content}{Environment.NewLine}";
        }

        /// <summary>
        /// Implements the operator *.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="count">The count.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static string operator *(ElementBuilder element, int count)
        {
            var multiply = new StringBuilder();

            for (var i = 0; i < count; i++)
            {
                multiply.AppendLine(element.ToString());
            }

            return multiply.ToString();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var viewTag = new StringBuilder();

            viewTag.AppendFormat("<{0}", Element);

            foreach (var item in Attributes)
            {
                viewTag.AppendFormat(" {0}=\"{1}\"", item.Key, item.Value);
            }

            if (_selfClosingTags.Contains(Element))
            {
                viewTag.Append("/>");
                viewTag.AppendFormat("\n\t{0}", Content);
            }
            else
            {
                viewTag.AppendFormat(">\n\t{0}", Content);
                viewTag.AppendFormat("</{0}>", Element);
            }

            return viewTag.ToString();
        }
    }
}
