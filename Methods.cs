using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    public class Methods
    {
        public void printBoard(char[] board) 
        {
            for (int i = 0; i < board.Length; i++) // Print the board
            {
                if (i%3 == 0) // Print on different lines every three values
                {
                    Console.Write("\n");
                }
                Console.Write(board[i]);
            }
        }
        public bool checkGuess(string guess, char[] board)
        {
            String[] array;

            array = new string[] { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3" };

            int position = 0;

            position = getIndex(guess); // Get position of guess

            if (array.Contains(guess))
            {
                if (board[position] == ' ') // Ensure that position in board is open
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("That position is already taken.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("That was not a valid guess");
                return false;
            }
        }
        public int getIndex(string guess)
        {
            String[] array;

            array = new string[] { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3" };

            int index = Array.IndexOf(array, guess);

            return index;
        }
        public string winner(char[] board)
        {
            string result = "";

            // Winning combinations (indices of board)
            int[][] winningLines = new int[][]
            {
            new int[] { 0, 1, 2 }, // Top row
            new int[] { 3, 4, 5 }, // Middle row
            new int[] { 6, 7, 8 }, // Bottom row
            new int[] { 0, 3, 6 }, // Left column
            new int[] { 1, 4, 7 }, // Middle column
            new int[] { 2, 5, 8 }, // Right column
            new int[] { 0, 4, 8 }, // Diagonal top-left to bottom-right
            new int[] { 2, 4, 6 }  // Diagonal top-right to bottom-left
            };

            // Check for a winner
            foreach (var line in winningLines)
            {
                if (board[line[0]] != ' ' &&
                    board[line[0]] == board[line[1]] &&
                    board[line[1]] == board[line[2]])
                {
                    result = board[line[0]].ToString(); // Return 'x' or 'o'
                    return result;
                }
            }

            // Check for a draw (no empty spaces)
            if (!board.Contains(' '))
            {
                result = "Draw";
            }

            return result;
        }

    }
}
