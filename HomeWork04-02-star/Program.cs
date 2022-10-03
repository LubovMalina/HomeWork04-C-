/* Напишите программу, которая задаёт 2 одномерных массива из N элементов 
которые заполняются случайными значениями в диапазоне от 1 до 10 и 
находит среднее арифметическое элементов этих 2 массивов, 
далее от большего из получившихся средних арифметических отнимаем меньшее и округлённый до целого числа 
результат переводим в двоичную систему счисления.
[1,2,3,4] [3,6,4] -> округлённая до целого числа разница между средними арифметическими массивов = 2. 2 в двоичной системе счисления = 10
[4,7,9] [3,3,1,2,2] -> округлённая до целого числа разница между средними арифметическими массивов = 4. 4 в двоичной системе счисления = 100
*/

Console.Clear();
Console.WriteLine("Введите размер первого массива: ");
int size1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите размер второго массива: ");
int size2 = int.Parse(Console.ReadLine());

int [] massiv = newRandomMassiv1(size1,1,10);
int [] newRandomMassiv1(int size1, int min, int max){
    int[] result = new int[size1];
    for (int i = 0; i < size1; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}

int [] massiv_2 = newRandomMassiv2(size2,1,10);
int [] newRandomMassiv2(int size2, int min, int max){
    int[] result = new int[size2];
    for (int i = 0; i < size2; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}
Console.WriteLine($"[{String.Join(",", massiv)}]");
Console.WriteLine($"[{String.Join(",", massiv_2)}]");


int summ1 = 0;
for (int i = 0; i < size1; i++)
{ 
    summ1 +=massiv[i];
}
Console.WriteLine($"Среднее арифметическое значение элементов первого массива {summ1}");


int summ2 = 0;
for (int i = 0; i < size2; i++)
{ 
    summ2 +=massiv_2[i];
}
Console.WriteLine($"Среднее арифметическое значение элементов первого массива {summ2}");

/*Нахождение среднеарифметического значения двух массивов

//int srednee =0;

//if (summ1>summ2)
{
    srednee=(summ1-summ2)/(size + size);
}
else
{
    srednee=(summ1-summ2)/(size + size);  
}
Console.WriteLine($"Среднее арифметическое значение двух массивов {srednee}");

Console.WriteLine(srednee);
*/