// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

Console.Clear();
Console.WriteLine("Введите длину массива : ");
int arraySize = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("[ ");
int numbers = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < arraySize; i++)
    {
        Console.WriteLine("Введите элемент массива: ");
        int numbers = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(numbers + " ");
    }
//Console.Write(numbers + " ");
Console.Write("]");


/* int[] numbers = new int[arraySize];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Ваш массив: ");
PrintArray(numbers);

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,99);
    }
}

*/
