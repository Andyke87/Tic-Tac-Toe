using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Domain
{
    public class Speler
    {
        public string naamSpeler { get; set; }
        public char symboolSpeler { get; set; }

        public Speler(string naam)
        { naamSpeler = naam;}
        public Speler(string naam, char symbool) : this(naam)
        { symboolSpeler = symbool;}
    }
}
