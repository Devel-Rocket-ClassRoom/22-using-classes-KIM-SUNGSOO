using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;


//ClassName.MemberName();


//string sqaure = Square.GetName();
//Console.WriteLine(sqaure);


//MyFirstClass.StaticMehtod();
//MyFirstClass my = new MyFirstClass();
//my.InstanceMethod();


//Person person1 = new Person();
//Person person2 = new Person();
//person1.Introduce("홍길동", 25);
//person2.Introduce("김철수", 30);


//Point point1 = new Point();
//point1.x = 10;
//point1.y = 20;

//Point point2 = point1;
//point2.x = 100;

//Console.WriteLine($"point1.X= {point1.x}");
//Console.WriteLine($"point2.X= {point2.x}");


//PointStruct points1 = new PointStruct();
//points1.x = 10;
//points1.y = 20;

//PointStruct points2 = points1;
//points2.x = 100;

//Console.WriteLine($"구조체: points1.X = {points1.x}, points2.X = {points2.x}");

//Pointclass pointc1 = new Pointclass();
//pointc1.x = 10;
//pointc1.y = 20;

//Pointclass pointc2 = pointc1;
//pointc2.x = 100;

//Console.WriteLine($"클래스: pointc1.X = {pointc1.x}, pointc2.X = {pointc2.x}");


//Calculator calc = new Calculator();
//Console.WriteLine($"3 + 5 = {calc.Add(3,5)}");
//Console.WriteLine($"3 * 5 = {calc.Multiply(3,5)}");


//Player player1 = new Player();
//player1.introInfo();

//Player player2 = new Player("용사",150);
//player2.introInfo();


//Stock stock = new Stock();
//stock.CurrentPrice = 30;
//Console.WriteLine($"주가: {stock.CurrentPrice}");


//Product product = new Product();
//product.Name = "노트북";
//product.Price = 1500000;
//Console.WriteLine($" {product.Name}: {product.Price}원 (수량: {product.Quantity}) ");


//Circle circle = new Circle();
//circle.Radius = 5;
//Console.WriteLine($"반지름: {circle.Radius}, 넓이: {circle.Area:F2}");


//Monster monster1 = new Monster();
//monster1.Name = "고블린";
//monster1.Health = 50;

//Monster monster2 = new Monster()
//{
//    Name = "오크",
//    Health = 100
//};

//monster1.Attack();
//monster2.Attack();


//Character character = new Character()
//{
//    Name = "용사",
//    Level = 10,
//    Job = "전사"
//};

//character.characterInfo();


//Random random = new Random();
//Console.WriteLine($"임의의 정수: {random.Next()}");
//Console.WriteLine($"0~4: {random.Next(5)}");
//Console.WriteLine($"1 ~ 9: {random.Next(1, 10)}");
//Console.WriteLine($"0.0 ~ 1.0: {random.NextDouble():F4}");


//Random random = new Random();

//Console.WriteLine("주사위를 5번 굴립니다:");
//for(int i = 0; i < 5; i++)
//{
//    int dice = random.Next(1,7);
//    Console.WriteLine($"{i+1}번째 : {dice}");
//}


Person2 alice = new Person2("Alice", 25);
Person2 bob = new Person2("Bob", 30);
alice.SetFriend(bob);



class ClassName
{
    public static void MemberName()
    {
        Console.WriteLine("클래스의 멤버가 호출되었습니다.");
    }
}

class Square
{
    public static string GetName()
    {
        return "정사각형";
    }
}

class MyFirstClass
{
    public static void StaticMehtod()
    {
        Console.WriteLine("[1] 정적 메서드");
    }

    public void InstanceMethod()
    {
        Console.WriteLine("[2] 인스턴스 메서드");
    }
}

class Person
{
    public string Name;
    public int Age;
    public void Introduce(string Name, int Age)
    {
        Console.WriteLine($"안녕하세요, {Name}입니다. {Age}살 입니다.");
    }
}

class Point
{
    public int x;
    public int y;
}

struct PointStruct
{
    public int x;
    public int y;
}

class Pointclass
{
    public int x;
    public int y;
}

class Calculator
{
    public int x;
    public int y;
    public int Add(int x , int y)
    {
        return x+y ;
    }

    public int Multiply(int x, int y) => x * y;
}

class Player
{
    public string name;
    public int health;

    public Player()
    {
        name = "Unknown";
        health = 100;
    }

    public Player(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    public void introInfo()
    {
        Console.WriteLine($"이름: {this.name}, 체력: {this.health}");
    }
}

class Stock
{
    private decimal _CurrentPrice;

    public decimal CurrentPrice
    {
        get { return _CurrentPrice; }
        set { _CurrentPrice = value; }
    }
}

class Product
{
    public string Name { get; set;  }
    public decimal Price { get; set; }
    public int Quantity { get; set; } = 1;
}

class Circle
{
    public double Radius { get; set; }

    public double Area => Math.PI * Radius * Radius;
}

class Monster
{
    public string Name;
    public int Health;

    public void Attack()
    {
        Console.WriteLine($"{Name}이(가) 공격합니다!");
    }
}

class Character
{
    public string Name { get; set; }
    public int Level { get; set; }
    public string Job { get; set; }
    
   public void characterInfo()
    {
        Console.WriteLine($"{Name} - Lv.{Level} {Job}");
    }
}

class Person2
{
    private string _name;
    private int _age;

    public Person2(string name, int age)
    {
        
        this._name = name;
        this._age = age;
    }

    public void SetFriend(Person2 friend)
    {
        
        friend.PrintFriendInfo(this);
    }

    public void PrintFriendInfo(Person2 person)
    {
        Console.WriteLine($"{_name}의 친구는 {person._name}입니다.");
    }
}