
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
                wiederhohlung = (Console.ReadLine());
            }
            else
            {
                        console.writline("du hast insgesamt");            
                        console.writline(punkte);
                        console.writline("erziehlt");
                        DateTime Ende = DateTime.Now;
                        TimeSpan Zeit = Start - Ende;
                        Console.WriteLine(Zeit);
            }

hat Kontextmenü
