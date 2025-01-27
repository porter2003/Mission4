// See https://aka.ms/new-console-template for more information
using Mission4;

using System;
using System.Collections.Generic;
//  • Welcome the user to the game
Console.WriteLine("Welcome to Tic Tac Toe! Terms and conditions apply. By playing, you agree to pay $10 to the developers");
// Changes
//  • Create a game board array to store the players’ choices 
string coordinates = "";
string guess = "";
char player = 'X';
bool playGame = true;

bool validGuess = false;
char[] board = new char[9];
do
{
    for (int i = 0; i < board.Length; i++)
    {
        board[i] = ' ';
    }

    Mission4.Methods methods = new Mission4.Methods();

// Stuff
// • Ask each player in turn for their choice and update the game board array 
// Player X
    while (methods.winner(board) == "none")
    {
        validGuess = false;
        while (validGuess == false)
        {
            // Console.Clear();

            // Print the board by calling the method in the supporting class 
            methods.printBoard(board);
            Console.WriteLine("Enter coordinates: ");
            coordinates = Console.ReadLine().ToUpper();
            if (methods.checkGuess(coordinates, board))
            {
                validGuess = true;

                board[methods.getIndex(coordinates)] = player;

                if (player == 'X')
                {
                    player = 'O';
                }
                else
                {
                    player = 'X';
                }

            }

        }
    }
    methods.printBoard(board);


// Check for a winner by calling the method in the supporting class, and notify the players when a win has occurred and which player won the game 
    if (methods.winner(board) == "draw")
    {
        Console.WriteLine("It's a draw!");
    }
    else
    {
        Console.WriteLine($"{methods.winner(board)} has won!");
    }

    Console.WriteLine("Would you like to continue playing? (y/n)");
    if (Console.ReadLine().ToLower() == "n")
    {
        playGame = false;
    }

} while (playGame);
Console.WriteLine("Thank you for playing! Goodbye! Tips are collected at the door");

