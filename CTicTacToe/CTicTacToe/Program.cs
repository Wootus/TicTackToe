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






        static void Main(string[] args)
        {
            //test commit

            Board.BDisplay();


            

            while (!player.winner() && !player.tiegame())
            {
                player.X_Turn();
                player.O_Turn();
            }






            Console.ReadKey();

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
        public static void X_Turn()
        {


            bool flag = true;

            while (flag)
            {

                Console.WriteLine("+ turn");
                string plus = Console.ReadLine().ToUpper();

                if (plus == "Q" && Board.board[0] != '+' && Board.board[0] != '-')
                {
                    Board.board[0] = '+';
                    flag = false;
                }
                else if (plus == "W" && Board.board[1] != '+' && Board.board[1] != '-')
                {
                    Board.board[1] = '+';
                    flag = false;
                }
                else if (plus == "E" && Board.board[2] != '+' && Board.board[2] != '-')
                {
                    Board.board[2] = '+';
                    flag = false;
                }
                else if (plus == "A" && Board.board[3] != '+' && Board.board[3] != '-')
                {
                    Board.board[3] = '+';
                    flag = false;
                }
                else if (plus == "S" && Board.board[4] != '+' && Board.board[4] != '-')
                {
                    Board.board[4] = '+';
                    flag = false;
                }
                else if (plus == "D" && Board.board[5] != '+' && Board.board[5] != '-')
                {
                    Board.board[5] = '+';
                    flag = false;
                }
                else if (plus == "Z" && Board.board[6] != '+' && Board.board[6] != '-')
                {
                    Board.board[6] = '+';
                    flag = false;
                }
                else if (plus == "X" && Board.board[7] != '+' && Board.board[7] != '-')
                {
                    Board.board[7] = '+';
                    flag = false;
                }
                else if (plus == "C" && Board.board[8] != '+' && Board.board[8] != '-')
                {
                    Board.board[8] = '+';
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

                if (plus == "Q" && Board.board[0] != '+' && Board.board[0] != '-')
                {
                    Board.board[0] = '-';
                    flag = false;
                }
                else if (plus == "W" && Board.board[1] != '+' && Board.board[1] != '-')
                {
                    Board.board[1] = '-';
                    flag = false;
                }
                else if (plus == "E" && Board.board[2] != '+' && Board.board[2] != '-')
                {
                    Board.board[2] = '-';
                    flag = false;
                }
                else if (plus == "A" && Board.board[3] != '+' && Board.board[3] != '-')
                {
                    Board.board[3] = '-';
                    flag = false;
                }
                else if (plus == "S" && Board.board[4] != '+' && Board.board[4] != '-')
                {
                    Board.board[4] = '-';
                    flag = false;
                }
                else if (plus == "D" && Board.board[5] != '+' && Board.board[5] != '-')
                {
                    Board.board[5] = '-';
                    flag = false;
                }
                else if (plus == "Z" && Board.board[6] != '+' && Board.board[6] != '-')
                {
                    Board.board[6] = '-';
                    flag = false;
                }
                else if (plus == "X" && Board.board[7] != '+' && Board.board[7] != '-')
                {
                    Board.board[7] = '-';
                    flag = false;
                }
                else if (plus == "C" && Board.board[8] != '+' && Board.board[8] != '-')
                {
                    Board.board[8] = '-';
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

        public static bool winner()
        {
            //This function returns true if either of the players one of the eight possible winning patterns
            if (
                (Board.board[0] == '+' && Board.board[1] == '+' && Board.board[2] == '+')||
                (Board.board[0] == '-' && Board.board[1] == '-' && Board.board[2] == '-')||

                (Board.board[3] == '+' && Board.board[4] == '+' && Board.board[5] == '+') ||
                (Board.board[3] == '-' && Board.board[4] == '-' && Board.board[5] == '-') ||

                (Board.board[6] == '+' && Board.board[7] == '+' && Board.board[8] == '+') ||
                (Board.board[6] == '-' && Board.board[7] == '-' && Board.board[8] == '-') ||

                (Board.board[0] == '+' && Board.board[3] == '+' && Board.board[6] == '+') ||
                (Board.board[0] == '-' && Board.board[3] == '-' && Board.board[6] == '-') ||

                (Board.board[1] == '+' && Board.board[4] == '+' && Board.board[7] == '+') ||
                (Board.board[1] == '-' && Board.board[4] == '-' && Board.board[7] == '-') ||

                (Board.board[2] == '+' && Board.board[5] == '+' && Board.board[8] == '+') ||
                (Board.board[2] == '-' && Board.board[5] == '-' && Board.board[8] == '-') ||

                (Board.board[0] == '+' && Board.board[4] == '+' && Board.board[8] == '+') ||
                (Board.board[0] == '-' && Board.board[4] == '-' && Board.board[8] == '-') ||

                (Board.board[6] == '+' && Board.board[4] == '+' && Board.board[2] == '+') ||
                (Board.board[6] == '-' && Board.board[4] == '-' && Board.board[2] == '-') 

                )
            {
                
                return true;
            }
            else
            {
                return false;
            }



        }
        public static bool tiegame()
        {
           //Returns True if there are no availeble spots on the board

            if(Board.board.Any(x=> x == 'Q' || x=='W' || x=='E' || x=='A' || x=='S' || x == 'D' || x =='Z' || x =='X' || x == 'C'))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }

}
