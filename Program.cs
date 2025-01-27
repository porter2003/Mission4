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
bool validGuess = false;
string[] board = new string[9];
for (int i = 0; i < board.Length; i++)
{
 board[i] = "";
}
Mission4.Methods methods = new Mission4.Methods();


// • Ask each player in turn for their choice and update the game board array 
// Player X
while (!winner(board))
{   
    validGuess = false;
    while (validGuess == false)
    {
        // Console.Clear();
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







// Player O



// • Print the board by calling the method in the supporting class 
// • Check for a winner by calling the method in the supporting class, and notify the players when a win has occurred and which player won the game 
