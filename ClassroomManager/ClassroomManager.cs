using System;

class ClassroomManager
{
    private const int k_MaxStudent = 5;

    private readonly string _className;

    private string[] _studentNames = new string[k_MaxStudent];
    private int _studentCount = 0;

    private static int _totalClassroomCount = 0;

    public ClassroomManager(string className)
    {
        _totalClassroomCount++;
        _className = className;
    }

    public void AddStudent(string name)
    {
        if (_studentCount >= 5)
        {
            Console.WriteLine("이미 학생 정원이 최대입니다.");
            return;
        }

        _studentNames[_studentCount++] = name;
    }

    public void ShowStudents()
    {
        Console.WriteLine($"=== {_className} 학생 목록 ({_studentCount}/{k_MaxStudent}) ===");
        for(int i = 0; i < _studentCount; i++)
        {
            Console.WriteLine($"{i + 1}. {_studentNames[i]}");
        }
    }

    public static void ShowTotalClassrooms()
    {
        Console.WriteLine($"전체 교실 수: {_totalClassroomCount}");
    }
}