namespace TickTackToe
{
    public class Player
    {
        public string Name { get; set; }
        public Boolean IsPlaying { get; set; }

        public void ChangePlayer()
        {
            IsPlaying = !IsPlaying;
        }
        public void ChangePlayerName()
        {
            if (IsPlaying) Name = "X";
            else Name = "O";
        }

        public string GetName()
        {
            return Name;
        }

        public Player()
        {
            Name = "O";
            IsPlaying = false;
        }
    }
}
