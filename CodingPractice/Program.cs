using System;
using System.Data;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine();
Console.WriteLine("## 과제 1: 필드가 있는 클래스 만들기");

Player p = new Player();
p.ShowStatus();

Console.WriteLine();
Console.WriteLine("## 과제 2: public 필드");

Character c = new Character();
c.name = "용사";
c.level = 10;

Console.WriteLine(c.name);
Console.WriteLine(c.level);



Console.WriteLine();
Console.WriteLine("## 과제 3: private 필드");

Character2 c2 = new Character2();
c2.SetInfo("용사", 10);
c2.ShowInfo();



Console.WriteLine();
Console.WriteLine("## 과제 4: 선언과 동시에 초기화");

Player2 p2 = new Player2();
p2.ShowStatus();



Console.WriteLine();
Console.WriteLine("## 과제 5: 필드 이니셜라이저");

Say say = new Say();
say.Hi();



Console.WriteLine();
Console.WriteLine("## 과제 6: 배열 필드 초기화");

Schedule schedule = new Schedule();
schedule.PrintWeekDays();



Console.WriteLine();
Console.WriteLine("## 과제 7: 기본값 확인");

DefaultValues defaultValues = new DefaultValues();
defaultValues.PrintDefault();



Console.WriteLine();
Console.WriteLine("## 과제 8: 정적 필드 선언과 사용");

Counter co1 = new Counter();
Console.WriteLine($"현재 카운트: {Counter.count}");
Counter co2 = new Counter();
Console.WriteLine($"현재 카운트: {Counter.count}");
Counter co3 = new Counter();
Console.WriteLine($"현재 카운트: {Counter.count}");



Console.WriteLine();
Console.WriteLine("## 과제 9: 인스턴스 필드 vs 정적 필드");

Player3 p31 = new Player3("용사");
Player3 p32 = new Player3("마법사");
Player3 p33 = new Player3("궁수");

Console.WriteLine(p31.name);
Console.WriteLine(p32.name);
Console.WriteLine(p33.name);
Console.WriteLine($"총 플레이어 수: {Player3.totalCount}");



Console.WriteLine();
Console.WriteLine("## 과제 10: readonly 필드");

GameConfig gameConfig = new GameConfig(4);
gameConfig.ShowConfig();



Console.WriteLine();
Console.WriteLine("## 과제 11: readonly vs const 비교");

Example example = new Example();
example.ShowValue();



Console.WriteLine();
Console.WriteLine("## 과제 12: this 키워드");

Player4 p4 = new Player4();
p4.SetInfo("용사", 10);
p4.ShowInfo();



Console.WriteLine();
Console.WriteLine("## 과제 13: 다양한 필드 타입 활용");

Person person = new Person();
person.ShowProfile();



Console.WriteLine();
Console.WriteLine("## 과제 14: 게임 캐릭터 클래스");

GameCharacter hero = new GameCharacter("용사", 15);
GameCharacter mage = new GameCharacter("마법사", 25);

hero.ShowStatus();
Console.WriteLine();
mage.ShowStatus();
Console.WriteLine();

hero.TakeDamage(30);
hero.TakeDamage(50);
hero.TakeDamage(50);

Console.WriteLine();
GameCharacter.ShowTotalCharacters();
