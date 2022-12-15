//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число и мы узнаем является ли оно четным: ");
string snum = Console.ReadLine();

int num = Convert.ToInt32(snum);

if (num % 2 == 0)
{
    Console.Write("Число четное.");
    //Console.Write($" max ={num1} ");
   
}
else
{
    Console.Write("Число нечетное.");
    //Console.Write($" max ={num2} ");
}
    



