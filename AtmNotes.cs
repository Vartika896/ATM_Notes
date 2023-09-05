using System;
using System.Collections.Generic;
					
public class Program
{
	
	
	public static void Main(string [] args)
	{
    //Suppos notes  are in ATM Machine 500, 200, 100, 50, 20, 10, 2, 1, 0.5, 0.2, 0.1, 0.02, 0.01
    
		List<double> _lst = new List<double>{500, 200, 100, 50, 20, 10, 2, 1, 0.5, 0.2, 0.1, 0.02, 0.01};

    //You Passed Input rs- 3763.58
		GetConins(3763.58, _lst);
	}
	
	public static void GetConins(double input, List<double> _lst)
	{
		for(int i=0; i <_lst.Count;i++)
		{
			if(input% _lst[i]!=0)
			{
				Console.WriteLine(_lst[i]+" => "+ (int)(input/_lst[i]));
								
			}
			input= (input% _lst[i]);	
		}
	}
/*
Expected Output
500 => 7
200 => 1
100 => 0
50 => 1
20 => 0
10 => 1
2 => 1
1 => 1
0.5 => 1
0.2 => 0
0.1 => 0
0.02 => 3
0.01 => 1
  */

}
