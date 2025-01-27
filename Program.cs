// See https://aka.ms/new-console-template for more information

/*

 */


using static Mission4.Methods;

//  • Welcome the user to the game
Console.WriteLine("Welcome to Tic Tac Toe! Terms and conditions apply. By playing, you agree to pay $10 to the developers");
// Changes
//  • Create a game board array to store the players’ choices 
string coordinates = "";
string guess = "";
string player = "";
bool playGame = true;

bool validGuess = false;
string[] board = new string[9];
do
{
    for (int i = 0; i < board.Length; i++)
    {
        board[i] = "";
    }

    Mission4.Methods methods = new Mission4.Methods();


// • Ask each player in turn for their choice and update the game board array 
// Player X
    while (winner(board) == "none")
    {
        validGuess = false;
        while (validGuess == false)
        {
            // Console.Clear();

            // Print the board by calling the method in the supporting class 
            methods.printBoard(board);
            Console.WriteLine("Enter coordinates: ");
            coordinates = Console.ReadLine();
            if (checkGuess(coordinates))
            {
                validGuess = true;

                board[getIndex(coordinates)] = player;

                if (player == "X")
                {
                    player = "O";
                }
                else
                {
                    player = "X";
                }

            }

        }
    }


// Check for a winner by calling the method in the supporting class, and notify the players when a win has occurred and which player won the game 
    if (winner(board) == "draw")
    {
        Console.WriteLine("It's a draw!");
    }
    else
    {
        Console.WriteLine($"{winner(board)} has won!");
    }

    Console.WriteLine("Would you like to continue playing? (y/n)");
    if (Console.ReadLine() == "n")
    {
        playGame = false;
    }

} while (playGame);
Console.WriteLine("Thank you for playing! Goodbye! Tips are collected at the door");

