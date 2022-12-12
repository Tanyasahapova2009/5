//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//-4, -6, 89, 6] -> 0
//Диапазон любой, ввод зависит от пользователя. (размер, значения)

Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите массив");
int[] array = new int[n];

for (int i=0; i<n; i++)
{
     array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(SumOdd(array));
int SumOdd (int[] array)
{
    int sum=0;
    for (int i=0; i<n; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

