using System;

class Player2
{
    private string name = "이름없음";
    private int health = 100;
    private int level = 1;

    public void ShowStatus()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"체력: {health}");
        Console.WriteLine($"레벨: {level}");
    }
}
