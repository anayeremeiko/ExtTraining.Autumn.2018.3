namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomFileGenerator randomFileGenerator = new RandomCharsFileGenerator();
            randomFileGenerator.GenerateFiles(1, 52);

            randomFileGenerator = new RandomBytesFileGenerator();
            randomFileGenerator.GenerateFiles(3, 52);

        }
    }
}
