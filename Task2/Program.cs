// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3


Console.Write("Введите первое число ");
string snum1 = Console.ReadLine();
Console.Write("Введите второе число ");
string snum2 = Console.ReadLine();

int num1 = Convert.ToInt32(snum1);
int num2 = Convert.ToInt32(snum2);

if (num1>num2)
{
    Console.Write("Первое число больше, чем второе.");
    Console.Write($" max ={num1} ");
   
}
else
{
    Console.Write("Второе число больше, чем первое.");
    Console.Write($" max ={num2} ");
}
    



