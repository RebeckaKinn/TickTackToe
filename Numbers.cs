namespace TickTackToe
{
    public class Numbers
    {
        public List<string> NumberInBoard { get; set; }

        public Numbers()
        {
            NumberInBoard = new List<string>
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9",
            };
        }

        public void CreateBoard(Board board, List<string> NumberInBoard, Numbers numbers, Player player)
        {
            board.ChangeTurn(player);
            Console.Clear();
            Console.WriteLine($"| {NumberInBoard[0]} | {NumberInBoard[1]} | {NumberInBoard[2]} |");
            Console.WriteLine($"-------------");
            Console.WriteLine($"| {NumberInBoard[3]} | {NumberInBoard[4]} | {NumberInBoard[5]} |");
            Console.WriteLine($"-------------");
            Console.WriteLine($"| {NumberInBoard[6]} | {NumberInBoard[7]} | {NumberInBoard[8]} |");
            board.Play(board, NumberInBoard, numbers, player);

        }
        public void ChangeAnswer(string number, Player player)
        {
            int index = Convert.ToInt32(number) - 1;
            NumberInBoard[index] = player.GetName();
        }


    }
}
