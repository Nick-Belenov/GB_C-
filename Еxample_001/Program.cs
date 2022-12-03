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
*/

int numberA = new Random().Next(1, 10); //1 2 3 4 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);