//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int [] array = new int [5];
for(int i=0;i<array.Length;i++)
{
    array[i] = new Random().Next(1,99);
}
System.Console.WriteLine(string.Join(",",array));

int getmaks(int[]array)
{
    int max = array[0];
    for(int i=0;i<array.Length;i++)
    {
        if(array[i]>max)
        {
            max = array[i];
        }
    }


    return max;
}

int getmin(int[]array)
{
    int min = array[0];
    for(int i=0;i<array.Length;i++)
    {
        if(array[i]<min)
        {
            min = array[i];
        }
    }
    return min;
}

int maks = getmaks(array);
int min = getmin(array);

int getresult(int maks,int min)
{
    int result = maks - min;
    return result;
}

int getresult1 = getresult(maks,min);

System.Console.WriteLine(getresult1);