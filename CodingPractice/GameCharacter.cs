using System;

class GameCharacter
{
    private string _name;
    private int _health;
    private int _attack;

    private static int characterCount = 0;

    private readonly int maxHealth = 100;

    private const int k_MinHealth = 0;


    public GameCharacter(string name, int attack)
    {
        _name = name;
        _attack = attack;
        _health = maxHealth;
        characterCount++;
    }

    public void TakeDamage(int damageAmount)
    {
        _health -= damageAmount;
        if (_health < k_MinHealth)
        {
            _health = k_MinHealth;
        }
        Console.WriteLine(_name + "이(가) " + damageAmount + " 데미지를 받음! 남은 체력: " + _health);
    }

    public void ShowStatus()
    {
        Console.WriteLine($"=== {_name} ===");
        Console.WriteLine($"체력: {_health} / {maxHealth}");
        Console.WriteLine($"공격력: {_attack}");
    }

    public static void ShowTotalCharacters()
    {
        Console.WriteLine("총 캐릭터 수: " + characterCount);
    }
}
