using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Игрок", 10, 3);
        Enemy enemy = new Enemy("Враг", 8, 2);

        Console.WriteLine("Всего персонажей создано: " + Character.HowMany());
        Console.WriteLine();

        Console.WriteLine("Бой начинается!");
        
        player.Attack(enemy);
        enemy.GetStatus();
        Console.WriteLine();

        enemy.Attack(player);
        player.GetStatus();
    }
}


class Character
{
    private string name;
    private int hp;
    private int power;

    private static int count = 0;

    public Character(string name, int hp, int power)
    {
        this.name = name;
        this.hp = hp;
        this.power = power;
        
        count++; 
    }

    public static int HowMany()
    {
        return count;
    }

    public static bool IsValidStats(int hp, int power)
    {
        if (hp > 0 && power > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Attack(Character target)
    {
        target.hp = target.hp - this.power;
        Console.WriteLine(this.name + " атакует " + target.name + " на " + this.power + " урона.");
    }
    public void GetStatus()
    {
        Console.WriteLine(this.name + ": " + this.hp + " HP");
    }
}


class Player : Character
{
    public Player(string name, int hp, int power) : base(name, hp, power)
    {
    }
}


class Enemy : Character
{
    public Enemy(string name, int hp, int power) : base(name, hp, power)
    {
    }
}
