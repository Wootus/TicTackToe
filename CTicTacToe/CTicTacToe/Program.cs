using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTicTacToe
{
	class Program
	{
        //Array for available places on the board.
        static char[] board = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
		static void Main(string[ ] args)
		{
            //test commit

            Board();
            Console.ReadKey();

		}
        // Board method which creats board  
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
            Console.WriteLine("     |     |      ");
        }
	}
}
