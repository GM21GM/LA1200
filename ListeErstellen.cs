namespace ListenErstellen
{
    public class Program
    {
        static void Main(string[] args)
        {

           
                




                int i = 0;
                string[] email = new string[i];
                string[] priorität = new string[i];
                string[] priorität2 = new string[i];
                string[] priorität3 = new string[i];

                string daten;
                string daten2;
                string daten3;
                string daten4;

                char answer;


                do
                {

                    Console.WriteLine("Geben sie ihre Email adresse ein.");

                    daten = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Geben sie ihre erste Priorität ein");

                    daten2 = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Geben sie ihre zweite Priorität ein");

                    daten3 = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Geben sie ihre driite Priorität ein");

                    daten4 = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Willst du weitere Schüler eingeben? [y/n]");


                    answer = Convert.ToChar(Console.ReadLine());

                    if (answer == 'y' && answer == 'n')
                    {
                        email[i] = daten;
                        priorität[i] = daten2;
                        priorität2[i] = daten3;
                        priorität3[i] = daten4;
                        i++;
                    }

                } while (answer == 'y');

            string outText = "";

                if (answer == 'n')
                {

                    Console.WriteLine("Überprüfen sie ihre Liste");
                    string outPath = @"C:\Users\gabri\OneDrive - Alte Kantonsschule Aarau\IMS Lernatelier\Schülerliste.txt";
               
                    File.WriteAllText(outPath, outText);
                }


        }
    }

}
