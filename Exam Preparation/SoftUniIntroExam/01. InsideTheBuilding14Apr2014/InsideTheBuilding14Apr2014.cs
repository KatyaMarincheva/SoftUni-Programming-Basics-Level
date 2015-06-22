using System;

class InsideTheBuilding14Apr2014
{
    static void Main()
    {
        // input
        int h = int.Parse(Console.ReadLine());

        int[,] matrix = new int[5, 2];

        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 2; col++)
            {
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        // printing the x, y values of the matrix
        //for (int row = 0; row < 5; row++)
        //{
        //    for (int col = 0; col < 2; col++)
        //    {
        //        Console.Write("{0,4} ", matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}
        for (int row = 0; row < 5; row++)
        {
            bool inside = IsInsideRectangle(h, matrix[row, 0], matrix[row, 1]);

            if (!inside)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("inside");
            }
        }
    }

    private static bool IsInsideRectangle(int h, int x, int y)
    {
        int r1Left = 0;
        int r1Bottom = 0;
        int r1Width = 3 * h;
        int r1Height = h;

        int r2Left = h;
        int r2Bottom = h;
        int r2Width = h;
        int r2Height = 3 * h;
        bool insideRectangle1 = (x >= r1Left) && (x <= (r1Left + r1Width)) && (y >= r1Bottom) && (y <= (r1Bottom + r1Height));
        bool insideRectangle2 = (x >= r2Left) && (x <= (r2Left + r2Width)) && (y >= r2Bottom) && (y <= (r2Bottom + r2Height));
        bool inside = insideRectangle1 | insideRectangle2;
        return inside;
    }
}

