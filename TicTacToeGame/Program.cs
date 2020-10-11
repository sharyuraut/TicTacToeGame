using System;
using TicTacToeGame;

namespace tictactoeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game!");
            int location = 0;
            TicTacToe tictactoe = new TicTacToe();
            //Calls create board
            tictactoe.CreateBoard();

            char playerLetter = tictactoe.PlayerChoice();
            char computerLetter = tictactoe.getComputerLetter(playerLetter);
            string player = tictactoe.PlayerStartingFirst();
            while (true)
            {
                Console.WriteLine(player + " plays");
                if (player == "USER")
                {
                    location = tictactoe.MoveToLocation();
                    tictactoe.MakeAMove(location, playerLetter);
                }
                if (player == "COMPUTER")
                {
                    location = tictactoe.GetComputerMove(computerLetter);
                    tictactoe.MakeAMove(location, computerLetter);
                }
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
