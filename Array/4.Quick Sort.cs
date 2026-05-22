	static int Partition(int[] a, int low, int high)
{
    int pivot = a[high];
    int i = low - 1;

    for (int j = low; j < high; j++)
    {
        if (a[j] <= pivot)
        {
            i++;

            
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }

    
    int temp2 = a[i + 1];
    a[i + 1] = a[high];
    a[high] = temp2;

    return i + 1;
}
	static	void Quicksort(int[] a, int low, int high)
		{
			if(high<low)
			{
				int array_l = a.Length;
				high = array_l - 1;
			}
			if (high>low)
			{
				int pivotIndex = Partition(a, low, high);

            Quicksort(a, low, pivotIndex - 1);
            Quicksort(a, pivotIndex + 1, high);
				
			}
		}
		int[] myArray = { 64, 34, 25, 12, 22, 11, 90, 5 };

         Quicksort(myArray, 0, myArray.Length - 1);

        Console.WriteLine("Sorted array:");
        foreach (int num in myArray)
        {
            Console.Write(num + " ");
        }
		