//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int [] array = new int [4];
for(int i=0;i<array.Length;i++)
{
    array[i] = new Random().Next(100,1000);
}
System.Console.WriteLine(string.Join(",", array));

int getnumber(int[]array)
{
    int result = 0;
    
    for(int i=0;i<array.Length;i++)
    {
        if(array[i] % 2 == 0)
        {
            result = result + 1;
        }
    }


    return result;
}

int result = getnumber(array);

System.Console.WriteLine(result);

// Я в шоке но я сделал за минуту