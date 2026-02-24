using System;

ScoreTracker scoreTracker = new ScoreTracker("수학");
scoreTracker.ShowScore();

Console.WriteLine();
scoreTracker.SetScore(85);
scoreTracker.AddBonus(10);
scoreTracker.AddBonus(20);
scoreTracker.SetScore(120);

Console.WriteLine();
scoreTracker.ShowScore();
