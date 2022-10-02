/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/
Console.Clear();

Console.WriteLine("Введите число A:");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B:");
int numberB = int.Parse(Console.ReadLine());

int step = 1;

for (int i = 0; i < numberB; i++)
{
    step = step * numberA;
}

Console.WriteLine($"Введенное число {numberA} возведенное в натуральную степень {numberB} равно -> {step}");

