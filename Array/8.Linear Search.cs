static int  LinearSearch(int[] arr,int targetvalue)
		{
			for (int i = 0;i<arr.Length;i++)
			{
				if (arr[i] == targetvalue){
				return i;
				}}
			return -1;
			
		
			
		}
		int[] arr ={1,2,3,4,5,8};
		int targetvalue = 8;
		
		int result = LinearSearch(arr,targetvalue);
		if (result !=-1)
		{
			Console.WriteLine(targetvalue +"Value found at" + result);
		}
		else 
		{
			Console.WriteLine(targetvalue+ "Value not  found ");
		}