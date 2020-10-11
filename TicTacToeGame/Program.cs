using System;
using TicTacToeGame;

namespace tictactoeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game!");

            TicTacToe tictactoe = new TicTacToe();
            //Calls create board
            tictactoe.CreateBoard();

            string player = tictactoe.PlayerStartingFirst();
            while (true)
            {
                Console.WriteLine(player + " plays");
                char playerLetter = tictactoe.PlayerChoice();
                int location = tictactoe.MoveToLocation();
                tictactoe.MakeAMove(location, playerLetter);
                tictactoe.DisplayBoard();
                if (tictactoe.CheckWinner(playerLetter) == true)
                {
                    Console.WriteLine(player + " Has Won");
                    break;
                }
                if (tictactoe.CheckDraw())
                {
                    Console.WriteLine("It's a tie");
                    break;
                }
                player = tictactoe.PlayerChance(player);
            }

        }
    }
}
