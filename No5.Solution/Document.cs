using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class Document
    {
        private readonly List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }

            this.parts = new List<DocumentPart>(parts);
        }

        public string ToNewFormat(Func<string> formatFunction)
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += formatFunction() + "\n";
            }

            return output;
        }
    }
}
