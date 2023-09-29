using System.Drawing;
using PIDORAS;

Console.WriteLine("Как твоё имя?");
Player player=new Player(Console.ReadLine());
Stats stats = new Stats(0,0,0,10);

Console.WriteLine($"Добро пожаловать {player.Name}! Вам нужно распределить 10 очков по характеристикам.");
Console.WriteLine("У вас предоставлены следующие характеристики:");
Console.WriteLine("1. Здоровье");
Console.WriteLine("2. Защита");
Console.WriteLine("3. Атака");
Console.WriteLine();

Console.WriteLine($"Доступные очки: {stats.Point}");
Console.WriteLine("Выберите характеристику (1-3):");
stats.Characteristics();

Console.WriteLine("Распределение очков завершено.");
Console.WriteLine($"Здоровье: {stats.Hp}");
Console.WriteLine($"Атака: {stats.Attack}");
Console.WriteLine($"Защита: {stats.Armor}");
Console.WriteLine($"Колличество очков: {stats.Point}");


















// Console.WriteLine($"{player.Name} сейчас у тебя {player.Hp} здоровье, {player.Armor} защиты, {player.Attack} атаки");
// Console.WriteLine($"Тебе необходимо внести {player.Points} очков в эти параметры: здоровье, защита, атака");
//
//
// Console.WriteLine($"{player.Name} теперь у тебя: {player.Hp} здоровья, {player.Armor} защиты и {player.Attack} атаки");
