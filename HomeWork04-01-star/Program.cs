// Напишите программу, которая задаёт массив из 10 элементов, 
// которые необходимо заполнить случайными значениями в диапазоне от -10 до 10 и найти максимальное значение среди них.
// [-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
// [-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6
// [-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

Console.WriteLine("Введите минамальный элемент массива: ");
int min = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальный массива: ");
int max = int.Parse(Console.ReadLine());

int [] massiv = newRandomMassiv(size,min,max);
int [] newRandomMassiv(int size, int min, int max){
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}
Console.WriteLine($"[{String.Join(",", massiv)}]");


int Maxnumber = massiv[0];

for (int i = 1; i < size; i++)
{ 
    if (massiv[i]>Maxnumber)
    {
        Maxnumber = massiv[i];
    }
}
           
Console.Write("Максимальный элемент в массиве ->");
Console.WriteLine(Maxnumber);
