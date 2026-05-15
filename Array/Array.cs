# Intilizted Array
int[] a = { 1, 2, 3 };
# Display Array
for (int i = 0;i < a.length;i++)
{
    Console.WriteLine(a[i]);
}

// find minimum value
			
		int[] s = {2,3,4,5,8};
		int min = s[0];
		for (int i = 0;i<s.Length;i++)
		{
			 if ( s[i] < min)
			 {
				 min = i;
		
			}
			}
		
		Console.WriteLine(min);