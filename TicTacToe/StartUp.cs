using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Channels;
using System.Threading;
using TicTacToe.Domain;
using TicTacToe.Cui;

namespace TicTacToe
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SpelController sc = new SpelController();
            TicTacToeApp cui = new TicTacToeApp(sc);
            cui.Start();
        }
    }
}