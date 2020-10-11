using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToe
    {
        char[] board = new char[10];
        public static int HEADS = 1;
        public static int TAILS = 0;
        //Create Board method
        public void CreateBoard()
        {
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

        public void DisplayBoard()
        {
            int i;
            for (i = 1; i <= 9; i++)
            {
                if (i == 4 || i == 7)
                {
                    Console.WriteLine("|" + "\n" + "........");
                }
                Console.Write("|" + board[i]);
            }
            Console.WriteLine("|");
        }

        public void MoveToLocation(char letter)
        {
            Console.WriteLine("Enter Location index from 1 to 9");
            int location = Convert.ToInt32(Console.ReadLine());
            if (location < 1 || location > 9)
            {
                Console.WriteLine("Not valid index");
                MoveToLocation(letter);
            }
            else if (board[location] == ' ')
            {
                board[location] = letter;
            }
            else
            {
                Console.WriteLine("Location already filled");
                MoveToLocation(letter);
            }
        }

        public string PlayerChance()
        {
            Random random = new Random();
            int toss = random.Next(0, 2);
            if (toss == HEADS)
            {
                return "USER";
            }
            return "COMPUTER";
        }
    }
}
