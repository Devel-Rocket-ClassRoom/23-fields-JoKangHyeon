using System;

class GameConfig
{
    public readonly string version = "1.0.0";
    public readonly int maxPlayer;

    public GameConfig(int maxPlayer)
    {
        this.maxPlayer = maxPlayer;
    }
   
    public void ShowConfig()
    {
        Console.WriteLine($"버전: {version}");
        Console.WriteLine($"최대 플레이어: {maxPlayer}");
    }
}
