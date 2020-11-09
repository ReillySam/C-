using System.IO;
using System;

class Program 
{
    private static string[] boardArr = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
    
    private static void drawBoard()
    {
        Console.Clear();
        Console.WriteLine("      |       |       ");
        Console.WriteLine("   {0}   |    {1}   |     {2}  ", boardArr[1], boardArr[2], boardArr[3]);
        Console.WriteLine("----------------------");
        Console.WriteLine("      |       |       ");
        Console.WriteLine("   {0}   |    {1}   |     {2}  ", boardArr[4], boardArr[5], boardArr[6]);
        Console.WriteLine("----------------------");
        Console.WriteLine("      |       |       ");
        Console.WriteLine("   {0}   |    {1}   |     {2}  ", boardArr[7], boardArr[8], boardArr[9]);

    }
    
    private static string[] setPlayers()
    {
        Console.WriteLine("Welcome to Tic Tac Toe !!");
        Console.WriteLine("Enter player names >>> Player 1: ");
        var player_1 = Console.ReadLine();
        Console.WriteLine("Player 2: ");
        var player_2 = Console.ReadLine();
        Console.WriteLine("Great! {0} is X and {1} is O", player_1, player_2);
        Console.WriteLine("{0} goes first!", player_1);
        Console.Clear()
        return new[] {player_1, player_2};
        
    }
    
    private static void playGame(string [] players, int [] scores, string [] pieces)
    {
        bool gameWon = false;
        bool gameOver = false;
        int player_index = 0;
        
        while (gameWon == false)
        {
            var next_player = 1 - player_index;
            var player = players[player_index];
            var move = pieces[players_index];
            var opponent_move = pieces[next_player];
            
            makeMove() // player move method
            
            gameWon = checkWinner(); // check for win method
            gameOver = gameWon || checkDraw(); //check for draw
            
            if (gameOver == false)
            {
                player_index = next_player;
            }
        }
        
        Console.Clear();
        drawBoard();
        resetBoard();
        
        if (gameWon == true)
        {
            incrementScores(scores, player_index);
            Console.WriteLine("{0} wins!!", player_index);
        }
        else
        {
            Console.WriteLine("This game is a draw!!")
        }
        
        reportScores()
        
    }
    
    private static void reportScores()
    
}
