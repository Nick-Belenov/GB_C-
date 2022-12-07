/*
string name = "Nick";
string departament = "QA";
string result = name + " " + departament;
Console.WriteLine(result);


int a = 5;
int b = 5;

if (a > b)
{
    Console.WriteLine("Да");
}
else if (a == b)
{
   Console.WriteLine("Равны"); 
}
else 
{
   Console.WriteLine("Нет"); 
}


int a = 5;
int b = 10;

while (a < b)
{
    Console.WriteLine("Да");
    a++;
}


Console.WriteLine("Напишите целочисленное число: ");
//int a = -5;
//int a = new Random().Next(1, 15);
int a = Convert.ToInt32(Console.ReadLine());
int result = a * a;
Console.WriteLine("Квадрат этого числа" + " : " + result);


// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberB * numberB;

if(numberA == result)
{
    Console.WriteLine("Первое число является квадратом второго.");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго.");
}


// Задача №3. Напишите программу,
//которая будет выдавать название дня недели по заданному номеру.

//Console.WriteLine("Введите номер дня недели: ");
//int number = Convert.ToInt32(Console.ReadLine());

int dayNumber = 0;

bool isCorrectInput = false;
while(!isCorrectInput)
{
    Console.Write("Введите число: ");
    string input = Console.ReadLine();
    dayNumber = Convert.ToInt32(input);
    if(dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Числ неверное, введите ещё раз: ");
    }
    else
    {
        isCorrectInput = true;
    }
}

if(dayNumber == 1)
{
    Console.WriteLine("Понедельник");
}
else if(dayNumber == 2)
{
    Console.WriteLine("Вторник");
}
else if(dayNumber == 3)
{
    Console.WriteLine("Среда");
}
else if(dayNumber == 4)
{
    Console.WriteLine("Четверг");
}
else if(dayNumber == 5)
{
    Console.WriteLine("Пятница");
}
else if(dayNumber == 6)
{
    Console.WriteLine("Суббота");
}
else if(dayNumber == 7)
{
    Console.WriteLine("Воскресенье");
}
//else if(number < 1)
//{
//    Console.WriteLine("Такого дня недели нет");
//}
//else if (number > 7)
//{
//    Console.WriteLine("Такого дня недели нет");
//}


// Задача №5. Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.



//Задача №7. Напишите программу, 
//которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberA = -number;

while (numberA <= number)
{
    Console.Write(numberA + " ");
    numberA++;
}
*/
