//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

int[] array = new int [9];
for(int i=0;i<array.Length;i++)
{
    array[i] = new Random().Next(1,99);
} 

System.Console.WriteLine(string.Join(",",array));

int getnumber(int[]array)
{
    int result = 0;
    for(int i=1;i<array.Length;i=i+2)
    {
        result = result + array[i];
    }



    return result;
}

int result = getnumber(array);
System.Console.WriteLine(result);