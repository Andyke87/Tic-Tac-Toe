using TicTacToe.Domain;

namespace TicTacToe.Cui
{
    public class TicTacToeApp
    {
        private readonly SpelController controller;

        char X = 'X';
        char O = 'O';
        char symboolSpeler1;

        public TicTacToeApp(SpelController sc)
        { this.controller = sc;}
        public void Start()
        {
            Console.WriteLine("Welkom bij Tic Tac Toe!\n");
            Console.Write("Naam speler 1: ");
            string naamSpeler1 = Console.ReadLine();

            do {
                Console.Write("Met welk symbool wilt u spelen (X of O): ");
                symboolSpeler1 = char.Parse(Console.ReadLine());
                symboolSpeler1 = char.ToUpper(symboolSpeler1);
            } while (symboolSpeler1 != X && symboolSpeler1 != O);

            Console.Write("Naam speler 2: ");
            string naamSpeler2 = Console.ReadLine();
            controller.RegistreerSpeler(naamSpeler1, symboolSpeler1);

            char symboolSpeler2;
            if (symboolSpeler1 == X) 
            { symboolSpeler2 = O; }
            else { symboolSpeler2 = X; }
            controller.RegistreerSpeler(naamSpeler2, symboolSpeler2);

            Console.WriteLine("\nHet spel gaat beginnen!");
            controller.ToonSpelbord();
            do
            {
                ToonSpelerAanZet(controller.HuidigeSpeler().naamSpeler);
                while (controller.RegistreerZet(VraagZet()) == false)
                { Console.WriteLine("Dit vakje is al bezet!\n");}
            } while (controller.HeeftSpelerGewonnen() == null);
            ToonEindresultaat();
        }
        public void ToonSpelerAanZet(string naam)
        { Console.WriteLine($"Speler aan zet: {naam}");}
        public void ToonEindresultaat()
        {
            string naam = controller.HeeftSpelerGewonnen();
            if (naam == "Gelijkspel")
            { Console.WriteLine("Gelijkspel!");}
            else
            { Console.WriteLine($"Speler {naam} heeft gewonnen!");}
        }
        public int VraagZet()
        {
            Console.Write("Geef de plaats van je zet: ");
            int input = int.Parse(Console.ReadLine());
            return input = input-1;
        }
    }
}