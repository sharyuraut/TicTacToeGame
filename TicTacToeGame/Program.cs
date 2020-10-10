using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game!");

            TicTacToe tictactoe = new TicTacToe();
            tictactoe.CreateBoard();
            char playerLetter = tictactoe.PlayerChoice();
            char compuerLetter = tictactoe.PlayerChoice();
        }
    }
}
