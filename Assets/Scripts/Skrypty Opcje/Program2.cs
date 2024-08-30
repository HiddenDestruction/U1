using System;
using System.IO;

class Program2
{
    static void Main()
    {
        // Œcie¿ka do pliku na okreœlonym woluminie, np. D:
        string filePath = @"Test.txt";

        // Odczytanie danych z pliku na dysku D
        try
        {
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("Zawartoœæ pliku:");
                Console.WriteLine(fileContent);
            }
            else
            {
                Console.WriteLine("Plik nie istnieje.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wyst¹pi³ b³¹d podczas odczytywania pliku: " + ex.Message);
        }
    }
}
