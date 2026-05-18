
		int[] a = {1,2,3,4,7,9};
		int l = a.Length;
		for (int i =1;i<l;i++)
		{
			int  insert_index = i;
			int current_value = a[i];
			for (int j = i-1;j>=1;j--)
			{
				if (a[j] > current_value)
				{
					insert_index = j;
					a[insert_index] = current_value;
				}
				
			}
			
		}
		foreach(int n in a)
			{
				Console.WriteLine(n);
			}