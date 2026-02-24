using System;

class Player4
{
    private string name;
    private int level;

    public void SetInfo(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"레벨: {level}");
    }
}
