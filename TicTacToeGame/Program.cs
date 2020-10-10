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
            //Calls PlayerChoice method

            char playerLetter = tictactoe.PlayerChoice();
            char computerLetter = tictactoe.PlayerChoice();
        }
    }
}
