// Bubble Sort
int [] a = {5,6,8,2,5,1};
		int l = a.Length;
		for (int i = 0;i<l-1;i++)
		{
			for ( int j = 0; j<(l-i-1);j++)
			{
				if (a[j] > a[j+1])
				{
					
                    int temp = a[j];
                    a[j] = a[j + 1];
                   a[j + 1] = temp;
		
				}
			}
		}
		
		foreach(int s in a)
		{
			Console.WriteLine(s);
		}	
		