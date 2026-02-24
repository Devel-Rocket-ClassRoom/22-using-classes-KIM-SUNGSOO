using System;

// README.md를 읽고 아래에 코드를 작성하세요.

GameCharacter hero = new GameCharacter("용사", 5);
GameCharacter monster = new GameCharacter("고블린", 3);

class GameCharacter
{
    private string _Name;
    private int _Level;
       
    public string Name { get; set; }
    public int Level { get; set; }

    public int MaxHp { get; set; }

    public int CurrentHp { get; set; }

    public int AttackPower { get; set; }

    public string IsAllive { get; set; }

    public void Attack()
    {
        Console.WriteLine($"{Name}이(가) {Name}에게 {AttackPower} 데미지를 입혔습니다!");
    }
    public GameCharacter(string Name, int Level)
    {
        _Name = Name;
        _Level = Level;
    }
}


