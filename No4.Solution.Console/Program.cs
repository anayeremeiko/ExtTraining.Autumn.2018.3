namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomFileGenerator.GenerateFiles(2, 10, new CharsGenerator());
            RandomFileGenerator.GenerateFiles(1, 5, new ByteGenerator());
        }
    }
}
