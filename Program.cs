namespace LA1200_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string antowerten = "DE";
            Console.WriteLine("Möchtest du auf English(EN) oder auf Deutsch(DE) antworten?");
            string antwort = Console.ReadLine();

            if (antwort == "DE")
            {

                Console.WriteLine("Sie antworten jetzt auf deutsch");
            }else if (antwort == "EN")
            {

                Console.WriteLine ("Sie antworten jetzt auf english");
            }



        }   

    }
}