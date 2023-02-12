﻿using System;
using System.Linq;
using System.Text;

public class Connect4 {
    public static void Main(string[] args) {

        int[,] tttGrid = new int[7, 7];
        int[] colProgress = new int[tttGrid.GetLength(0)];
        Array.Fill(colProgress, tttGrid.GetLength(0)-1);

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
            Console.WriteLine(playerCol);
        //*/

        // IF PLAYER DID NOT INPUT A VALUE OR A VALID COLUMN, PROMPT PLAYER TO TRY AGAIN
            if(playerCol > tttGrid.GetLength(0)-1 || playerCol < 0 || !playerInput){
                Console.WriteLine("Invalid Column. Please input a number 1 through 3\n");
                continue;
            }
        // IF COLUMN IS FULL PROMPT PLAYER TO TRY AGAIN
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
        for(int i = 0; i < grid.GetLength(0); i++) {
            for(int k = 0; k < grid.GetLength(0); k++) {
                Console.Write("     ");
                if(k != grid.GetLength(0) - 1) Console.Write("|");
            }
            Console.WriteLine();
            for(int j = 0; j < grid.GetLength(0); j++) {
                int val = grid[i, j];
                switch (val)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  -  ");
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("  O  ");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("  O  ");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;                        
                    default: 
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                if(j != grid.GetLength(0) - 1) Console.Write("|");
            }
            Console.WriteLine();
            for(int k = 0; k < grid.GetLength(0); k++) {
                Console.Write("     ");
                if(k != grid.GetLength(0) - 1) Console.Write("|");
            }
            Console.WriteLine();
            if(i != grid.GetLength(0) - 1){
                for(int k = 0; k < grid.GetLength(0)+1; k++) {
                    Console.Write("-----");
                }
            }
            Console.WriteLine();
        }
    }

    private static bool checkWin(int[,] grid, int player, int numToWin) {

        int[] winV = new int[grid.GetLength(0)]; // keeps track of vertical win
        for(int i = grid.GetLength(0)-1; i >= 0 ; i--) {
            int winH = 0; // keeps track of horizontal win
            for(int j = 0; j < grid.GetLength(0); j++) {
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