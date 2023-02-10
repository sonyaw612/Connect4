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

        // prompt player1 for placement

        for(int i = 0; i < tttGrid.Length; i++) {
            foreach(int box in tttGrid[i]) {
                // Console.Write(" {0} ", tttGrid[i][j]);
                // Console.Write("|");


            }
            Console.WriteLine("-----------");
        }

        









    }
}