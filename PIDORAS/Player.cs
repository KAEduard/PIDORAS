namespace PIDORAS
{
    public class Player
    {
        public string Name { get; set; }

        public Stats Characteristics { get; set; }

        public Player(string name)
        {
            Name = name;
            Characteristics = new Stats(1, 1, 1, 1);

        }
    }
}