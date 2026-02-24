using System;

class Schedule
{
    private string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

    public void PrintWeekDays()
    {
        Console.WriteLine(string.Join(' ', weekDays));
    }
}
