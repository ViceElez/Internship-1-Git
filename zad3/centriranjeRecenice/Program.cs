using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Upisite zeljenu sirinu linije:");
        int n= int.Parse(Console.ReadLine());
        Console.WriteLine("Unesite zeljen broj znakova po liniji:");
        int m=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Upisite tekst koji zelite centrirati:");
        string text = Console.ReadLine();
        Console.WriteLine();


        List<string> words = new List<string>();
        words=LineFormatting(text, m);
        PrintCentered(words, n);
    }

    static List<string> LineFormatting(string text, int m)
    {
        List<string> allLines = new List<string>();
        string[] words = text.Split(' ');
        
        string currLine="";

        foreach (string word in words)
        {
                if((currLine+word).Length>m)
                {
                    allLines.Add(currLine);
                    currLine = "";

                }
                currLine += word + " ";
        }

        if (string.IsNullOrEmpty(currLine) == false)
        {
            allLines.Add(currLine);
        }

        return allLines;
    }
    
    static void PrintCentered(List<string> allLines, int n)
    {
        foreach (string line in allLines)
        {
            int spaces = (n - line.Length) / 2;
            string formattedLine = new string(' ', spaces) + line;
            Console.WriteLine(formattedLine);
        }
    }

    
}