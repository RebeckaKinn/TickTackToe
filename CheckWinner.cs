namespace TickTackToe
{
    public class CheckWinner
    {
        public void CheckStats(List<string> NumberInBoard, Player player, Board board, Numbers getNumbers)
        {
            var input = player.GetName();
            if (NumberInBoard[0] == input && NumberInBoard[1] == input && NumberInBoard[2] == input) Winner(input);
            else if (NumberInBoard[3] == input && NumberInBoard[4] == input && NumberInBoard[5] == input) Winner(input);
            else if (NumberInBoard[6] == input && NumberInBoard[7] == input && NumberInBoard[8] == input) Winner(input);
            else if (NumberInBoard[0] == input && NumberInBoard[3] == input && NumberInBoard[6] == input) Winner(input);
            else if (NumberInBoard[1] == input && NumberInBoard[4] == input && NumberInBoard[7] == input) Winner(input);
            else if (NumberInBoard[2] == input && NumberInBoard[5] == input && NumberInBoard[8] == input) Winner(input);
            else if (NumberInBoard[0] == input && NumberInBoard[4] == input && NumberInBoard[8] == input) Winner(input);
            else if (NumberInBoard[2] == input && NumberInBoard[4] == input && NumberInBoard[6] == input) Winner(input);
            else if (BoadIsFull(NumberInBoard)) FullBoard();
            else getNumbers.CreateBoard(board, NumberInBoard, getNumbers, player);
        }

        public void Winner(string winningPlayer)
        {
            Console.WriteLine($"Spiller {winningPlayer} vant!", Console.ForegroundColor = ConsoleColor.Green);
        }

        public void FullBoard()
        {
            Console.WriteLine("Brettet er fullt. Spillet er slutt.");
        }

        public bool BoadIsFull(List<string> NumberInBoard)
        {
            int fasit = 0;
            foreach (string number in NumberInBoard)
            {
                fasit++;
                if (number == Convert.ToString(fasit))
                {
                    break;
                }
                return true;
            }
            return false;
        }
    }
}
