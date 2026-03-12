using System;
using static System.Console;


// README.md를 읽고 코드를 작성하세요.



// 1 

// 익명 타입 생성 방식 var 이름 = new {요소들}
var s = new { Name = "김철수", Grade = 3, Score = 95.5d };

WriteLine($"이름: {s.Name}\n학년: {s.Grade}\n점수: {s.Score}");

WriteLine();

// 2-1

string name = "yunghee";
int age = 28;

var n = new { Name = name, Age = age };

WriteLine($"person1: {n.Name}, {n.Age}");

WriteLine();

// 2-2

var nn = n;
WriteLine($"person2: {nn.Name}, {nn.Age}");

WriteLine();

// 3

string text = "Hello";
var t = new { text, text.Length };
WriteLine($"텍스트: {t.text}\n길이: {t.Length}");

WriteLine();

// 4

// 변수명 그대로 추론하는 방식
int productId = 100;
string productName = "마우스";
double price = 25000.0d;

// 다양한 추론 방식 통합


var v = new
{
    // Name과 FormattedPrice에서 명시적 이름 지정, 나머지 변수명 그대로 추론
    productId,
    Name = productName,
    price,
    FormattedPrice = price.ToString("N0")
};

WriteLine($"ID: {v.productId}\n상품명: {v.Name}\n가격: {v.price}\n포맷된 가격: {v.FormattedPrice}");

WriteLine();

// 5

var p = new { x = 30, y = 40 };
var p1 = new { x = 30, y = 25 };

WriteLine($"같은 타입: {p.GetType().Equals(p1.GetType())}");
p1 = p;
WriteLine($"point1: ({p1.x}, {p1.y})");

WriteLine();

// 6
var one = new { x = 1, y = 2 };
var two = new { x = 1, y = 2 };
var three = new { x = 3, y = 4 };

WriteLine($"a.Equals(b): {one.Equals(two)}");
WriteLine($"b.Equals(c): {two.Equals(three)}");

WriteLine();

// 7

var A = new { a = 1, b = 1 };
var B = new { a = 1, b = 1 };

WriteLine($"a == b: {A == B}");
var C = A;
WriteLine($"a == c: {A == C}");

WriteLine();

// 8
var students = new[]
{
    new { name = "김철수", score = 85 },
    new { name = "이영희", score = 92 },
    new { name = "박민수", score = 78 }
};

WriteLine("=== 학생 점수 목록 ===");
foreach (var z in students)
{
    WriteLine($"{z.name}: {z.score}점");
}

WriteLine();

// 9
var ts = new[]
{
    new {Id = 1, Name = "키보드", Price = 50000},
    new {Id = 2, Name = "방망이", Price = 25000},
    new {Id = 3, Name = "휴지", Price = 300000}
};

WriteLine($"첫 번째 상품: {ts[1].Name}");
WriteLine($"상품 개수: {ts.Length}");

int sumPrice = 0;
foreach (var T in ts)
{
    sumPrice += T.Price;
}
WriteLine($"총 가격: {sumPrice:N0}원");

WriteLine();

// 10
var obj = new { Id = 1, Name = "Object1" };
WriteLine($"{obj.Id} - {obj.Name}");

obj = new { Id = 2, Name = "Object2" };
WriteLine($"{obj.Id} - {obj.Name}");

WriteLine();

// 11
var N = new { Name = "홍길동", Age = 30 };
var Hong = ("홍길동", 30);

WriteLine($"익명 타입: {N.Name}, {N.Age}");
WriteLine($"튜플: {Hong.Item1}, {Hong.Item2}");

WriteLine();

// 12
var K = new { name = "김영희", age = 25, city = "서울" };
WriteLine(K.ToString());

WriteLine();

// 13
var employees = new[]
{
    new {name = "김철수", team = "개발팀", salary = 5000},
    new {name = "이영희", team = "기획팀", salary = 4500},
    new {name = "박민수", team = "개발팀", salary = 5500}
};
