 static List<int> CountingSort(List<int> arr)
    {
        if (arr == null || arr.Count == 0)
            return arr;

        int max_value = arr[0];

        foreach (int num in arr)
        {
            if (num > max_value)
                max_value = num;
        }

        int[] count = new int[max_value + 1];

        foreach (int num in arr)
        {
            count[num]++;
        }

        arr.Clear();

        for (int i = 0; i < count.Length; i++)
        {
            for (int j = 0; j < count[i]; j++)
            {
                arr.Add(i);
            }
        }

        return arr;
    }

    public static void Main()
    {
        List<int> unsortedArr = new List<int> { 4, 2, 2, 6, 3, 3, 1, 6, 5, 2, 3 };

        List<int> sortedArr = CountingSort(unsortedArr);

        Console.WriteLine("Sorted array: " + string.Join(", ", sortedArr));
    }
}