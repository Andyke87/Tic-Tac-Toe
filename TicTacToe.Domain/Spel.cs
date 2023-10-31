using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Domain;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;

public class Spel
{
    private Spelbord spelbord { get; set; }
    private List<Speler> spelers { get; set; }
    private Speler speler { get; set;}

    bool eindeSpel;
    bool check = false;

    public Spel()
    { 
        spelbord = new Spelbord();
        spelers = new List<Speler>();
    }
    public void RegistreerSpeler(string naam, char symbool)
    { spelers.Add(new Speler(naam, symbool)); }
    public bool RegistreerZet(int vakje)
    {
        if (spelbord.IsZetMogelijk(vakje) == true)
        { spelbord.PlaatsSymbool(speler.symboolSpeler, vakje);
            spelbord.ToonVeld();
            return true;}
        else
        { return false;}
    }
    public bool ControleerIsVeldVolzet()
    {
        if (spelbord.IsVeldVolzet())
        { check = true;}
        else
        { check = false;}
        return check;
    }
    public string HeeftSpelerGewonnen()
    {
        char winst = spelbord.ControleerOpWinst();
        if (winst == spelers[0].symboolSpeler)
        { return spelers[0].naamSpeler;}
        else if (winst == spelers[1].symboolSpeler)
        { return spelers[1].naamSpeler;}
        else
        { return null;}
    }
    public Speler HuidigeSpeler()
    {
        // Als huidige speler speler 1 is, dan wordt huidige speler speler 2
        speler = speler == spelers[0] ? spelers[1] : spelers[0];
        return speler;
    }
}