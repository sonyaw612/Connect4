using System;

namespace TicTacToe
{
    public class MainMenu
    {
        static char[] arr = {'0', '1', '2', '3', '4', '5', '6', '7', '8'};
        static int playerTurn = 1; 
        static int choosefield; 

        public void Start()
        {
            Console.WriteLine("TicTacToe Game");
            TTOBoard();
            //bool winning = false;
            //if(WinningCondition() == true) {winning = true;}
           // Console.WriteLine("Winning Check: "+ winning);
           // bool draw = false;
           // if(WinningCondition() == false) 
           // {
           //     if(DrawCondition() == true){draw = true;}
           //     else {draw = false;}
           // }
           // Console.WriteLine("Draw Check: " + draw);
            while(WinningCondition() != true){
                Console.WriteLine("\n");
                if(playerTurn == 1) 
                {
                    Console.WriteLine("Player 1 Turn");
                    Console.WriteLine("Player1:X");
                }
                else if(playerTurn == 2) 
                {
                    Console.WriteLine("Player 2 Turn");
                    Console.WriteLine("Player2:O");
                }
                Console.WriteLine("\n");

                TTOBoard();

                Console.WriteLine("Choose A Field Number: ");
                choosefield = int.Parse(Console.ReadLine());

                if (arr[choosefield] != 'X' && arr[choosefield] != 'O')
                {
                    if (playerTurn == 1) 
                    {
                        arr[choosefield] = 'X';
                        playerTurn++;
                    }
                    else if(playerTurn == 2)
                    {
                        arr[choosefield] = 'O';
                        playerTurn--;
                    }
                }
                else 
                {
                    Console.WriteLine("Field Already Taken Try Again");
                    Console.WriteLine("\n");
                }
                TTOBoard();
                bool winning = false;
                if(WinningCondition() == true) {winning = true;}
                Console.WriteLine("Winning Check: " + winning);
                bool draw = false;
                if(WinningCondition() == false) 
                {
                    if(DrawCondition() == true)
                    {
                        draw = true;
                        Console.WriteLine("Draw Check: " + draw);
                        break;
                    }
                    else {draw = false;}
                }
                Console.WriteLine("Draw Check: " + draw);
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            TTOBoard();
            Console.WriteLine("\n");
            if(WinningCondition() == true)
            {
                if(playerTurn == 1) {Console.WriteLine("Player 2 Has Won");}
                else if(playerTurn == 2) {Console.WriteLine("Player 1 Has Won");}
            }
            else if(DrawCondition() == true)
            {
                Console.WriteLine("Game : Draw");
            }

        }

        public static void TTOBoard()
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

        public static bool WinningCondition()
        {
            // Row Winning Statements
            if (arr[0] == arr[1] && arr[1] == arr[2])      {return true;}
            else if (arr[3] == arr[4] && arr[4] == arr[5]) {return true;}
            else if (arr[6] == arr[7] && arr[7] == arr[8]) {return true;}

            // Col Winning Statements
            else if (arr[0] == arr[3] && arr[3] == arr[6]) {return true;}
            else if (arr[1] == arr[4] && arr[4] == arr[7]) {return true;}
            else if (arr[2] == arr[5] && arr[5] == arr[8]) {return true;}

            //Diagonal Winning Statements
            else if (arr[0] == arr[4] && arr[4] == arr[8]) {return true;}
            else if (arr[2] == arr[4] && arr[4] == arr[6]) {return true;}

            // No true winning conditions then return false
            else {return false;}
        }

        public static bool DrawCondition()
        {
            // loop the array of characters
            for(int i = 0; i < arr.Length; i++)
            {
                // if character is a character or 0.1.2.3.4.5.6.7.8. then return no draw false
                if(arr[i] == '0' || arr[i] == '1' || arr[i] == '2' ||
                    arr[i] == '3' || arr[i] == '4' || arr[i] == '5' ||
                    arr[i] == '6' || arr[i] == '7' || arr[i] == '8') {return false;}
            }
            // return true all is filled with x and o 
            return true;
        }
    }
}

