using System.Drawing;

namespace PIDORAS
{
    public class Stats
    {
        public int Armor { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Point { get; set; }

        public Stats(int armor, int hp, int attack, int point)
        {
            Hp = hp;
            Armor = armor;
            Attack = attack;
            Point = point;
        }

        public void Characteristics()
        {
            while (Point > 0)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int attribute))
            {
                if (attribute >= 1 && attribute <= 3)
                {
                    Console.WriteLine("Введите количество очков для распределения:");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out int points))
                    {
                        if (points <= Point)
                        {
                            switch (attribute)
                            {
                                case 1:
                                    Hp += points;
                                    break;
                                case 2:
                                    Attack += points;
                                    break;
                                case 3:
                                    Armor += points;
                                    break;
                            }

                            Point -= points;
                            Console.WriteLine($"Распределено {points} очков по характеристике {attribute}.");
                            Console.WriteLine("Для продолжение нажмите на цифру");
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно доступных очков.");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат ввода очков.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Неверный номер характеристики.");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Неверный формат ввода характеристики.");
                Console.WriteLine();
            }
        }
        }
    }
}