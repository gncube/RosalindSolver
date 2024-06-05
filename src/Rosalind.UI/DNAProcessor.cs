namespace Rosalind.UI;
public class DNAProcessor
{
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
            switch (dna[i])
            {
                case 'A':
                    compliment += 'T';
                    break;
                case 'T':
                    compliment += 'A';
                    break;
                case 'C':
                    compliment += 'G';
                    break;
                case 'G':
                    compliment += 'C';
                    break;
            }
        }

        return compliment;
    }
}

public class NucleotideCount
{
    public int A { get; set; }
    public int C { get; set; }
    public int G { get; set; }
    public int T { get; set; }
}
