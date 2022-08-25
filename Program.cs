/*
// Задача 1. Напишите программу,которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)


Console.Write("input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int quad = num * num;

Console.Write("The square of " + num + " is " + quad);


// Задача 2. Напишите прог-му котораяна вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.Write("input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if (n1 == quad2)

{
  Console.WriteLine($"{n1} is quad of {n2}");  
}
else
{
  Console.WriteLine($"{n1} not quad of {n2}"); 
}
*/

// Задача 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input integer positive number: ");

int number = Convert.ToInt32(Console.ReadLine());

int current = number * (-1);

while(current <= number)

{
    Console.Write(current + " ");
    current++;
}
*/

// Задача 4. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает показывает последнюю цифру этого числа.
/*
Console.Write("Input integer three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int ed = number % 10;

Console.WriteLine($"Last digit of {number} is {ed}"); 
*/