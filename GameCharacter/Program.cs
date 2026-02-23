using System;

// README.md를 읽고 아래에 코드를 작성하세요.

class GameCharacter
{
    public string Name { get; set; }
    public int Level { get; set; }

    public int MaxHp { get; set; }

    public int CurrentHp { get; set; }

    public int AttackPower { get; set; }

    public string IsAllive { get; set; }

    public void Attack()
    {
        Console.WriteLine($"{CurrentHp - AttackPower}");
    }
}


