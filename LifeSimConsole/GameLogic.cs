using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimConsole
{
    internal class GameLogic
    {
        private bool[,] gameField;
        private bool hasLife;
        private readonly int rows;
        private readonly int columns;
        private int neighbourCellsCount;
        public uint currentGeneration { get; private set; }
        private const int populationSizeMax = 20;

        public GameLogic(int rows, int columns, int populationSize)
        {
            this.rows = rows;
            this.columns = columns;
            gameField = new bool[columns, rows];
            Random randCellFill = new Random();
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    gameField[x, y] = randCellFill.Next((populationSizeMax - (populationSize - 1)) + 1) == 0;

                }
            }
        }
        public void NextGeneration()
        {
            var newField = new bool[columns, rows];
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    neighbourCellsCount = NeighbourCellsCount(x, y);
                    hasLife = gameField[x, y];

                    if (!hasLife && neighbourCellsCount == 3)
                    {
                        newField[x, y] = true;
                    }

                    else if (hasLife && neighbourCellsCount < 2 || neighbourCellsCount > 3)
                    {
                        newField[x, y] = false;
                    }

                    else
                    {
                        newField[x, y] = gameField[x, y];
                    }
                }
            }
            currentGeneration++;
            gameField = newField;
        }

        public bool[,] GetGameField()
        {
            var currGameField = new bool[columns, rows];
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    currGameField[x, y] = gameField[x, y];
                }
            }
            return currGameField;
        }

        private int NeighbourCellsCount(int x, int y)
        {
            int count = 0;
            int column;
            int row;
            bool selfChecking;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    column = (x + i + columns) % columns;
                    row = (y + j + rows) % rows;

                    selfChecking = column == x && row == y;
                    hasLife = gameField[column, row];

                    if (hasLife && !selfChecking)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private bool ValidateCellPosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < columns && y < rows;
        }
        private void UpdateCell(int x, int y, bool state)
        {
            if (ValidateCellPosition(x, y))
            {
                gameField[x, y] = state;
            }
        }
        public void AddCell(int x, int y)
        {
            UpdateCell(x, y, state: true);
        }
        public void RemoveCell(int x, int y)
        {
            UpdateCell(x, y, state: false);
        }
    }
}
