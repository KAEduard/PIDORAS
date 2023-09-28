using System.Drawing;

namespace PIDORAS
{
    public class Stats
    {
        public int Armor { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Points { get; set; }

        public int Point;

        public void AddAttackPoints()
        {
            
        }
            
        public void SetHealth(int point) //TODO Переименовать
        {
            Console.WriteLine($"Вы внесли {point} в здоровье");
        }

        public Stats(int armor, int hp, int attack, int points)
        {
            Hp = hp;
            Armor = armor;
            Attack = attack;
            Points = points;
        }
    }
}