// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Reflection.PortableExecutable;


public class Day2
{
    public static void Main()
    {
        MakeDict("C:\\Users\\super\\source\\repos\\adventofcode2023\\day2\\input");
    }

    public static void MakeDict(string path)
    {
        StreamReader sr = new StreamReader(path);
        string line;
        Dictionary<string, int>[] games = new Dictionary<string, int>[100];
        while ((line = sr.ReadLine()) != null)
        {
            string[] subs = line.Split([',', ';']);
            Console.WriteLine(subs[0]);


        }
    }

    public static void Part1(Dictionary<string, int>[] games)
    {
        int reds, greens, blues;
        reds = 12; greens = 13; blues = 14;

        for (int i = 0; i < games.Length; i++)
        {
            if (games[i]["red"] <= reds && games[i]["green"] <= greens && games[i]["blue"] <= blues)
            {
                Console.WriteLine($"Valid {i}");
            }
        }

    }


}