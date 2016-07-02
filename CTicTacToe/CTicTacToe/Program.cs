using System;
using System.Collections;
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






            BDisplay();

            while (true)
            {

                winner();
                _X_Turn();

                winner();
                O_Turn();
            }
        }


        //    while (true)
        //    {

        //        winner();
        //        X_Turn();

        //        winner();
        //        O_Turn();
        //    }
        //}



        public static bool X_win = false;
        public static bool O_win = false;
        public static int moves = 0;













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




        // C_Plus returns the move (string plus) that will be used by the turn methods
        //It has four components
        //1) *checkmate* which will return the winning move if there is one availeble
        //2) *blockcheckmate* if there is not a checkmate move this move will chech if opponant has a checkmate move and block the path
        //3) *link two* If there is not a checkmate to win or to block this will place a second peice to link in a winning path  
        //4) *Places initial*  randomly on one of the four corners or middle for first two rounds



        private static string checkmate()
        {

            //Checkmate method
            // Checks if board is lined up for checkmate ticktacktoe move
            //should return pluse(winning move) or move to next function for next best move

            List<char[]> dalist = new List<char[]> {

            new char[3] { board[3], board[4], board[5] },
            new char[3] { board[0], board[4], board[8] },
            new char[3] { board[2], board[4], board[6] },
            new char[3] { board[1], board[4], board[7] },

            new char[3] { board[0], board[1], board[2] },
            new char[3] { board[6], board[7], board[8] },
            new char[3] { board[0], board[3], board[6] },
            new char[3] { board[2], board[5], board[8] }
        };


            int it1 = 0;
            int it2 = 0;
            int it3 = 0;
            int it4 = 0;
            char[] test = new char[3] { 'o', 'o', 'o' };


            foreach (var item in dalist)
            {
                it1++;
                if (item.Where(x => x == '+').Count() == 2 && !new string(item).Contains("-"))
                {

                    test = item;
                    return new string(item.Where(x => x != '+' && x != '-').ToArray());
                }
            }

            foreach (var item in dalist)
            {
                it2++;
                if (item.Where(x => x == '-').Count() == 2 && !new string(item).Contains("+"))
                    return new string(item.Where(x => x != '-' && x != '+').ToArray());
            }

            foreach (var item in dalist)
            {
                it3++;
                if (item.Where(x => x == '+').Count() == 1 && !new string(item).Contains("-"))
                    return item.Where(x => x != '+' && x != '-').First().ToString();
            }

            foreach (var item in dalist)
            {
                it4++;
                Random random = new Random();
                int rList = random.Next(0, 3);
                int rPosition = random.Next(0, 2);
                return dalist.ElementAt(rList).GetValue(rPosition).ToString();
            }









            return "?";



        }

















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



                else if (plus == "Q" && board[0] != '+' && board[0] != '-')
                {
                    board[0] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "W" && board[1] != '+' && board[1] != '-')
                {
                    board[1] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "E" && board[2] != '+' && board[2] != '-')
                {
                    board[2] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "A" && board[3] != '+' && board[3] != '-')
                {
                    board[3] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "S" && board[4] != '+' && board[4] != '-')
                {
                    board[4] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "D" && board[5] != '+' && board[5] != '-')
                {
                    board[5] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "Z" && board[6] != '+' && board[6] != '-')
                {
                    board[6] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "X" && board[7] != '+' && board[7] != '-')
                {
                    board[7] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "C" && board[8] != '+' && board[8] != '-')
                {
                    board[8] = '+';
                    moves++;
                    flag = false;
                }
                else
                {
                    Console.WriteLine("invalid move");
                    Console.ReadLine();

                }
            }

            Console.Clear();
            BDisplay();
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

                else if (plus == "Q" && board[0] != '+' && board[0] != '-')
                {
                    board[0] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "W" && board[1] != '+' && board[1] != '-')
                {
                    board[1] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "E" && board[2] != '+' && board[2] != '-')
                {
                    board[2] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "A" && board[3] != '+' && board[3] != '-')
                {
                    board[3] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "S" && board[4] != '+' && board[4] != '-')
                {
                    board[4] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "D" && board[5] != '+' && board[5] != '-')
                {
                    board[5] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "Z" && board[6] != '+' && board[6] != '-')
                {
                    board[6] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "X" && board[7] != '+' && board[7] != '-')
                {
                    board[7] = '-';
                    moves++;
                    flag = false;
                }
                else if (plus == "C" && board[8] != '+' && board[8] != '-')
                {
                    board[8] = '-';
                    moves++;
                    flag = false;
                }
                else
                {
                    Console.WriteLine("invalid move");
                    Console.ReadLine();

                }
            }


            Console.Clear();
            BDisplay();

        }
        public static void _X_Turn()
        {


            bool flag = true;

            while (flag)
            {

                Console.WriteLine("+ turn");
                string plus = checkmate();

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



                else if (plus == "Q" && board[0] != '+' && board[0] != '-')
                {
                    board[0] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "W" && board[1] != '+' && board[1] != '-')
                {
                    board[1] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "E" && board[2] != '+' && board[2] != '-')
                {
                    board[2] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "A" && board[3] != '+' && board[3] != '-')
                {
                    board[3] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "S" && board[4] != '+' && board[4] != '-')
                {
                    board[4] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "D" && board[5] != '+' && board[5] != '-')
                {
                    board[5] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "Z" && board[6] != '+' && board[6] != '-')
                {
                    board[6] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "X" && board[7] != '+' && board[7] != '-')
                {
                    board[7] = '+';
                    moves++;
                    flag = false;
                }
                else if (plus == "C" && board[8] != '+' && board[8] != '-')
                {
                    board[8] = '+';
                    moves++;
                    flag = false;
                }
                else
                {
                    Console.WriteLine("invalid move");

                    Console.ReadLine();

                }
            }

            Console.Clear();
            BDisplay();
        }


        public static void winner()
        {
            // This function returns true if either of the players one of the eight possible winning patterns
            if (
                (board[0] == '+' && board[1] == '+' && board[2] == '+') ||
                (board[3] == '+' && board[4] == '+' && board[5] == '+') ||
                (board[6] == '+' && board[7] == '+' && board[8] == '+') ||
                (board[0] == '+' && board[3] == '+' && board[6] == '+') ||
                (board[1] == '+' && board[4] == '+' && board[7] == '+') ||
                (board[2] == '+' && board[5] == '+' && board[8] == '+') ||
                (board[0] == '+' && board[4] == '+' && board[8] == '+') ||
                (board[6] == '+' && board[4] == '+' && board[2] == '+'))
            {
                X_win = true;
            }
            else if (

      (board[0] == '-' && board[1] == '-' && board[2] == '-') ||
(board[3] == '-' && board[4] == '-' && board[5] == '-') ||
(board[6] == '-' && board[7] == '-' && board[8] == '-') ||
(board[0] == '-' && board[3] == '-' && board[6] == '-') ||
(board[1] == '-' && board[4] == '-' && board[7] == '-') ||
(board[2] == '-' && board[5] == '-' && board[8] == '-') ||
(board[0] == '-' && board[4] == '-' && board[8] == '-') ||
(board[6] == '-' && board[4] == '-' && board[2] == '-'))
            {
                O_win = true;
            }

        }


    }
}
