//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
string snum = Console.ReadLine();
bool not = true;
int num = Convert.ToInt32(snum);
int index = 1;

Console.WriteLine("Чётные числа от 1 до " + num);
 while (index <= num)
            {
                if (index % 2 == 0)
                {
                    Console.Write(index + ", ");
                    not = false;
                }
                index++;
            }

            if  (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }
        