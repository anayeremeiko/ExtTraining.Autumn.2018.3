namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomBytesFileGenerator bytes = new RandomBytesFileGenerator();
            bytes.GenerateFiles(1, 10);

            RandomCharsFileGenerator chars = new RandomCharsFileGenerator();
            chars.GenerateFiles(2, 50);
        }
    }
}
