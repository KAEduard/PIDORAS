namespace A_character_with_a_point_spread;

public class Player : ICharacteristics
{
    public string Name { get; set; }
    public int Armor { get; set; }
    public int Hp { get; set; }
    public int Attack { get; set; }
    public int Points { get; set; }

    public Player(string name, int armor, int hp, int attack, int points)
    {
        Name = name;
        Armor = armor;
        Hp = hp;
        Attack = attack;
        Points = points;
    }
}