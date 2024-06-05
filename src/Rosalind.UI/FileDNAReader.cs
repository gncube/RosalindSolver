using System.IO.Abstractions;

namespace Rosalind.UI;

public class FileDNAReader : IDNAReader
{
    private readonly string _filePath;
    private readonly IFileSystem _fileSystem;

    public FileDNAReader(string filePath, IFileSystem fileSystem)
    {
        _filePath = filePath;
        _fileSystem = fileSystem;
    }

    public string ReadDNA()
    {
        return _fileSystem.File.ReadAllText(_filePath);
    }
}