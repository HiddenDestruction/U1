using System;
using System.IO;

class Program1
{
    static void Main()
    {
        // �cie�ka do pliku na okre�lonym woluminie, np. D:
        string filePath = @"Test.txt";

        // Tekst do zapisania w pliku
        string textToSave = "To jest przyk�adowy tekst zapisany na dysku D.";

        // Zapisanie tekstu do pliku na dysku D
        try
        {
            File.WriteAllText(filePath, textToSave);
            Console.WriteLine("Dane zosta�y zapisane do pliku na dysku D.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wyst�pi� b��d podczas zapisywania pliku: " + ex.Message);
        }
    }
}
