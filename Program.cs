
namespace LA1200_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            my label;
            string antowerten = "DE";
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
                    int nummer = rnd.Next(1, 21);
                    Console.WriteLine("übersetze ins englisch:");
                    Console.WriteLine(deutsch[nummer]);
                    antwort[nummer] = Console.ReadLine();
                    if (antwort[nummer] == englisch[nummer])
                    {
                        Console.WriteLine("du hast es richtig übersetzt ");
                        pünkte++;
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
                    Console.WriteLine (punkte);
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
                    int nummer = rnd.Next(1, 21);
                    Console.WriteLine("übersetze auf Deutsch:");
                    Console.WriteLine(englisch[nummer]);
                    antwort[nummer] = Console.ReadLine();
                    if (antwort[nummer] == deutsch[nummer])
                    {
                        Console.WriteLine("du hast es richtig übersetzt ");
                        pünkte++;
                    }
                    else
                    {
                        Console.WriteLine("schlecht gemacht du lappen");
                    }
                    Console.WriteLine("willst du nochmal spielen? true/false");
                    wiederhohlung = Convert.ToBoolean(Console.ReadLine());
                    if (wiederhohlung = true)
                    {
                        goto my; label;
                    }
                }
                else
                {
                    Console.WriteLine ("du hast insgesamt");
                    Console.WriteLine(punkte);
                    Console.WriteLine("erziehlt");
                    DateTime Ende = DateTime.Now;
                    TimeSpan Zeit = Start - Ende;
                    Console.WriteLine(Zeit);
                }


            }



        }

    }
}
