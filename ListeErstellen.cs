namespace ListenErstellen
{
    public class Program
    {
        static void Main(string[] args)
        {
                int i = 0;
                string[] email = new string[i];
                string[] priority = new string[i];
                string[] priority2 = new string[i];
                string[] priority3 = new string[i];

                char answer;

                do
                {

                    Console.WriteLine("Geben sie ihre Email adresse ein.");

                    string data = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Geben sie ihre erste Priorität ein");

                    string data2 = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Geben sie ihre zweite Priorität ein");

                    string data3 = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Geben sie ihre driite Priorität ein");

                    string data4 = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Willst du weitere Schüler eingeben? [y/n]");


                    answer = Convert.ToChar(Console.ReadLine());

                    if (answer == 'y')
                    {
                     i++;
                        email[i] = data;
                        priority[i] = data2;
                        priority2[i] = data3;
                        priority3[i] = data4;
                        
                    }

                } while (answer == 'y');
            if (answer == 'n')
            {
                string outText = "";

            for (i = 0; i < email.Length; i++) {

                outText = $"{i}, {email[i]},{priority[i]},{priority2[i]},{priority3[i]}";
            }

                    Console.WriteLine("Überprüfen sie ihre Liste");
                    string outPath = @"C:\Users\gabri\OneDrive - Alte Kantonsschule Aarau\IMS Lernatelier\Schülerliste.csv";
               
                    File.WriteAllText(outPath, outText);
            }
        }
    }
}



