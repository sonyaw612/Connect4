/*
Variables:
    2D array: 6 rows, 7 columns
        0 = nobody put their piece
        1 = player 1
        2 = player 2
    
Logic for determining win:
    1 for loop to check rows with a nested or loop to check columns
*/
using System;

public class Connect4 {
    public static void Main(string[] args) {

        int[,] tttGrid = new int[3, 3];
        // foreach(int box in tttGrid.Length){
        // Array.Fill(tttGrid[box], 0);
        // }
        const int player1 = 1;
        const int player2 = 2;
        int currentPlayer = player1;

    // Length is the total length of the whole array
        // int gridRow = tttGrid.Length;
        // int gridCol = tttGrid.GetLength(0);

        // Console.WriteLine("Row {0} , Col {1}", gridRow, gridCol);

        Console.WriteLine(@"
             |     |    
          -  |  -  |  -
        _____|_____|_____
             |     |    
          -  |  -  |  -
        _____|_____|_____              
             |     |    
          -  |  -  |  -
             |     |
        ");

        int turn = tttGrid.Length;
        int currPlayer = 1;
        
        Console.WriteLine(turn);
//*
        while(turn != 0) {
            
            
            Console.Write("Player {0}'s turn:\nRow:", currPlayer);
            int playerRow = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Column:");
            int playerCol = int.Parse(Console.ReadLine()) - 1;

            
            if(playerRow > 2 || playerCol > 2 || playerRow < 0 || playerCol < 0){
                Console.WriteLine("Invalid Row/Column. Please input a number 1 through 3");
                continue;
            }
            if(tttGrid[playerRow, playerCol] == null) {
                tttGrid[playerRow, playerCol] = currPlayer;
            }
            int val = tttGrid[playerRow, playerCol];

            Console.WriteLine("Box taken? {0}", val);
            // if(tttGrid[playerRow-1, playerCol-1] != 0) {
            //     Console.WriteLine("Somebody already went there! Go again.");
            //     continue;
            // }

            currPlayer = (currPlayer == 1) ? 2 : 1;
            turn--;
        }
//*/
    }



    private bool checkWin(int[,] grid, int player) {
        int top = 0;
        int left = 0;
        int right = 0;
        int bot = 0;
        int midH = 0;
        int midV = 0;
        int diagL = 0;
        int diagR = 0;
        for(int i = 0; i < grid.Length; i++) {
            if(grid[0, i] == player) top++;
            if(grid[1, i] == player) midH++;
            if(grid[2, i] == player) bot++;
            if(grid[i, 0] == player) left++;
            if(grid[i, 1] == player) midV++;
            if(grid[i, 2] == player) right++;
            if(grid[i, i] == player) diagL++;
            if(grid[i, 2-i] == player) diagR++;
        }

        return (top == 3 || left == 3 || right == 3 || bot == 3 || midH == 3 || midV == 3 || diagL == 3 || diagR == 3);
    }
}