using System;
using System.Linq;
using System.Text;

/*
TO-DO List:
    - Logic for diagonal wins
*/

public class Connect4 {
    public static void Main(string[] args) {

        int[,] tttGrid = new int[6, 7];
        int gridCols = tttGrid.Length/tttGrid.GetLength(0);
        int gridRows = tttGrid.GetLength(0);
        
        int[] colProgress = new int[gridCols];
        Array.Fill(colProgress, gridRows-1);

        int turn = tttGrid.Length;
        int currPlayer = 1;
        int numberToWin = 4;

        int player1 = 1;
        int player2 = 2;
        

        
//*
        while(turn != 0) {

            drawGrid(tttGrid);
            
        /*  Console.ForegroundColor = (currPlayer == 1) ? ConsoleColor.Red : ConsoleColor.Blue;
            Console.Write("Player {0}'s turn:\nRow: ", currPlayer);
            Console.ForegroundColor = ConsoleColor.White;
            int playerRow = int.Parse(Console.ReadLine()) - 1;
        //*/

        //* PROMPTING USER FOR COLUMN INPUT
            Console.ForegroundColor = (currPlayer == player1) ? ConsoleColor.Red : ConsoleColor.Blue;
            Console.Write("Column: ");
            Console.ForegroundColor = ConsoleColor.White;
            int playerCol = 0;
            bool playerInput = int.TryParse(Console.ReadLine(), out playerCol);
            playerCol--;
        //*/

        // IF PLAYER DID NOT INPUT A VALUE OR A VALID COLUMN, PROMPT PLAYER TO TRY AGAIN
            if(playerCol > gridCols-1 || playerCol < 0 || !playerInput){
                Console.WriteLine("Invalid Column. Please input a number 1 through 3\n");
                continue;
            }
        // IF COLUMN IS FULL, PROMPT PLAYER TO TRY AGAIN
            if(colProgress[playerCol] < 0) {
                Console.WriteLine("That column is full. Choose another column.\n");
                continue;
            }
        // IF ABLE TO, PLACE PIECE IN DESIRED COLUMN, AND CHECK WIN
            if(tttGrid[colProgress[playerCol], playerCol] == 0) {
                tttGrid[colProgress[playerCol], playerCol] = currPlayer;
                colProgress[playerCol]--;
                bool playerWon = checkWin(tttGrid, currPlayer, numberToWin); // REMEMBER to adjust numToWin
                if(playerWon) {
                    drawGrid(tttGrid);
                    Console.WriteLine("Player {0} won!!", currPlayer);
                    break;
                }
            }   

        // ALTERNATE BETWEEN PLAYER 1 AND 2
            currPlayer = (currPlayer == player1) ? player2 : player1;
        // LIMITS HOW MANY TIMES PLAYERS CAN GO ACCUMULATIVELY
            turn--; 
        }
//*/
    }

    public static void drawGrid(int[,] grid) {
        int gridRows = grid.GetLength(0);
        int gridCols = grid.Length/grid.GetLength(0);

        Console.WriteLine();
        for(int i = 0; i < gridRows; i++) {
            for(int k = 0; k < gridCols; k++) {
                Console.Write("|     ");
                if(k == gridCols - 1) Console.Write("|");
            }
            Console.WriteLine();
            for(int j = 0; j < gridCols; j++) {
                int val = grid[i, j];
                switch (val)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("|  O  ");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("|  O  ");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;                        
                    default: 
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("|  -  ");
                        break;
                }
                if(j == gridCols - 1) Console.Write("|");
            }
            Console.WriteLine();
            for(int k = 0; k < gridCols; k++) {
                Console.Write("|     ");
                if(k == gridCols - 1) Console.Write("|");
            }
            Console.WriteLine();
            for(int k = 0; k < gridCols; k++) {
                Console.Write("------");
            }
            Console.WriteLine();
        }
        for(int i = 0; i < gridCols; i++) {
            Console.Write("   {0}  ", i + 1);
        }
        Console.WriteLine("\n  ---   ---   ---   ---   ---   ---   ---  ");
    }

    private static bool checkWin(int[,] grid, int player, int numToWin) {
        int gridRows = grid.GetLength(0);
        int gridCols = grid.Length/grid.GetLength(0);

        int[] winV = new int[gridCols]; // keeps track of vertical win
        for(int i = gridRows-1; i >= 0 ; i--) {
            int winH = 0; // keeps track of horizontal win
            for(int j = 0; j < gridCols; j++) {
                if(grid[i, j] == player) {
                    winH ++;
                    winV[j]++;
                }
                else {
                    winH = 0;
                    winV[j] = 0;
                }
                if(winH == numToWin || winV[j] == numToWin) {

                    if(player == 1) {
                        Console.Write("Vertical win:");
                        for(int t = 0; t < winV.Length; t++) {
                            Console.Write(" {0}", winV[t]);
                        } Console.WriteLine();
                    }
                    return true;
                }
            }
        }

        return false;

    }
}