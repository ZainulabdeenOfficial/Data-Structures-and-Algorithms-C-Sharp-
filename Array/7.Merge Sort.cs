 public static void Main()
    {
        int[] arr = { 3, 7, 6, -10, 15, 23, 55, -13 };

        int[] sorted = MergeSort(arr);

        Console.WriteLine(string.Join(", ", sorted));
    }

    static int[] MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
            return arr;

        int mid = arr.Length / 2;

        int[] left = MergeSort(arr.Take(mid).ToArray());
        int[] right = MergeSort(arr.Skip(mid).ToArray());

        return Merge(left, right);
    }

    static int[] Merge(int[] left, int[] right)
    {
        List<int> result = new List<int>();

        int i = 0;
        int j = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] < right[j])
            {
                result.Add(left[i]);
                i++;
            }
            else
            {
                result.Add(right[j]);
                j++;
            }
        }

        while (i < left.Length)
        {
            result.Add(left[i]);
            i++;
        }

        while (j < right.Length)
        {
            result.Add(right[j]);
            j++;
        }

        return result.ToArray();