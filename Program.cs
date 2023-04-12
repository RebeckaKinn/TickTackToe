namespace TickTackToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Numbers();
            var board = new Board();
            var player = new Player();
            numbers.CreateBoard(board, numbers.NumberInBoard, numbers, player);
        }
    }
}