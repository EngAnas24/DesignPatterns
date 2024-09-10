using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder
{
    using System;
    using System.Text;

    // Builder Interface
    public interface IHtmlBuilder
    {
        void AddTitle(string title);
        void AddParagraph(string text);
        string GetResult();
    }

    // Concrete Builder
    public class HtmlBuilder : IHtmlBuilder
    {
        private StringBuilder _htmlDocument = new StringBuilder();

        public void AddTitle(string title)
        {
            _htmlDocument.AppendLine($"<h1>{title}</h1>");
        }

        public void AddParagraph(string text)
        {
            _htmlDocument.AppendLine($"<p>{text}</p>");
        }

        public string GetResult()
        {
            return _htmlDocument.ToString();
        }
    }

    // Director
    public class HtmlDirector
    {
        private readonly IHtmlBuilder _builder;

        public HtmlDirector(IHtmlBuilder builder)
        {
            _builder = builder;
        }

        public void BuildSimpleHtmlDocument(string title, string text)
        {
            _builder.AddTitle(title);
            _builder.AddParagraph(text);
        }
    }

    // Client Code
    class Program
    {
        static void Main(string[] args)
        {
            // Create builder and director
            IHtmlBuilder builder = new HtmlBuilder();
            var director = new HtmlDirector(builder);

            // Build a simple HTML document
            director.BuildSimpleHtmlDocument("Hello, World!", "This is a simple HTML document using Builder pattern.");

            // Get the result
            string htmlDocument = builder.GetResult();
            Console.WriteLine(htmlDocument);

        Console.ReadKey();
        }
    }

}
