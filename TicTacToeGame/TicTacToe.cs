using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToe
    {
        //Create Board method
        public void CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 1; i <= 9; i++)
            {
                board[i] = ' ';
            }
        }
        //Method to let player choose X or O
        public char PlayerChoice()
        {
            char choice;
            Console.WriteLine("Enter X or O");
            choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'X' || choice == 'O' || choice == 'x' || choice == 'o')
            {
                return choice;
            }
            else
                Console.WriteLine("Enter a valid choice.");

            PlayerChoice();
            return ' ';
        }
    }
}
