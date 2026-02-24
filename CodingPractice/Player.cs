using System;

class Player
{
    private string name;
    private int health;

    public void ShowStatus()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"체력: {health}");  
    }
}