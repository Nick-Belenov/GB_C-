// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*dotnet new console – создать новый проект
dotnet run – запустить проект
Через Console мы обращаемся к системному
терминалу.
Синтаксис: начало
Write(); Вывод в одну строку
WriteLine(); В конце перейти на новую строку
ReadLine(); Считать строку из терминала

Случайности
new Random().Next(min, max)
даст случайное целое число от min до max-1
[min, max-1] или [min, max)

Синтаксис: начало
if( УСЛОВИЕ )
{
 Набор действий 1
}
else
{
 Набор действий 2
}
*/


/*
Console.Write("Enter your name: ");
string username = Console.ReadLine();
Console.Write("Hello, ");
Console.Write(username);
*/

//Программа для сложения двух чисел (На языке C#)
/*
Написать программу на языке C#,
для Windows и Mac OS,
[в которую пользователь вводит два целых числа]
[в которой записаны два целых числа]
[два целых числа генерируются случайным образом]
и получает сумму:
Синтаксис: начало
● Начало
● Определить первое число
● Определить второе число
● Вывести сумму введенных чисел на экран
● Конец

int numberA = 3;
int numberB = 5;
int result = numberA + numberB;
//Console.WriteLine(numberA + numberB);
Console.WriteLine(result); 

/* Вещественный(Дробный) тип данных double
 Написать программу на языке C#,
для Windows и Mac OS,
[в которую пользователь вводит два целых/вещественных числа]
[в которой записаны два целых/вещественных числа]
[два целых/вещественных числа генерируются случайным образом]
и получает результат от деления, целый или вещественный:
● Начало
● Определить первое число
● Определить второе число
● Вывести деление введенных чисел на экран
● Конец
int это 32 разрядное число со знаком(-/+)
double это 64 разрядное число со знаком(-/+)
string от 4 байт до 2 гб
bool (true/false) 1 байт

//int numberA = 10;
double numberA = 12;
//int numberB = 5;
double numberB = 5;
//int result = numberA / numberB;
double result = numberA / numberB;
Console.WriteLine(result);

// Нзначение целочисленной переменной рандомное значение

int numberA = new Random().Next(1, 10); //1 2 3 4 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);


Console.Write("Enter your name: ");
string username = Console.ReadLine();

//if (username == "Даша")
if (username.ToLower() == "даша")  // Опускает значение в нижний регистр
{
    Console.WriteLine("Ура, Это же Даша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}


int a = 8;
int b = 7;
int c = 1;
int d = 4;
int e = 5;

int max = a;
if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);


Console.Clear();
//Console.SetCursorPosition(10, 4);  //Комманда назначения позиции курсора с отступами
//Console.WriteLine("*");

int xa = 20,ya = 1,
    xb = 1,yb = 15,
    xc = 40,yc = 15;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("*");

int x = xa, y = xb;
int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3);  // 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
        if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
        if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

Console.SetCursorPosition(x, y);
Console.WriteLine("*");
count = count + 1;   // Если всегда увиличивать на 1, то будет достаточно "count++"
}
*/
