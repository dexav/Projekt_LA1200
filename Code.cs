using System.Collections;
using System.Globalization;
using System.Net.WebSockets;
using System.Reflection.Emit;

namespace Vokabelabfragesystem
{
    internal class Program
    {
        private static int highscore = 0;
        private static int falscheWörter = 0;
        private static int richtigeWörter = 0;
        private static ArrayList bereitsÜbersetzt = new ArrayList();
        private static int wörterÜbersetzt = 0;
        private static string aktuellesWort = "";
        private static string übersetzeWort = "";


        static void Main(string[] args)
        {
            string inPath = @"Voci.csv";
            string text = File.ReadAllText(inPath);

            string[] lines = text.Split("\r\n");

            int words = lines.Length;
            string[] english = new string[words];
            string[] deutsch = new string[words];
            int[] points = new int[words];

            for (int line = 0; line < lines.Length; line++)
            {
                string[] items = lines[line].Split(',');
                english[line] = items[0];
                deutsch[line] = items[1];
                points[line] = Convert.ToInt32(items[2]);
            }

            for (int line = 0; line < lines.Length; line++)
            {
                string[] items = lines[line].Split(',');
                english[line] = items[0];
                deutsch[line] = items[1].Replace("\"", string.Empty);
                points[line] = Convert.ToInt32(items[2]);
            }
            string outText = "";

            Random rnd = new Random();

            for (int i = 0; i < deutsch.Length; i++)
            {
                outText += $"{i},{english[i]},{rnd.Next()}\r\n";
            }
            string outPath = @"Voci.csv";

            File.WriteAllText(outPath, outText);

            int punkte = 0;

        label:
            Console.WriteLine("Möchtest du auf English(EN) oder auf Deutsch(DE) antworten?");
            string antwort = Console.ReadLine();

            if (antwort == "DE")
            {
                Console.WriteLine("Sie antworten jetzt auf deutsch");
                Console.WriteLine("Herzlich Willkommen zur Englisch Voci abfrage!");

                DateTime Start = DateTime.Now;
                bool wiederhohlung = true;

                if (wiederhohlung == true)
                {
                    Random random = new Random();
                    int nummer = random.Next(1, 21);
                    Console.WriteLine("übersetze ins englisch:");
                    Console.WriteLine(deutsch[nummer]);
                    antwort[nummer] = Console.ReadLine();
                    if (antwort[nummer] == english[nummer])
                    {
                        Console.WriteLine("du hast es richtig übersetzt ");
                        punkte++;
                    }
                    else
                    {
                        Console.WriteLine("schlecht gemacht du lappen");
                    }
                    Console.WriteLine("willst du nochmal spielen? true/false");
                    wiederhohlung = Convert.ToBoolean((Console.ReadLine()));
                }
                else
                {
                    Console.WriteLine("du hast insgesamt");
                    Console.WriteLine();
                    Console.WriteLine("erziehlt");
                    DateTime Ende = DateTime.Now;
                    TimeSpan Zeit = Start - Ende;
                    Console.WriteLine(Zeit);
                }

            }
            else if (antwort == "EN")
            {
                Console.WriteLine("Sie antworten jetzt auf english");
                Console.WriteLine("Herzlich Willkommen zur Englisch Voci abfrage!");


                DateTime Start = DateTime.Now;
                bool wiederhohlung = true;
                if (wiederhohlung == true)
                {
                    Random rnd = new Random();
                    int nummer = rnd.Next(1, 21);
                    Console.WriteLine("übersetze auf Deutsch:");
                    Console.WriteLine(englisch[nummer]);
                    antwort[nummer] = Console.ReadLine();
                    if (antwort[nummer] == deutsch[nummer])
                    {
                        Console.WriteLine("du hast es richtig übersetzt ");
                        punkte++;
                    }
                    else
                    {
                        Console.WriteLine("schlecht gemacht du lappen");
                    }
                    Console.WriteLine("willst du nochmal spielen? true/false");
                    wiederhohlung = Convert.ToBoolean(Console.ReadLine());
                    if (wiederhohlung = true)
                    {
                        goto label;
                    }
                }
                else
                {
                    Console.WriteLine("du hast insgesamt");
                    Console.WriteLine();
                    Console.WriteLine("erziehlt");
                    DateTime Ende = DateTime.Now;
                    TimeSpan Zeit = Start - Ende;
                    Console.WriteLine(Zeit);
                }

            }

        }

        public static int Highscore(int falscheWörter, int richtigeWörter)
        {
            if(richtigeWörter < falscheWörter)
            {
                Console.WriteLine("Kein Highscore");
            }

            int Punkte = richtigeWörter - falscheWörter;
            
            if (Punkte > highscore)
            {
                highscore = Punkte;
                Console.WriteLine("Highscore: " + highscore);
            }

            return highscore;
        }

    }
}
