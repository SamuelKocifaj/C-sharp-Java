using System;
using System.Diagnostics;

int[] array = new int[100090];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next();
}
//Bubblesort
/*static void Bubblesort(int[] array, int length)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}
var watch = new System.Diagnostics.Stopwatch();
watch.Start();
Bubblesort(array,array.Length);
watch.Stop();
Console.WriteLine($"Dĺžka triedenia: {watch.ElapsedMilliseconds}sekund");*/
//Insertion sort
/*Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

for (int i = 1; i < array.Length; i++)
{
    int key = array[i];
    int j = i - 1;

    while (j >= 0 && array[j] > key)
    {
        array[j + 1] = array[j];
        j = j - 1;
    }

    array[j + 1] = key;
}

stopwatch.Stop();

Console.WriteLine("Pole uložené pomocou Insertion sort metódy: " + stopwatch.ElapsedMilliseconds + " milliseconds.");*/
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

for (int i = 0; i < array.Length - 1; i++)
{
    int minIndex = i;

    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[minIndex])
        {
            minIndex = j;
        }
    }

    int temp = array[minIndex];
    array[minIndex] = array[i];
    array[i] = temp;
}

stopwatch.Stop();

Console.WriteLine("Pole uložené pomocou Selection sort metódy: " + stopwatch.ElapsedMilliseconds + " milliseconds.");
        
