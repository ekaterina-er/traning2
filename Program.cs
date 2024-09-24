// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
// калькулятор простых арифметических операций
//объявление переменных
string str;
double a, b, c;
char oper;
//вывод и ввод данных в консоль
Console.WriteLine("Выполнить ввод первого числа");
str = Console.ReadLine();
a = Convert.ToDouble(str);
Console.WriteLine("Выполнить ввод второго числа");
str = Console.ReadLine();
b = Convert.ToDouble(str);
Console.WriteLine("Выполнить ввод знака арифметического оператора");
str = Console.ReadLine();
oper = Convert.ToChar(str);
//выполнение арифметического действия
if (oper == '+')
{
    c = Convert.ToDouble(a + b);
    Console.WriteLine(c);
}
else if (oper == '-')
{
    c = Convert.ToDouble(a - b);
    Console.WriteLine(c);
}
else if (oper == '*')
{
    c = Convert.ToDouble(a * b);
    Console.WriteLine(c);
}
else if (oper == '/')
{
    c = Convert.ToDouble(a / b);
    Console.WriteLine(c);
}
Console.ReadKey();