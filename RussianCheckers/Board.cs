using System;

namespace RussianCheckers
{
    public class Board
    {
        private Cell[,] board = new Cell[8, 8];

        public Board()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = new Cell(i, j);
                    if (board[i, j] != null)
                    {
                        string s = board[i, j].ToString();
                        Console.WriteLine($"{s}");
                    }
                }
            }
        }

        public void GetBoard()
        { 
            Console.WriteLine("Dementions of board are " + board.GetLength(0) + "," + board.GetLength(1));
        }

    }
}