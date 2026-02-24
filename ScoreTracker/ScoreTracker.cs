using System;

class ScoreTracker
{
    private const int k_MaxScore = 100;
    private const int k_MinScore = 0;

    private readonly string _ClassName;

    private int _score=0;

    private static int bonusCount=0;

    public ScoreTracker(string className)
    {
        _ClassName = className; 
    }

    public void SetScore(int score)
    {
        if(score > k_MaxScore || score < k_MinScore)
        {
            Console.WriteLine($"점수는 {k_MinScore}~{k_MaxScore} 사이여야 합니다.");
            return;
        }

        _score = score;
        Console.WriteLine($"점수를 {_score}점으로 설정했습니다.");
    }

    public void AddBonus(int bonus)
    {
        bonusCount++;
        _score += bonus;
        if (_score > k_MaxScore)
        {
            _score = k_MaxScore;
        }

        Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수: {_score}점 {(_score == k_MaxScore ? "(최대 점수 도달)" : "")}");
    }

    public void ShowScore()
    {
        Console.WriteLine($"=== {_ClassName} ===");
        Console.WriteLine($"점수: {_score} / {k_MaxScore}");
        Console.WriteLine($"보너스 적용 횟수: {bonusCount}");
    }
}