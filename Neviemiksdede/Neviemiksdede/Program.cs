
int[] array = new int[50000];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next();
}
static int LinearSearch(int[] arr, int key)
{
    int n = arr.Length;
    for (int i = 0; i < n; i++)
    {
        if (arr[i] == key)
            return i;
    }
    return -1;
}

var watch = new System.Diagnostics.Stopwatch();
watch.Start();
for(int i =0;i<15000;i++)
{
    LinearSearch(array, i);
}
watch.Stop();
Console.WriteLine($"Dĺžka Hľadania: {watch.ElapsedMilliseconds}milisekund");
static int BinarySearch(int[] arr, int key)
{
    int left = 0;
    int right = arr.Length - 1;

    while (left <= right)
    {
        int mid = (left + right) / 2;

        if (arr[mid] == key)
            return mid;

        if (arr[mid] < key)
            left = mid + 1;
        else
            right = mid - 1;
    }
    return -1;
}
var watch = new System.Diagnostics.Stopwatch();
watch.Start();
for (int i = 0; i < 15000; i++)
{
    BinarySearch(array, i);
}
watch.Stop();
Console.WriteLine($"Dĺžka Hľadania: {watch.ElapsedMilliseconds}milisekund"); 




