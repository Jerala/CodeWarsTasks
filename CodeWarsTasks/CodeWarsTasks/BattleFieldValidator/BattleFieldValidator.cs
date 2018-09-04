using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeWarsTasks.BattleFieldValidator
{
    public class BattleFieldValidator
    {
        static int currShip = 0;
        public static bool fieldValidator(int[,] field)
        {
            int amount = 0, four = 0, three = 0, two = 0, one = 0;
            for (int i = 0; i < field.GetLength(0); i++)
                for (int j = 0; j < field.GetLength(1); j++)
                    if (field[i,j] == 1)
                        amount++;
            if (amount != 20)
                return false;

            for (int i = 0; i < field.GetLength(0); i++)
                for (int j = 0; j < field.GetLength(1); j++)
                    if (field[i,j] == 1)
                    {
                        countShip(field, i, j);
                        if (currShip == 1) one++;
                        else if (currShip == 2) two++;
                        else if (currShip == 3) three++;
                        else if (currShip == 4) four++;
                        else return false;
                        currShip = 0;
                    }
            if (one == 4 && two == 3 && three == 2 && four == 1) return true;
            return false;
        }

        private static void countShip(int[,] field, int y, int x)
        {
            if (!checkDiagonals(field, y, x))
            {
                currShip = -999;
                return;
            }
            currShip++;
            field[y,x] = 2;
            if (topExist(y - 1) && field[y - 1,x] == 1) countShip(field, y - 1, x, "UP");
            else if (downExist(y + 1) && field[y + 1,x] == 1) countShip(field, y + 1, x, "DOWN");
            else if (leftExist(x - 1) && field[y,x - 1] == 1) countShip(field, y, x - 1, "LEFT");
            else if (rightExist(x + 1) && field[y,x + 1] == 1) countShip(field, y, x + 1, "RIGHT");
        }
        private static void countShip(int[,] field, int y, int x, String direction)
        {
            if (!checkDiagonals(field, y, x))
            {
                currShip = -999;
                return;
            }
            currShip++;
            field[y,x] = 2;
            switch (direction)
            {
                case "UP":
                    if (topExist(y - 1) && field[y - 1,x] == 1) countShip(field, y - 1, x, "UP");
                    break;
                case "DOWN":
                    if (downExist(y + 1) && field[y + 1,x] == 1) countShip(field, y + 1, x, "DOWN");
                    break;
                case "LEFT":
                    if (leftExist(x - 1) && field[y,x - 1] == 1) countShip(field, y, x - 1, "LEFT");
                    break;
                case "RIGHT":
                    if (rightExist(x + 1) && field[y,x + 1] == 1) countShip(field, y, x + 1, "RIGHT");
                    break;
            }
        }

        private static bool checkDiagonals(int[,] field, int y, int x)
        {
            if (topExist(y - 1) && leftExist(x - 1) && field[y - 1, x - 1] == 1) return false;
            if (topExist(y - 1) && rightExist(x + 1) && field[y - 1, x + 1] == 1) return false;
            if (downExist(y + 1) && leftExist(x - 1) && field[y + 1, x - 1] == 1) return false;
            if (downExist(y + 1) && rightExist(x + 1) && field[y + 1, x + 1] == 1) return false;
            return true;
        }

        private static bool topExist(int x)
        {
            return x > 0;
        }
        private static bool downExist(int x)
        {
            return x < 9;
        }
        private static bool leftExist(int x)
        {
            return x > 0;
        }
        private static bool rightExist(int x)
        {
            return x < 9;
        }
    }
}