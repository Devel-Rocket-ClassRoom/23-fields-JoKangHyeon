using System;

class Person
{
    private string name = "홍길동";
    private const int Age = 21;
    private readonly string Nickname = "길동이";
    private string[] websites = { "네이버", "구글" };

    public void ShowProfile()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"나이: {Age}");
        Console.WriteLine($"닉네임: {Nickname}");
        Console.WriteLine($"사이트: {string.Join(", ",websites)}");
    }
}
