using System;
using System.IO;

class Program2
{
    static void Main()
    {
        // �cie�ka do pliku na okre�lonym woluminie, np. D:
        string filePath = @"Test.txt";

        // Odczytanie danych z pliku na dysku D
        try
        {
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("Zawarto�� pliku:");
                Console.WriteLine(fileContent);
            }
            else
            {
                Console.WriteLine("Plik nie istnieje.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wyst�pi� b��d podczas odczytywania pliku: " + ex.Message);
        }
    }
}
