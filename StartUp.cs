using TicTacToe.Cui;
using TicTacToe.Domain;

namespace TicTacToe.StartUp
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            SpelController controller = new SpelController();
            TicTacToeApp cui = new TicTacToeApp();
            cui.Start();
        }
    }

}