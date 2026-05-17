int[] a = { 5, 9, 4, 1, 6 };
int l = a.Length;

for (int i = 0; i < l - 1; i++)
{
    int min_index = i;

    for (int j = i + 1; j < l; j++)
    {
        if (a[j] < a[min_index])
        {
            min_index = j;
        }
    }

 
    int temp = a[i];
    a[i] = a[min_index];
    a[min_index] = temp;
}

foreach (int s in a)
{
    Console.WriteLine(s);
}