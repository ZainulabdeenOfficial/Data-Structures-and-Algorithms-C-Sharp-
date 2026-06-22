		static int  BinarySearch(int[] arr,int targetvalue)
		{
			int left = 0; 
			int right = arr.Length -1;
			
			while(left <=right)
			{
				int mid = (left+right)/2;
				
				if (arr[mid] == targetvalue)
				{
					return mid ;
				}
				 if	(arr[mid] < targetvalue)
				 {
					 left = mid +1;
				 }
				else 
					
				{
					right = mid -1;
				}	
			}
				return -1;
		}
		
		int[] arr = {1,2,5,7,8};
		int targetValue = 2;
		int result =  BinarySearch(arr,targetValue);
		
		if (result != -1)
		{
			Console.WriteLine("Value Found " + result);
		}
		else
		{
			Console.WriteLine("Value  Not Found ");
		}