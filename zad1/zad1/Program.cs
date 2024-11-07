using System;
using System.Collections.Generic;

class Program
{
     static void Main()
    {
        char[] gameBoard = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char currPlayer = 'X';
        int countMove = 0;
        bool gameWon = false;

        while (countMove < 9 || gameWon)
        {
            Console.Clear();
         showBoard(gameBoard);
         Console.WriteLine("Igrac "+currPlayer+" neka bira polje(1-9)");
         int choice;
         bool validChoice = int.TryParse(Console.ReadLine(),out choice);
         int newChoice;
         while (true)
         {
             if (!validChoice || choice<1 || choice>9)
             {
                 Console.WriteLine("Krivi unos, pokusajte ponovo:");
                 Console.ReadKey();
                 Console.Clear();
                 showBoard(gameBoard);
                 Console.WriteLine("Igrac "+currPlayer+" neka bira polje(1-9)");
                 validChoice=int.TryParse(Console.ReadLine(),out choice);
                 continue;
             }
             else
             {
                 break;
             }
         }

         while (true)
         {
             if (gameBoard[choice - 1] == 'X' || gameBoard[choice - 1] == 'O')
             {
                 Console.WriteLine("U to polje je vec unesen znak");
                 Console.ReadKey();
                 Console.Clear();
                 showBoard(gameBoard);
                 Console.WriteLine("Igrac "+currPlayer+" neka bira polje(1-9)");
                 newChoice = int.Parse(Console.ReadLine());
                 choice = newChoice;
                 continue;
             }
             else
             {
                 break;
             } 
         }

         gameBoard[choice - 1] = currPlayer;
         countMove++;
         gameWon = checkIfGameWon(currPlayer,gameBoard);

         if (gameWon)
         {
             Console.Clear();
             showBoard(gameBoard);
             Console.WriteLine("Igrač "+currPlayer+ " je pobijedio!");
             break;
         }

         if (currPlayer == 'X')
         {
             currPlayer = 'O';
         }
         else
         {
             currPlayer = 'X';
         }
        }
        
        if (!gameWon || countMove == 9)
        {
            Console.Clear();
            showBoard(gameBoard);
            Console.WriteLine("Neriješeno!");
        }
        
    }

    static void showBoard(char[] gameBoard)
    {
        Console.WriteLine(gameBoard[0]+ "   |   " + gameBoard[1]+ "   |   "+ gameBoard[2]);
        Console.WriteLine(gameBoard[3]+ "   |   " + gameBoard[4]+ "   |   "+ gameBoard[5]);
        Console.WriteLine(gameBoard[6]+ "   |   " + gameBoard[7]+ "   |   "+ gameBoard[8]);
    }

   static  bool checkIfGameWon(char currPlayer, char[] gameBoard)
    {
        int[,] winningCombinations = new int[,]
        {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, 
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, 
            { 0, 4, 8 }, { 2, 4, 6 }              
        };
        for (int i = 0; i < winningCombinations.GetLength(0); i++)
        {
            if (gameBoard[winningCombinations[i, 0]] == currPlayer &&
                gameBoard[winningCombinations[i, 1]] == currPlayer &&
                gameBoard[winningCombinations[i, 2]] == currPlayer)
            {
                return true;
            }
        }
        return false;
    }
}
