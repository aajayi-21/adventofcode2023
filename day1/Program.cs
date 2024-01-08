using System;
using System.IO;


namespace day1
{
    class Solution
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new("C:\\Users\\super\\source\\repos\\adventofcode2023\\day1\\input");
                string line;
                double sum = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (char.IsDigit(line[i])){
                            sum += char.GetNumericValue(line[i]) * 10;
                            break;
                        }
                    }

                    for (int i = line.Length - 1; i >= 0; i--)
                    {
                        if (char.IsDigit(line[i])){
                            sum += char.GetNumericValue(line[i]);
                            break;
                        }
                    }
                   
                }
                Console.WriteLine(sum);

            }
            catch {
                Console.WriteLine("Error Occured");
            }
        }
    }
}