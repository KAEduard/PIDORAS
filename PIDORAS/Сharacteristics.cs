namespace A_character_with_a_point_spread;

public class Сharacteristics
{
 
    public void Health(ICharacteristics target)
    {
        Random random = new Random();
        var point = random.Next(5,5);
        target.Hp += point;
        Console.WriteLine($"Вы внесли {point} в здоровье");
  
    }
   public void Deff(ICharacteristics target)
    {
        Random random = new Random();
        var point = random.Next(2,2);
        target.Armor += point;
        Console.WriteLine($"Вы внесли {point} в защиту");
    }
    public void Attack(ICharacteristics target)
    {
        Random random = new Random();
        var point = random.Next(3,3);
        target.Attack += point;
        Console.WriteLine($"Вы внесли {point} в атаку");
    }
    


}