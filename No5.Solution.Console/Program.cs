using System.Collections.Generic;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BoldText bold = new BoldText();
            bold.Text = "bold";
            Hyperlink hyperlink = new Hyperlink();
            hyperlink.Text = "hyperlink";
            PlainText plainText = new PlainText();
            plainText.Text = "plainText";
            List<DocumentPart> parts = new List<DocumentPart>() { bold, hyperlink, plainText };
            Document document = new Document(parts);
            System.Console.WriteLine("bold.ToHtml " + document.ToNewFormat(bold.ToHtml));
            System.Console.WriteLine("bold.ToLaTeX " + document.ToNewFormat(bold.ToLaTeX));
            System.Console.WriteLine("bold.ToPlainText " + document.ToNewFormat(bold.ToPlainText));
            System.Console.WriteLine("hyperlink.ToHtml " + document.ToNewFormat(hyperlink.ToHtml));
            System.Console.WriteLine("hyperlink.ToLaTeX " + document.ToNewFormat(hyperlink.ToLaTeX));
            System.Console.WriteLine("hyperlink.ToPlainText " + document.ToNewFormat(hyperlink.ToPlainText));
            System.Console.WriteLine("plainText.ToHtml " + document.ToNewFormat(plainText.ToHtml));
            System.Console.WriteLine("plainText.ToLaTeX " + document.ToNewFormat(plainText.ToLaTeX));
            System.Console.WriteLine("plainText.ToPlainText " + document.ToNewFormat(plainText.ToPlainText));
            System.Console.ReadKey();
        }
    }
}
