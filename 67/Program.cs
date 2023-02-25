// Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine($"{m}->{SumNumbers(m)}");

int SumNumbers(int number)
{
    if (number == 0)
        return 0;
    return (number % 10 + SumNumbers(number / 10));
}