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



Console.Write("Enter your name: ");
string username = Console.ReadLine();
Console.Write("Hello, ");
Console.Write(username);