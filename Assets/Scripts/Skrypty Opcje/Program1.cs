using System;
using System.IO;

class Program1
{
    static void Main()
    {
        // Œcie¿ka do pliku na okreœlonym woluminie, np. D:
        string filePath = @"Test.txt";

        // Tekst do zapisania w pliku
        string textToSave = "To jest przyk³adowy tekst zapisany na dysku D.";

        // Zapisanie tekstu do pliku na dysku D
        try
        {
            File.WriteAllText(filePath, textToSave);
            Console.WriteLine("Dane zosta³y zapisane do pliku na dysku D.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wyst¹pi³ b³¹d podczas zapisywania pliku: " + ex.Message);
        }
    }
}
