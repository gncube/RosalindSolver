namespace Rosalind.UI;
public class UserInputHandler
{
    public int GetChoice()
    {
        Console.Write("Enter 1 to count nucleotides, 2 to transcribe DNA into RNA, 3 to find the complement of DNA, 4 to calculate rabbit pairs, 5 to calculate mortal rabbit pairs: ");
        return int.Parse(Console.ReadLine());
    }

    public int GetIntInput(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    public string GetFilePath()
    {
        string filePath;
        do
        {
            Console.Write("Enter the file path for the DNA string: ");
            filePath = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(filePath))
            {
                Console.WriteLine("File path cannot be empty. Please try again.");
                return String.Empty;
            }
            else if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist. Please try again.");
            }
            else
            {
                break;
            }
        } while (true);

        return filePath;
    }
}
