﻿using System;
using System.Linq;
using System.Text;

namespace No4.Solution
{
    public class CharsGenerator : IGenerator
    {
        public string WorkingDirectory => "Files with random chars";

        public string FileExtension => ".txt";

        public byte[] GenerateFileContent(int contentLength)
        {
            var generatedString = this.RandomString(contentLength);

            var bytes = Encoding.Unicode.GetBytes(generatedString);

            return bytes;
        }

        private string RandomString(int Size)
        {
            var random = new Random();

            const string input = "abcdefghijklmnopqrstuvwxyz0123456789";

            var chars = Enumerable.Range(0, Size).Select(x => input[random.Next(0, input.Length)]);

            return new string(chars.ToArray());
        }
    }
}
