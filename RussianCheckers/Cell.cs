using System;

namespace RussianCheckers
{
    public class Cell
    {
        private object cell;

        enum Letters
        {
            A,
            B,
            C,
            D,
            E,
            F,
            G,
            H
        }

        private int x, y, new_x;
        private object letter;

        public Cell(int i, int j)
        {
            x = i;
            y = j;
            letter = (Letters) j;
            new_x = Math.Abs(x - 8);
        }

        public override string ToString()
        {
            if (x < 3)
            {
                if (x == 0)
                {
                    if (y % 2 != 0)
                    {
                        return $"Cell {new_x},{letter} has black piece";
                    }
                }

                if (x == 1)
                {
                    if (y % 2 == 0)
                    {
                        return $"Cell {new_x},{letter} has black piece";
                    }
                }

                if (x == 2)
                {
                    if (y % 2 != 0)
                    {
                        return $"Cell {new_x},{letter} has black piece";
                    }
                }
            }

            if (x > 4)
            {
                if (x == 5)
                {
                    if (y % 2 == 0)
                    {
                        return $"Cell {new_x},{letter} has white piece";
                    }
                }

                if (x == 6)
                {
                    if (y % 2 != 0)
                    {
                        return $"Cell {new_x},{letter} has white piece";
                    }
                }

                if (x == 7)
                {
                    if (y % 2 == 0)
                    {
                        return $"Cell {new_x},{letter} has white piece";
                    }
                }
            }

            return $"Cell {new_x},{letter} is empty";
        }

    }

}