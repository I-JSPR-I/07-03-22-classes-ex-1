using System;

namespace _07_03_22_classes_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bankrekening = new Bank();
            do
            {
                int Antwoord = Menu();
                if (Antwoord == 1)
                {
                    GeldStorten(Antwoord);
                }
                if (Antwoord == 2)
                {
                    GeldAfhalen(Antwoord);
                }
                if (Antwoord == 3)
                {
                    StatusBekijken(Antwoord);
                }

            } while (Convert.ToInt32(Console.ReadLine()) != 0);
        }

        private static void StatusBekijken(int Antwoord)
        {
        }

        private static void GeldAfhalen(int Antwoord)
        {

        }

        private static int GeldStorten(int Antwoord)
        {
            Console.Clear();
            Console.WriteLine("Hoeveel geld wilt u storten?");
            int gestortgeld = Convert.ToInt32(Console.ReadLine());

            return gestortgeld;
        }

        private static int Menu()
        {
            Console.WriteLine("Wat wilt u doen?");
            Console.WriteLine("(1) Geld storten");
            Console.WriteLine("(2) Geld Afhalen");
            Console.WriteLine("(3) Rekening bekijken");
            Console.WriteLine("(0) Menu sluiten");


            int Antwoord = Convert.ToInt32(Console.ReadLine());
            return Antwoord;
        }
    }
}
