using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    public class TicTacToeGame
    {
        public char[] BOARD = new char[10];
        public void CreateGameBoard()
        {
            for (int i = 1; i < BOARD.Length; i++)
            {
                BOARD[i] = ' ';

            }

        }

        internal void PlayerInput()
        {
            throw new NotImplementedException();
        }

        public void Playerinput()
        {
            char playerInput = Convert.ToChar(Console.ReadLine());
            char input = char.ToUpper(playerInput);
            if (input == 'X')
            {
                Console.WriteLine("Player Choose :X" + playerInput);
            }
            if (input == 'O')
            {
                Console.WriteLine("Player Choose :O" + playerInput);
            }
            else
                Console.WriteLine("Enter Correct Input");
        }
    }
}
    
