using System.Collections;
using System.Globalization;
using System.Net.WebSockets;
using System.Reflection.Emit;

namespace Vokabelabfragesystem
{
    internal class Program
    {
        private static int highscore = 0;
        private static ArrayList bereitsÜbersetztDeutsch = new ArrayList();
        private static ArrayList bereitsÜbersetztEnglish = new ArrayList();


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

            Console.WriteLine("Wilkommen in unserem kleinen Vociprogramm");
            Console.WriteLine("Würden Sie uns einige Fragen über Sie beantworten? (Ja/Nein)");
            string endscheidung = Console.ReadLine();


            if (endscheidung.ToLower() == "ja")
            {
                Console.WriteLine("Bitte Geben Sie ihren Vornamen an");
                Console.ReadLine();
                Console.WriteLine("Bitte geben Sie noch ihr Alter an");
                Console.ReadLine();
            }

            else if (endscheidung.ToLower() == "nein")
            {
                Console.WriteLine("Dann machen wir jetzt weiter");
            }

            int punkte = 0;

            Console.WriteLine("Möchtest du auf English(EN) oder auf Deutsch(DE) antworten?");
            string antwort = Console.ReadLine();

            if (antwort == "DE")
            {
                Console.WriteLine("Sie antworten jetzt auf deutsch");
                Console.WriteLine("Herzlich Willkommen zur Englisch Voci abfrage!");

                DateTime Start = DateTime.Now;
                bool wiederholung = true;

                do
                {
                    if (wiederholung == true)
                    {
                        int nummer;
                        bool istGleich = false;
                        int loop = 0;
                        bool alleVociÜbersetzt = false;

                        do
                        {                            
                            Random random = new Random();
                            nummer = random.Next(0, deutsch.Count());

                            loop++;

                            if (loop == 5)
                            {
                                alleVociÜbersetzt = true;
                            }

                            if (bereitsÜbersetztDeutsch.Count == 0)
                            {                                
                                break;
                            }

                            for (int i = 0; i < bereitsÜbersetztDeutsch.Count; i++)
                            {
                                string bereitsÜbersetzt = Convert.ToString(bereitsÜbersetztDeutsch[i]);
                                Console.WriteLine(bereitsÜbersetzt);

                                if (bereitsÜbersetzt == deutsch[nummer])
                                {
                                    istGleich = true;
                                    break;
                                }
                                istGleich = false;
                            }

                                                     
                        } while (istGleich == true);

                        if (alleVociÜbersetzt == true)
                        {
                            break;
                        }

                        Console.WriteLine("übersetze ins englisch:");
                        Console.WriteLine(deutsch[nummer]);
                        string übersetzung = Console.ReadLine();
                        if (übersetzung == english[nummer])
                        {
                            Console.WriteLine("Du hast es richtig übersetzt ");
                            bereitsÜbersetztDeutsch.Add(deutsch[nummer]);
                            punkte++;
                        }
                        else
                        {
                            Console.WriteLine("schlecht gemacht du lappen");
                            punkte--;
                        }
                        Console.WriteLine("willst du nochmal spielen? true/false");
                        wiederholung = Convert.ToBoolean((Console.ReadLine()));
                    }
                  
                }while (wiederholung == true);

                Console.WriteLine("Du hast " + punkte + " Punkte erziehlt!");
                DateTime Ende = DateTime.Now;
                TimeSpan Zeit = Ende - Start;
                Console.WriteLine(Zeit);
            }
            else if (antwort == "EN")
            {
                Console.WriteLine("Herzlich Willkommen zur English Voci abfrage!\n");

                DateTime Start = DateTime.Now;
                bool wiederholung = true;

                do
                {
                    if (wiederholung == true)
                    {
                        int nummer;
                        bool istGleich = false;
                        int loop = 0;
                        bool alleVociÜbersetzt = false;

                        do
                        {
                            Random rnd = new Random();
                            nummer = rnd.Next(0, english.Count());

                            loop++;

                            if (loop == 20)
                            {
                                alleVociÜbersetzt = true;
                            }

                            if (bereitsÜbersetztEnglish.Count == 0)
                            {
                                break;
                            }

                            for (int i = 0; i < bereitsÜbersetztEnglish.Count; i++)
                            {
                                string bereitsÜbersetzt = Convert.ToString(bereitsÜbersetztEnglish[i]);

                                if (bereitsÜbersetzt == english[nummer])
                                {
                                    istGleich = true;
                                    break;
                                }
                                istGleich = false;
                            }


                        } while (istGleich == true);

                        if (alleVociÜbersetzt == true)
                        {
                            break;
                        }

                        Console.WriteLine("Übersetze auf Deutsch:");
                        Console.WriteLine(english[nummer]);
                        string übersetzung2 = Console.ReadLine();
                        if (übersetzung2 == deutsch[nummer])
                        {
                            Console.WriteLine("Du hast es richtig übersetzt ");
                            bereitsÜbersetztEnglish.Add(english[nummer]);
                            punkte++;
                        }
                        else
                        {
                            Console.WriteLine("schlecht gemacht du lappen");
                            punkte--;
                        }
                        Console.WriteLine("\nWillst du nochmal spielen? true/false");
                        wiederholung = Convert.ToBoolean(Console.ReadLine());
                        
                    }
                } while (wiederholung == true);

                File.WriteAllText("punkte.txt", Convert.ToString(punkte));

                Console.WriteLine("Du hast " + punkte + " Punkte erziehlt!");
                DateTime Ende = DateTime.Now;
                TimeSpan Zeit = Ende - Start;
                Console.WriteLine(Zeit);

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
