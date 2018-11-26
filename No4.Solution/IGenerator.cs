namespace No4.Solution
{
    public interface IGenerator
    {
        string WorkingDirectory { get; }

        string FileExtension { get; }

        byte[] GenerateFileContent(int contentLength);
    }
}
