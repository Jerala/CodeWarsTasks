using System;

namespace CodeWarsTasks.PathFinderInLabyrinth
{
    public class LabyrinthPathFinder
    {
        const int WALL = 2;
        const int VISITED = 1;

        public static bool PathFinder(string maze)
        {
            maze = maze.Replace(" ", string.Empty);
            int[,] matrix = CreateMatrix(maze);
            next(matrix, 0, 0);
            return matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1] == VISITED;
        }

        private static void next(int[,] matrix, int y, int x)
        {
            matrix[y, x] = VISITED;
            if (y > 0 && matrix[y - 1, x] != VISITED && matrix[y - 1, x] != WALL) // north
                next(matrix, y - 1, x);
            if (x > 0 && matrix[y, x - 1] != VISITED && matrix[y, x - 1] != WALL) // west
                next(matrix, y, x - 1);
            if (y < matrix.GetLength(0) - 1
                && matrix[y + 1, x] != VISITED
                && matrix[y + 1, x] != WALL) // south
                next(matrix, y + 1, x);
            if (x < matrix.GetLength(1) - 1
                && matrix[y, x + 1] != VISITED
                && matrix[y, x + 1] != WALL) // east
                next(matrix, y, x + 1);
        }

        private static int[,] CreateMatrix(string maze)
        {
            string[] str = maze.Split(new char[] { '\n' });
            int[,] matrix = new int[str.Length, str[0].Length];
            for (int row = 0; row < str[0].Length; row++)
            {
                for (int col = 0; col < str.Length; col++)
                {
                    if (str[col][row] == '.') matrix[col, row] = 0;
                    else matrix[col, row] = WALL;
                }
            }
            return matrix;
        }
    }
}
