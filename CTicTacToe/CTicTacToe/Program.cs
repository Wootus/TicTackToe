using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTicTacToe
{
    class Program
    {
        






        static void Main(string[] args)
       {


            Board.BDisplay();

            while (true)
               {

                    player.winner();
                    player.X_Turn();

                    player.winner();
                    player.O_Turn();
                }






               

            }
        }
    

    public class Board
    {

        public static char[] board = { 'Q', 'W', 'E',
                                'A', 'S', 'D',
                                'Z', 'X', 'C' };




        // Board method which creates board  
        public static void BDisplay()
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


    public class player
    {
        public static bool X_win = false;
        public static bool O_win = false;
        public static int moves = 0;


        public static void X_Turn()
        {


            bool flag = true;

            while (flag)
            {

                Console.WriteLine("+ turn");
                string plus = Console.ReadLine().ToUpper();

                if (moves == 9)
                {
                    Console.Clear();
                    Console.WriteLine("It was a tie-game");
                    flag = false;
                    Console.ReadLine();
                }

                else if (X_win == true)
                {
                    Console.Clear();
                    Console.WriteLine("+ WON THE GAME");
                    flag = false;
                    Console.ReadLine();
                }

                else if (O_win == true)
                {
                    Console.Clear();
                    Console.WriteLine("- WON THE GAME");
                    flag = false;
                    Console.ReadLine();
                }



                else if (plus == "Q" && Board.board[0] != '+' && Board.board[0] != '-')
                {
                    Board.board[0] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "W" && Board.board[1] != '+' && Board.board[1] != '-')
                {
                    Board.board[1] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "E" && Board.board[2] != '+' && Board.board[2] != '-')
                {
                    Board.board[2] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "A" && Board.board[3] != '+' && Board.board[3] != '-')
                {
                    Board.board[3] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "S" && Board.board[4] != '+' && Board.board[4] != '-')
                {
                    Board.board[4] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "D" && Board.board[5] != '+' && Board.board[5] != '-')
                {
                    Board.board[5] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "Z" && Board.board[6] != '+' && Board.board[6] != '-')
                {
                    Board.board[6] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "X" && Board.board[7] != '+' && Board.board[7] != '-')
                {
                    Board.board[7] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "C" && Board.board[8] != '+' && Board.board[8] != '-')
                {
                    Board.board[8] = '+';
                    moves++;
                    flag = false;
                }
                else
                {
                    Console.WriteLine("invalid move");

                }
            }

            Console.Clear();
            Board.BDisplay();
        }
        public static void O_Turn()
        {





            bool flag = true;

            while (flag)
            {

                Console.WriteLine("- turn");
                string plus = Console.ReadLine().ToUpper();

                if (moves == 9)
                {
                    Console.Clear();
                    Console.WriteLine("It was a tie-game");
                    flag = false;
                    Console.ReadLine();
                }

                else if (X_win == true)
                {
                    Console.Clear();
                    Console.WriteLine("+ WON THE GAME");
                    flag = false;
                    Console.ReadLine();
                }

                else if (O_win == true)
                {
                    Console.Clear();
                    Console.WriteLine("- WON THE GAME");
                    flag = false;
                    Console.ReadLine();
                }

                else if (plus == "Q" && Board.board[0] != '+' && Board.board[0] != '-')
                {
                    Board.board[0] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "W" && Board.board[1] != '+' && Board.board[1] != '-')
                {
                    Board.board[1] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "E" && Board.board[2] != '+' && Board.board[2] != '-')
                {
                    Board.board[2] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "A" && Board.board[3] != '+' && Board.board[3] != '-')
                {
                    Board.board[3] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "S" && Board.board[4] != '+' && Board.board[4] != '-')
                {
                    Board.board[4] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "D" && Board.board[5] != '+' && Board.board[5] != '-')
                {
                    Board.board[5] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "Z" && Board.board[6] != '+' && Board.board[6] != '-')
                {
                    Board.board[6] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "X" && Board.board[7] != '+' && Board.board[7] != '-')
                {
                    Board.board[7] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "C" && Board.board[8] != '+' && Board.board[8] != '-')
                {
                    Board.board[8] = '-';
                    moves++;
                    flag = false;
                }
                else
                {
                    Console.WriteLine("invalid move");

                }
            }


            Console.Clear();
            Board.BDisplay();

        }

        public static void winner()
        {
            //This function returns true if either of the players one of the eight possible winning patterns
            if (
                (Board.board[0] == '+' && Board.board[1] == '+' && Board.board[2] == '+') ||
                (Board.board[3] == '+' && Board.board[4] == '+' && Board.board[5] == '+') ||
                (Board.board[6] == '+' && Board.board[7] == '+' && Board.board[8] == '+') ||
                (Board.board[0] == '+' && Board.board[3] == '+' && Board.board[6] == '+') ||
                (Board.board[1] == '+' && Board.board[4] == '+' && Board.board[7] == '+') ||
                (Board.board[2] == '+' && Board.board[5] == '+' && Board.board[8] == '+') ||
                (Board.board[0] == '+' && Board.board[4] == '+' && Board.board[8] == '+') ||
                (Board.board[6] == '+' && Board.board[4] == '+' && Board.board[2] == '+'))
            {
                X_win = true;
            }
            else if (

      (Board.board[0] == '-' && Board.board[1] == '-' && Board.board[2] == '-') ||
(Board.board[3] == '-' && Board.board[4] == '-' && Board.board[5] == '-') ||
(Board.board[6] == '-' && Board.board[7] == '-' && Board.board[8] == '-') ||
(Board.board[0] == '-' && Board.board[3] == '-' && Board.board[6] == '-') ||
(Board.board[1] == '-' && Board.board[4] == '-' && Board.board[7] == '-') ||
(Board.board[2] == '-' && Board.board[5] == '-' && Board.board[8] == '-') ||
(Board.board[0] == '-' && Board.board[4] == '-' && Board.board[8] == '-') ||
(Board.board[6] == '-' && Board.board[4] == '-' && Board.board[2] == '-'))
            {
                O_win = true;
            }

        }




    }

}





