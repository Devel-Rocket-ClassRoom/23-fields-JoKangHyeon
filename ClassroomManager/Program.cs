using System;

ClassroomManager classroom1Manager = new ClassroomManager("1반");
ClassroomManager classroom2Manager = new ClassroomManager("2반");

classroom1Manager.AddStudent("홍길동");
classroom1Manager.AddStudent("김철수");
classroom1Manager.AddStudent("이명희");

classroom2Manager.AddStudent("박민수");
classroom2Manager.AddStudent("정수진");


classroom1Manager.ShowStudents();
Console.WriteLine();
classroom2Manager.ShowStudents();
Console.WriteLine();
ClassroomManager.ShowTotalClassrooms();
