using System;

class Example
{
    const double Pi = 3.14159;
    readonly DateTime createAt = DateTime.Now;

    public void ShowValue()
    {
        Console.WriteLine($"원주율: {Pi}");
        Console.WriteLine($"생성 시간: {createAt}");
    }
}
