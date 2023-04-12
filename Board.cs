namespace TickTackToe
{
    public class Board
    {
        public void Play(Board board, List<string> NumberInBoard, Numbers getNumbers, Player player)
        {
            var input = Console.ReadLine();

            if (NumberInBoard.Contains(Convert.ToString(input)))
            {
                getNumbers.ChangeAnswer(input, player);
                var checkWinner = new CheckWinner();
                checkWinner.CheckStats(NumberInBoard, player, board, getNumbers);
            }
            else
            {
                Console.WriteLine("Vennligst skriv inn akseptabel input for faen");
                Play(board, NumberInBoard, getNumbers, player);
            }
        }
        public void ChangeTurn(Player player)
        {
            player.ChangePlayer();
            player.ChangePlayerName();
        }
    }
}
