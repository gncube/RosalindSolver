﻿using System.IO.Abstractions;

namespace Rosalind.UI;
public class OperationFactory
{
    private readonly IDNAProcessor _dnaProcessor;
    private readonly UserInputHandler _userInputHandler;
    private readonly IFileSystem _fileSystem;

    public OperationFactory(IDNAProcessor dnaProcessor, UserInputHandler userInputHandler, IFileSystem fileSystem)
    {
        _dnaProcessor = dnaProcessor;
        _userInputHandler = userInputHandler;
        _fileSystem = fileSystem;
    }

    public IOperation CreateOperation(string choice)
    {
        IOperation operation = choice switch
        {
            "1" => new CountNucleotidesOperation(_dnaProcessor, string.Empty),
            "2" => new TranscribeDNAOperation(_dnaProcessor, string.Empty),
            "3" => new FindComplementOperation(_dnaProcessor, string.Empty),
            "4" => new GetRabbitPairsOperation(_userInputHandler),
            "5" => new GetMortalRabbitPairsOperation(_userInputHandler),
            _ => throw new ArgumentException("Invalid choice.")
        };

        if (operation.RequiresDNAString())
        {
            string dnaString = GetDNAStringFromUser();
            operation = choice switch
            {
                "1" => new CountNucleotidesOperation(_dnaProcessor, dnaString),
                "2" => new TranscribeDNAOperation(_dnaProcessor, dnaString),
                "3" => new FindComplementOperation(_dnaProcessor, dnaString),
                _ => operation
            };
        }
        return operation;
    }

    private string GetDNAStringFromUser()
    {
        string filePath = _userInputHandler.GetFilePath();
        IDNAReader dnaReader = new FileDNAReader(filePath, _fileSystem);
        return dnaReader.ReadDNA();
    }
}

