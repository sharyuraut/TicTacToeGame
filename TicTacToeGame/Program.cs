using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game!");

            TicTacToe tictactoe = new TicTacToe();
            //Call create board method
            tictactoe.CreateBoard();

            //call PlayerChoice method for both player and computer
            char playerLetter = tictactoe.PlayerChoice();
            char computerLetter = tictactoe.PlayerChoice();
        }
    }
}
