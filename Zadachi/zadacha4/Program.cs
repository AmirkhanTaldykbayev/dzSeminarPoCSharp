//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdValue = Convert.ToInt32(Console.ReadLine());

if (firstValue > secondValue & firstValue > thirdValue)
{
	Console.WriteLine("Число " + firstValue + " является наибольшим числом");
}
else if (secondValue > firstValue & secondValue > thirdValue)
{
	Console.WriteLine("Число " + secondValue + " является наибольшим числом");
}
else
{
	Console.WriteLine("Число " + thirdValue + " является наибольшим числом");
}