// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue < secondValue)
{
	Console.Write("Наибольшим числом является " + secondValue);
}
else
{
	Console.Write("Наибольшим числом является " + firstValue);
}