using System.Drawing;

namespace PIDORAS
{
    public class Player
    {
        public string Name { get; set; }
        public int Point { get; set; }
        public Player(string name)
        {
            Name = name;
        }
    }
}