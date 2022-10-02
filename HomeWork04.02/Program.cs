// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

int sum = 0;

while (number > 0)
{
    int last_number = number%10;
    sum += last_number; 
    number=number/10;

}

Console.WriteLine($"Сумма чисел введенного числа равна  - > {sum}");