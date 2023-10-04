int boardSize = int.Parse(Console.ReadLine());
char[,] board = CreateMatrix(boardSize);
int removedKnights = 0;

while (true)
{
    int attackCounter = 0;
    int maxAttacks = 0;
    int bestKnightRow = 0;
    int bestKnightCol = 0;

    for (int row = 0; row < boardSize; row++)
    {
        for (int col = 0; col < boardSize; col++)
        {
            if (board[row, col] == 'K')
            {
                if (IsInRange(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K') attackCounter++;
                if (IsInRange(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K') attackCounter++;

                if (IsInRange(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K') attackCounter++;
                if (IsInRange(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K') attackCounter++;

                if (IsInRange(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K') attackCounter++;
                if (IsInRange(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K') attackCounter++;

                if (IsInRange(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K') attackCounter++;
                if (IsInRange(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K') attackCounter++;

                if (attackCounter > maxAttacks)
                {
                    maxAttacks = attackCounter;
                    bestKnightRow = row;
                    bestKnightCol = col;
                }
                attackCounter = 0;
            }
        }
    }
    if (maxAttacks == 0)
    {
        break;
    }
    else
    {
        board[bestKnightRow, bestKnightCol] = '0';
        removedKnights++;
    }
}
Console.WriteLine(removedKnights);


static char[,] CreateMatrix(int boardSize)
{
    char[,] matrix = new char[boardSize, boardSize];
    for (int row = 0; row < boardSize; row++)
    {
        char[] data = Console.ReadLine().ToCharArray();
        for (int col = 0; col < boardSize; col++)
        {
            matrix[row, col] = data[col];
        }
    }
    return matrix;
}

static bool IsInRange(char[,] board, int row, int col)
{
    return
        row >= 0 &&
        row < board.GetLength(0) &&
        col >= 0 &&
        col < board.GetLength(1);
}