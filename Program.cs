using System;
using System.Collections;
using System.IO;

namespace LA1200
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wie Viele Workshops gibt es?");
            Console.WriteLine("Max Anzal 4:");

                
                int anzahlWorkshops = Convert.ToInt16(Console.ReadLine());
                int[] workshop = new int[anzahlWorkshops];
                string[] workshopName = new string[workshop.Length];

                for (int i = 0; i < anzahlWorkshops; i++)
                {
                    Console.WriteLine("Geben Sie den Namen des Workshops Nummer " + (i + 1) + " ein; ");
                    workshopName[i] = Console.ReadLine();
                }
            
            //Console.WriteLine("Geben Sie Hier den Pfad zur Datei ab: ");
            //string dateiPfad = Convert.ToString(Console.ReadLine());

            string dateiPfad = @"D:\Downloads Online\probe.csv";
            string text = File.ReadAllText(dateiPfad);

            string[] lines = text.Split("\r\n");
            int students = lines.Length;
            string[] mail = new string[students];
            string[] first = new string[students];
            string[] second = new string[students];
            string[] third = new string[students];
            string[] student = new string[students];
            int x = 0;
            bool workshopFull = false;
            for (int line = 0; line < lines.Length; line++)
            {
                string[] items = lines[line].Split(",");
                mail[line] = items[0];
                first[line] = items[1];
                second[line] = items[2];
                third[line] = items[3];
            }

            string outText = "";

            for(int i = 0; i < students; i++)
            {
                int studentNum = i;

                switch (first[i])
                {
                    case string n when (n == workshopName[0]):
                        x = 0;
                        ifWorkshopFull(workshop, x, workshopFull, student, mail, workshopName, studentNum);
                        getSecondOption(workshopFull, second, third, workshop, x, student, mail, workshopName, studentNum);
                        break;
                    case string n when (n == workshopName[1]):
                        x = 1;
                        getSecondOption(workshopFull, second, third, workshop, x, student, mail, workshopName, studentNum); 
                        break;
                    case string n when (n == workshopName[2]):
                        x = 2;
                        getSecondOption(workshopFull, second, third, workshop, x, student, mail, workshopName, studentNum);
                        break;
                    case string n when (n == workshopName[3]):
                        x = 3;
                        getSecondOption(workshopFull, second, third, workshop, x, student, mail, workshopName, studentNum);
                        break;

                }
            }
            for (int i = 0; i < students; i++)
            {
                outText = $"{ i},{ student[i]}";
            }

            string outPath = @"D:\Downloads Online\probe2.csv";

            File.WriteAllText(outPath, outText);
        }

        public static bool ifWorkshopFull(int[] workshop, int x, bool workshopFull, string[] student, string[] workshopName, string[] mail, int studentNum)
        {
            if (workshop[x] <= 20)
            {
                workshopFull = false;
                student[studentNum] = (mail[studentNum] + "; besucht" + workshopName[x]);
                workshop[x] +=1;
                return workshopFull;
            }
            else
            {
                workshopFull = true;
                return workshopFull;
            }
        }
        public static string getSecondOption(bool workshopFull, string[] third, string[] second, int[] workshop, int x, string[] student, string[] mail, string[] workshopName, int studentNum)
        {
                switch (second[studentNum])
                {
                    case string n when (n == workshopName[0]):
                        x = 0;
                        ifWorkshopFull(workshop, x, workshopFull, student, mail, workshopName, studentNum);
                        if (workshopFull == true)
                        {
                        getThirdOption(third, workshopName, workshop, x, workshopFull, student, mail,studentNum);
                        }
                        break;
                }
            return student[studentNum]; 
        }
        public static string getThirdOption(string[] third, string[] workshopName, int[] workshop, int x, bool workshopFull, string[] student, string[] mail, int studentNum)
        {
            switch (third[studentNum])
            {
                case string v when (v == workshopName[0]):
                    x = 0;
                    ifWorkshopFull(workshop, x, workshopFull, student, mail, workshopName, studentNum);
                    if (workshopFull == true)
                    {
                        student[studentNum] = (mail[studentNum] + "; besucht kein Workshop");
                    }

                    break;
            }
            return student[studentNum];
        }
    }
}


// Liste von Workshops machen als funktion, second/third switch-case als funktion, funktion von workshop z.B. ist rasenmähervoll, mit if else syntax
// Idee Lsite von workshops als arrayList, drinnen workshops als arrays mit schülern
// alternativ wird am anfang gefragt was für workshops existieren z.B: Anzahl: 
// max Anzahl gelöst werden durch for loop im ausserhalb vom case
// abschpeicher Name von Datei abfragen mit string im outPath
