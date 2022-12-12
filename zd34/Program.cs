//34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
//Диапазон трехзначных чисел, ввод случайный.

Console.WriteLine("Введите длину массива");
int length=Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Random random = new Random();

for (int i=0; i<length; i++)
{
    array[i]=random.Next(100, 1000);
}
Console.WriteLine(string.Join(",",array));

Console.WriteLine(SumEven(array));
int SumEven (int[] array)
{  int sum=0;

    for (int i=0; i < length; i++)
    {
        
        if (array [i] % 2 == 0)
        {
           sum ++;
        }
    } 
        return sum;
}


