using System.Reflection.PortableExecutable;
using A_character_with_a_point_spread;

Console.WriteLine("Как твоё имя?");

Player player=new Player(Console.ReadLine(), 100, 100, 100,10);
Console.WriteLine($"{player.Name} сейчас у тебя {player.Hp} здоровье, {player.Armor} защиты, {player.Attack} атаки");
Console.WriteLine($"Тебе не обходимо внести {player.Points} очков в эти параметры: здоровье, защита, атака");


Сharacteristics characteristics = new Сharacteristics();
characteristics.Health(player);
characteristics.Deff(player);
characteristics.Attack(player);


Console.WriteLine($"{player.Name} теперь у тебя: {player.Hp} здоровья, {player.Armor} защиты и {player.Attack} атаки");