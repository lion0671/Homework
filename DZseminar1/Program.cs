// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// Console.WriteLine("input fist namber");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second namber");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if(num2 > num1)
// {
//     Console.WriteLine($"max {num2}");
// }
// else
// {
//     Console.WriteLine($"max {num1}");
//}

// Задача 2: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// Console.WriteLine("input fist namber");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second namber");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input third namber");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if(num2 > max) max = num2;
// if(num3 > max) max = num3;
// Console.WriteLine(max);
//
// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("input namber");
// int n = Convert.ToInt32(Console.ReadLine());
// if(n % 2 == 0)
// {
//   Console.WriteLine($"да");  
// }
// else
// {
// Console.WriteLine($"нет");
// }
// Задача 4: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("input N");
int n = Convert.ToInt32(Console.ReadLine());
int current = n - (n-1);
while (current <= n)
  if (current % 2 == 0)
  {
    Console.Write(current + " ");
    current++;
  }
