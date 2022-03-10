using System;

namespace _07_03_22_classes_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Antwoord;
            Bank bankrekening = new Bank();
            do
            {
                Antwoord = Menu();
                if (Antwoord == 1)
                {
                    GeldStorten(Antwoord, bankrekening);
                }
                if (Antwoord == 2)
                {
                    GeldAfhalen(Antwoord, bankrekening);
                }
                if (Antwoord == 3)
                {
                    StatusBekijken(Antwoord, bankrekening);
                }
                if (Antwoord == 4)
                {
                    VerichtingenBekijken(Antwoord, bankrekening);
                }

            } while (Antwoord != 0);
        }

        private static void VerichtingenBekijken(int Antwoord, Bank bankrekening)
        {
            Console.WriteLine($"U heeft {bankrekening.Verichtingen} verichtingen gedaan");
            Console.WriteLine($"Druk op enter om verder te gaan.");
            Console.ReadLine();
        }

        private static void StatusBekijken(int Antwoord, Bank bankrekening)
        {
            Console.WriteLine($"Uw rekening bedraagt {bankrekening.Stand} euro");
            Console.WriteLine($"Druk op enter om verder te gaan.");
            Console.ReadLine();
        }

        private static void GeldAfhalen(int Antwoord, Bank bankrekening)
        {
            Console.Clear();
            Console.WriteLine("Hoeveel geld wilt u afhalen?");
            int GenomenGeld = Convert.ToInt32(Console.ReadLine());
            bankrekening.Verichtingen++;
            if ((bankrekening.Stand - GenomenGeld) < bankrekening.Limit)
            {
                Console.WriteLine($"U kunt niet onder {bankrekening.Limit} euro gaan");
                Console.WriteLine($"Druk op enter om verder te gaan.");
                Console.ReadLine();
            }

            bankrekening.Stand = bankrekening.Stand - GenomenGeld;
        }

        private static void GeldStorten(int Antwoord, Bank bankrekening)
        {
            Console.Clear();
            Console.WriteLine("Hoeveel geld wilt u storten?");
            int gestortgeld = Convert.ToInt32(Console.ReadLine());
            bankrekening.Stand = bankrekening.Stand + gestortgeld;
            bankrekening.Verichtingen++;
        }

        private static int Menu()
        {
            Console.Clear();
            Console.WriteLine("Wat wilt u doen?");
            Console.WriteLine("(1) Geld storten");
            Console.WriteLine("(2) Geld Afhalen");
            Console.WriteLine("(3) Rekening bekijken");
            Console.WriteLine("(4) Verichtingen bekijken");
            Console.WriteLine("(0) Menu sluiten");


            int Antwoord = Convert.ToInt32(Console.ReadLine());
            return Antwoord;
        }
    }
}
