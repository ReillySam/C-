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
    
    private static bool playGame(string [] players, int [] scores, string [] pieces)
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
            
            playerMakesMove() // player move method
            
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
            Console.WriteLine("This game is a draw!!");
        }
        
        reportScores();
        
    }
    
    private static void reportScores(string [] players, int [] scores)
    {
        Console.WriteLine("{0} - {1} :: {2} - {3}", players[0], scores[0], players[1], scores[1]);
    }
    
    private static void resetBoard()
    {
        for (int i = 1; i <= 10; i++)
        {
            boardArr[i] = i.ToString();
        }
    }
    
    private static int userMoveInput()
    {
        
    }
    
    private static void playerMakesMove(string [] players, string player, string piece, string opp_piece)
    {
        do{
            Console.Clear();
            drawBoard();
            Console.WriteLine(" ");
        }
        while (!tryMakeMove(string player, string piece, string opp_piece))
        
    }
    
    private static bool tryMakeMove(string player, string player_piece, string opp_piece)
    {
        Console.WriteLine("{0}'s move - {1}", player, player_piece);
        var move = Console.WriteLine("Enter move (1-9): ");
        if (!availableMoves(int move, string player_piece, string opp_piece))
        {
            boardArr[move] = player_piece;
            return true;
        }
        
        Console.WriteLine("Position already taken! Try again: ");
        Console.ReadLine();
        Console.Clear();
        return false;
    }
    
    private static void availableMoves(int move, string player_piece, string opp_piece)
    {
        boardArr[move] == player_piece || boardArr[move] == opp_piece;
    }
    
    private static void incrementScores(int [] scores, int player_index)
    {
        score[player_index] = score[player_index] + 1;
    }
    
    private static void playAgain()
    {
        // check if checkWinner() || checkDraw() returns. Ask for user input to play again. Reset board and scores. 
    }
        
    private static bool checkWinner()
    {
        return isAnyLine(1, 4) || isAnyLine(3, 2) ||
               horizontal(1) || horizontal(4) || horizontal(7) ||
               vertical(1) || vertical(2) || vertical(3);
    }
    
    private static void checkDraw()
    {
        // check if checkWinner() returns true && if there are no moves left to play 
    }
    
    
    //helper methods for indexing board
    
    private static bool isLine(int index_0, int index_1, int index_2, string piece)
    {
        return (boardArr[index_0] == piece && boardArr[index_1] == piece && boardArr[index_2] == piece);
    }
    
    private static bool isAnyLine(int start, int step)
    {
        return IsLine(start, start+step, start+step+step, boardArr[start]);
    }
    
    private static bool horizontal(int start_index)
    {
        return isAnyLine(start_index, 1);
    }
    
    private static bool vertical(int start_index)
    {
        return isAnyLine(start_index, 3);
    }
    
}
