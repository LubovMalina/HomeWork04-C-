// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Clear();
Console.WriteLine("Введите число, которое задаcт количество элементов массива: ");
int element = int.Parse(Console.ReadLine());

int [] massarray = GetRandom(element, -10, 10);

int [] GetRandom(int element, int minValue, int maxValue){
    int[] result = new int[element];
    for (int i = 0; i < element; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}
Console.WriteLine($"[{String.Join(",", massarray)}]");