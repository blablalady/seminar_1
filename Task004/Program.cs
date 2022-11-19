/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine ("Enter first number: ");
int num1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Enter second number: ");
int num2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Enter trird number: ");
int num3 = Convert.ToInt32 (Console.ReadLine ());
if (num1 > num2 && num1 > num3)
{
    Console.WriteLine ("Max number " + num1);
}
if (num2 > num1 && num2 > num3)
{
    Console.WriteLine ("Max number " + num2);
}
if (num3 > num1 && num3 > num2)
{
    Console.WriteLine ("Max number " + num3);
}
