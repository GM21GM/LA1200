using System;
using System.IO;

namespace LA1200
{
    public class Program
    {
        static void Main(string[] args)
        {

            string inPath = @"/Users/giovanni/Downloads/Ohne Titel.csv";
            string text = File.ReadAllText(inPath);

            string[] lines = text.Split("\r\n");
            int students = lines.Length;
            string[] mail = new string[students];
            string[] first = new string[students];
            string[] second = new string[students];
            string[] third = new string[students];

            string outText = "";

            foreach (var student in first)
            {
                Random rnd = new Random();

                switch (first[rnd.Next(0,students)])
                {
                    case string n when (n == "Rasenmähen"):

                        break;

                }
            }


            string outPath = @"/Users/giovanni/Downloads/Lösung2.csv";

            File.WriteAllText(outPath, outText);
        }
    }
}
// Liste von Workshops machen als funktion, second/third switch-case als funktion, funktion von workshop z.B. ist rasenmähervoll, mit if else syntax
