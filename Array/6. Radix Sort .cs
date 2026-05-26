  int[] array = { 23, 99, 67, 894, 69 };

        int maxVal = array.Max();
        int exp = 1;

        List<int> output = new List<int>();

        while (maxVal / exp > 0)
        {
            
            List<int>[] radixArray = new List<int>[10];

            for (int i = 0; i < 10; i++)
            {
                radixArray[i] = new List<int>();
            }

            
            for (int i = 0; i < array.Length; i++)
            {
                int val = array[i];
                int radixIndex = (val / exp) % 10;
                radixArray[radixIndex].Add(val);
            }

            
            output.Clear();

            foreach (List<int> bucket in radixArray)
            {
                foreach (int val in bucket)
                {
                    output.Add(val);
                }
            }

            array = output.ToArray();

            exp *= 10;
        }

        Console.WriteLine("Sorted array: " + string.Join(", ", array));