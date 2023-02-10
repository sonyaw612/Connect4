using System;

namespace TicTacToe
{
    class MainMenu
    {
        static char[] arr = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};

        public static void Main(string[] args)
        {
            Console.WriteLine("TicTacToe Game Start");
            TTOBoard();
        }

        private static void TTOBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[0], arr[1], arr[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[3], arr[4], arr[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[6], arr[7], arr[8]);
            Console.WriteLine("     |     |      ");
        }
    }
}

