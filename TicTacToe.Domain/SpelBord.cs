using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Domain
{
    public class Spelbord
    {
        private List<char> vakjesMetSymbolen { get; set; }

        const char kruisje = 'X';
        const char rondje = 'O';
        const int min = 1;
        const int max = 10;
        bool check = false;
        char symbool;

        public Spelbord()
        {
            vakjesMetSymbolen = new List<char>();
            for (int i = min; i < max; i++)
            { vakjesMetSymbolen.Add(Char.Parse(i.ToString()));} 
            // om een karakter te kunnen toevoegen aan de lijst
        }
        public void ToonVeld()
        {
            Console.WriteLine("\n {0} | {1} | {2} ", vakjesMetSymbolen[0], vakjesMetSymbolen[1], vakjesMetSymbolen[2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", vakjesMetSymbolen[3], vakjesMetSymbolen[4], vakjesMetSymbolen[5]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} \n", vakjesMetSymbolen[6], vakjesMetSymbolen[7], vakjesMetSymbolen[8]);
        }
        public bool IsVeldVolzet()
        {
            bool check = false;
            // bekijk of alle vakjes gevuld zijn met een symbool
            foreach (var vakje in vakjesMetSymbolen)
            {
                if (vakje == rondje || vakje == kruisje)
                { check = true;}
                else
                { check = false;
                  break; }
            }
            return check;
        }
        public bool IsZetMogelijk(int vakje)
        {
            if (vakjesMetSymbolen[vakje] == rondje || vakjesMetSymbolen[vakje] == kruisje)
            { return check = false;}
            else
            { return check = true; }
        }
        public void PlaatsSymbool(char symbool, int vakje)
        { vakjesMetSymbolen[vakje] = symbool;}
        public char ControleerOpWinst()
        {
            for (int i = 0; i < 9; i += 3) // Horizontale rijen
            {
                if (vakjesMetSymbolen[i] == vakjesMetSymbolen[i+1] && vakjesMetSymbolen[i + 1] == vakjesMetSymbolen[i + 2])
                { return symbool = vakjesMetSymbolen[i];}
            }
            for (int i = 0; i < 3; i++) // Verticale rijen
            {
                if (vakjesMetSymbolen[i] == vakjesMetSymbolen[i + 3] && vakjesMetSymbolen[i + 3] == vakjesMetSymbolen[i + 6])
                { return symbool = vakjesMetSymbolen[i];}
            }
            if (vakjesMetSymbolen[0] == vakjesMetSymbolen[4] && vakjesMetSymbolen[4] == vakjesMetSymbolen[8])
            { return symbool = vakjesMetSymbolen[0];}
            if (vakjesMetSymbolen[2] == vakjesMetSymbolen[4] && vakjesMetSymbolen[4] == vakjesMetSymbolen[6])
            { return symbool = vakjesMetSymbolen[2];}
            else
            { return symbool = ' ';}
         return symbool;            
        }
    }
}