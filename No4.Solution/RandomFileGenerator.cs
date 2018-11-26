namespace No4.Solution
{
    using System;
    using System.IO;

    public static class RandomFileGenerator
    {
        public static void GenerateFiles(int filesCount, int contentLength, IGenerator generator)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = generator.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{generator.FileExtension}";

                WriteBytesToFile(generator.WorkingDirectory, generatedFileName, generatedFileContent);
            }
        }

        private static void WriteBytesToFile(string directory, string filename, byte[] content)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            File.WriteAllBytes($"{directory}\\{filename}", content);
        }
    }
}
