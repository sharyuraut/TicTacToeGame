using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game!");

            TicTacToe tictactoe = new TicTacToe();
            //Calls create board
            tictactoe.CreateBoard();

            char playerLetter = tictactoe.PlayerChoice();
            //Calls MaveToLocation Method
            tictactoe.MoveToLocation(playerLetter);
            //Class DisplayBoard method
            tictactoe.DisplayBoard();

        }
    }
}
