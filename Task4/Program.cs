// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Габиль, приветствую! Введите первое число ");
string snum1 = Console.ReadLine();
Console.Write("Затем, ведите второе число ");
string snum2 = Console.ReadLine();
Console.Write("И введите третье число ");
string snum3 = Console.ReadLine();



int num1 = Convert.ToInt32(snum1);
int num2 = Convert.ToInt32(snum2);
int num3 = Convert.ToInt32(snum3);

if (num1>num2)
{
    if (num1>num3)
    {Console.Write("Первое число больше, остальных.");
    Console.Write($" max ={num1} ");}
    
   
   else
   {
    Console.Write("Третье число больше, остальных.");
    Console.Write($" max ={num3} ");
   }
}
else
{   if (num2>num3)

    {Console.Write("Второе число больше, остальных.");
    Console.Write($" max ={num2} ");}

    else 

    {Console.Write("Третье число больше, остальных.");
    Console.Write($" max ={num3} ");}
}
    
