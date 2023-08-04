using TicTacToe.Domain;
namespace TicTacToe.Domain
{
    public class SpelController
    {
        private Spel _spel { get; set; }

        const char X = 'X';
        const char O = 'O';

        public SpelController()
        {
            _spel = new Spel();
        }
        public void RegistreerSpeler(string naam, char symbool)
        {
            if (symbool == X)
            { _spel.RegistreerSpeler(naam, X);}
            else
            { _spel.RegistreerSpeler(naam, O);}
        }
        public bool RegistreerZet(int vakje)
        {
            if (_spel.RegistreerZet(vakje) == true)
            { return true; }
            else
            { return false; }
        }
        public string HeeftSpelerGewonnen()
        {
            string naam = _spel.HeeftSpelerGewonnen();
            if (naam != null)
            { return naam;}
            else if (_spel.ControleerIsVeldVolzet() == true)
            { return "Gelijkspel";}
            else
            { return null;}
        }
        public Speler HuidigeSpeler()
        { Speler huidigeSpeler = _spel.HuidigeSpeler();
            return huidigeSpeler;
        }
        public void ToonSpelbord()
        { 
            Spelbord _spelbord = new Spelbord();
            _spelbord.ToonVeld();
        }
    }
}