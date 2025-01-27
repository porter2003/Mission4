using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class Methods
    {
        public void printBoard(char[] board)
        {
            board = ['x', 'x', 'o', 'o', 'x', 'o', 'x', 'x', 'o'];
            for (int i = 0; i < board.Length; i++)
            {
                if (i%3 == 0)
                {
                    Console.WriteLine("\n");
                }
                Console.Write(i);
            }
        }
        public bool winner(Array board)
        {
            return false;
        }
    }
}
