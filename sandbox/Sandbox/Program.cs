// Tic Tac Toe Program

/*
Nouns
=====
- X and O ?
- board

Verbs
=====
- display
- place a symbol
- who won
- is game finished

*/


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic Tac Toe\n");

        // data          0    1    2       3    4    5       6    7    8
        char[] board = {'X', 'O', ' ',    'O', ' ', 'X',    'O', 'X', 'O'};

        Display(board);

    }

    static void MakeMove(char[] board, int x, int y, char symbol)
    {
        // x and y -> 1D
        int index = 0;
    }

    static void Display(char[] board)
    {
        Console.WriteLine("Board:");
        for (int i = 0; i < 9; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine();
            }
            Console.Write($"{board[i]} ");
        }
    }
}