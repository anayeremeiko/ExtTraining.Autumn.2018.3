using System;

namespace No4.Solution
{
    public class ByteGenerator : IGenerator
    {
        public string WorkingDirectory => "Files with random bytes";

        public string FileExtension => ".bytes";

        public byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}
