namespace LA1200_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] antwort = { "diese", "wörter", "werden","überschrieben" };
              


                string inPath = @"Voci.csv";
            string text = File.ReadAllText(inPath);





            string[] lines = text.Split("\r\n");





            int words = lines.Length;
            string[] english = new string[words];
            string[] deutsch = new string[words];
            int[] points = new int[words];



            Console.WriteLine("Wilkommen in unserem kleinen Vociprogramm");
            Console.WriteLine("Würden Sie uns einige Fragen über Sie beantworten? (Ja/Nein)");
            string endscheidung = Console.ReadLine();



            if (endscheidung == "Ja")
            {
                Console.WriteLine("Bitte Geben Sie ihren Vornamen an");
                Console.ReadLine();
                Console.WriteLine("Bitte geben Sie noch ihr Alter an");
                Console.ReadLine();

            }

            else if (endscheidung == "Nein")



            {
                Console.WriteLine("Dann machen wir jetzt weiter");
            }


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


            int punkte = 0;
        label:
            Console.WriteLine("Möchtest du auf English(EN) oder auf Deutsch(DE) antworten?");
            string Antwort = Console.ReadLine();

            if (Antwort.Equals( "DE"))
            {
                Console.WriteLine("Sie antworten jetzt auf deutsch");
                Console.WriteLine("Herzlich Willkommen zur Englisch Voci abfrage!");


                DateTime Start = DateTime.Now;
                bool wiederhohlung = true;
                for (int i = 0; 21 > i; i++)
                {


                    Console.WriteLine("übersetze ins englisch:");
                    Console.WriteLine(deutsch[i]);
                    antwort[i] = Console.ReadLine();
                    if (antwort[i].Equals( english[i]))
                    {
                        Console.WriteLine("du hast es richtig übersetzt ");
                        punkte++;
                    }
                    else
                    {
                        Console.WriteLine("schlecht gemacht du lappen");
                    }
                }   
                    
                        Console.WriteLine("du hast insgesamt");
                        Console.WriteLine();
                        Console.WriteLine("erziehlt");
                        DateTime Ende = DateTime.Now;
                        TimeSpan Zeit = Start - Ende;
                        Console.WriteLine(Zeit);
                    

            }
            else if (antwort.Equals( "EN"))
            {
                Console.WriteLine("Sie antworten jetzt auf english");
                Console.WriteLine("Herzlich Willkommen zur Englisch Voci abfrage!");


                DateTime Start = DateTime.Now;
                for (int i = 0; i < 21; i++)
                { 
                    Console.WriteLine("übersetze auf Deutsch:");
                Console.WriteLine(english[i]);
                antwort[i] = Console.ReadLine();
                if (antwort[i].Equals( deutsch[i]))
                {
                    Console.WriteLine("du hast es richtig übersetzt ");
                    punkte++;
                }
                else
                {
                    Console.WriteLine("schlecht gemacht du lappen");
                }
                }
                    Console.WriteLine("du hast insgesamt");
                    Console.WriteLine(punkte);
                    Console.WriteLine("erziehlt");
                    DateTime Ende = DateTime.Now;
                    TimeSpan Zeit = Ende - Start ;
                    Console.WriteLine(Zeit);
                


            }

            Console.WriteLine("Danke für das durchlaufen unseres Voci programm.");
            Console.WriteLine("Würden Sie uns noch noch eine Rückmeldung zum Programm geben? (Ja/Nein)");
            string Rückmeldung = Console.ReadLine();






            if (Rückmeldung == "Ja")
            {
                Console.WriteLine("Wie fanden Sie unser Programm? (Schlecht/Okay/Gut)");
                Console.ReadLine();
                Console.WriteLine("Hätten Sie noch Verbersserungsvorschläge? (Fals Ja bitte unten eingeben, fals Nein einfach Nein schreiben)");
                Console.ReadLine();





            }




            else if (Rückmeldung == "Nein")
            {



                Console.WriteLine("Trozdem danke");




            }

        }

    }
}


