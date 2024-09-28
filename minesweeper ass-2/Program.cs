using System;

namespace Minesweeper
{
    class Program
    {
        const int rows = 10;
        const int cols = 10;
        const int mines = 15;

        static char[,] board = new char[rows, cols];
        static bool[,] revealed = new bool[rows, cols];
        static bool gameOver = false;
        static int score = 0;

        static void Main(string[] args)
        {
            InitializeBoard();
            PlaceMines();
            CalculateNumbers();

            while (!gameOver)
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine($"Score: {score}");
                Console.Write("Enter row and column (e.g. 3 4): ");
                string input = Console.ReadLine();
                var parts = input.Split();

                if (parts.Length != 2 || !int.TryParse(parts[0], out int row) || !int.TryParse(parts[1], out int col))
                {
                    Console.WriteLine("Invalid input. Press any key to try again...");
                    Console.ReadKey();
                    continue;
                }

                if (row < 0 || row >= rows || col < 0 || col >= cols)
                {
                    Console.WriteLine("Out of bounds. Press any key to try again...");
                    Console.ReadKey();
                    continue;
                }

                RevealCell(row, col);

                if (CheckWin())
                {
                    Console.Clear();
                    PrintBoard();
                    Console.WriteLine($"You win! Final Score: {score}");
                    gameOver = true;
                }
            }

            Console.WriteLine("Game over. Press any key to exit...");
            Console.ReadKey();
        }

        static void InitializeBoard()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    board[r, c] = ' ';
                    revealed[r, c] = false;
                }
            }
        }

        static void PlaceMines()
        {
            Random rand = new Random();
            int placedMines = 0;

            while (placedMines < mines)
            {
                int r = rand.Next(rows);
                int c = rand.Next(cols);

                if (board[r, c] != '*')
                {
                    board[r, c] = '*';
                    placedMines++;
                }
            }
        }

        static void CalculateNumbers()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (board[r, c] == '*') continue;

                    int mineCount = 0;

                    for (int dr = -1; dr <= 1; dr++)
                    {
                        for (int dc = -1; dc <= 1; dc++)
                        {
                            int nr = r + dr;
                            int nc = c + dc;

                            if (nr >= 0 && nr < rows && nc >= 0 && nc < cols && board[nr, nc] == '*')
                            {
                                mineCount++;
                            }
                        }
                    }

                    if (mineCount > 0)
                    {
                        board[r, c] = (char)('0' + mineCount);
                    }
                }
            }
        }

        static void PrintBoard()
        {
            Console.Write("   ");
            for (int c = 0; c < cols; c++)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            for (int r = 0; r < rows; r++)
            {
                Console.Write(r + " |");
                for (int c = 0; c < cols; c++)
                {
                    if (revealed[r, c])
                    {
                        Console.Write(board[r, c] + " ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void RevealCell(int row, int col)
        {
            if (revealed[row, col]) return;

            revealed[row, col] = true;

            if (board[row, col] == '*')
            {
                gameOver = true;
                Console.Clear();
                PrintBoard();
                Console.WriteLine($"You hit a mine! Final Score: {score}");
                return;
            }

            score++;

            if (board[row, col] == ' ')
            {
                for (int dr = -1; dr <= 1; dr++)
                {
                    for (int dc = -1; dc <= 1; dc++)
                    {
                        int nr = row + dr;
                        int nc = col + dc;

                        if (nr >= 0 && nr < rows && nc >= 0 && nc < cols)
                        {
                            RevealCell(nr, nc);
                        }
                    }
                }
            }
        }

        static bool CheckWin()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (board[r, c] != '*' && !revealed[r, c])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}