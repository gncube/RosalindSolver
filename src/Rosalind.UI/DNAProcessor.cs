using System.Text;

namespace Rosalind.UI;
public class DNAProcessor : IDNAProcessor
{

    private static readonly Dictionary<char, char> Complements = new Dictionary<char, char>
    {
        { 'A', 'T' },
        { 'T', 'A' },
        { 'C', 'G' },
        { 'G', 'C' }
    };
    public NucleotideCount CountNucleotides(string dna)
    {
        var count = new NucleotideCount();

        foreach (var nucleotide in dna)
        {
            switch (nucleotide)
            {
                case 'A':
                    count.A++;
                    break;
                case 'C':
                    count.C++;
                    break;
                case 'G':
                    count.G++;
                    break;
                case 'T':
                    count.T++;
                    break;
                default:
                    throw new ArgumentException($"Invalid nucleotide: {nucleotide}");
            }
        }
        return count;
    }

    public string Transcribe(string dna)
    {
        return dna.Replace('T', 'U');
    }

    public string Complement(string dna)
    {
        var compliment = "";

        for (int i = dna.Length - 1; i >= 0; i--)
        {
            compliment += Complements[dna[i]];
        }

        return compliment;
    }

    public double ComputeGCContent(string dna)
    {
        if (string.IsNullOrEmpty(dna))
        {
            throw new ArgumentException("DNA string cannot be null or empty");
        }

        int gcCount = dna.Count(nucleotide => nucleotide == 'G' || nucleotide == 'C');
        return (double)gcCount / dna.Length * 100;
    }

    public GCContentResult ComputeHighestGCContent(string fastaStrings)
    {
        var lines = fastaStrings.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        string currentLabel = null;
        StringBuilder currentSequence = new StringBuilder();
        double highestGCContent = 0;
        string highestLabel = null;

        foreach (var line in lines)
        {
            if (line.StartsWith(">"))
            {
                if (currentLabel is not null)
                {
                    var gcContent = ComputeGCContent(currentSequence.ToString());
                    if (gcContent > highestGCContent)
                    {
                        highestGCContent = gcContent;
                        highestLabel = currentLabel;
                    }
                }
                currentLabel = line.Substring(1).Trim();
                currentSequence.Clear();
            }
            else
            {
                currentSequence.Append(line.Trim());
            }
        }

        // Check the last sequence
        if (currentLabel is not null)
        {
            var gcContent = ComputeGCContent(currentSequence.ToString());
            if (gcContent > highestGCContent)
            {
                highestGCContent = gcContent;
                highestLabel = currentLabel;
            }
        }

        return new GCContentResult
        {
            Label = highestLabel,
            GCContent = highestGCContent
        };
    }
}

public class GCContentResult
{
    public string Label { get; set; }
    public double GCContent { get; set; }
}

public class NucleotideCount
{
    public int A { get; set; }
    public int C { get; set; }
    public int G { get; set; }
    public int T { get; set; }
}
