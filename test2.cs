using System;


public class Program
{
	 
	public void Main()
	{		
		int[] input_num_box={1,1,1};
		int a_num,a_amg,b_num,b_amg;
		int turn=0;
		bool Is_empty = true;
		for(int i = 0;i<=input_num_box.Length-1;i++){	
		input_num_box[i] = Int32.Parse(Console.ReadLine());
		
		}
		Is_empty = false;
		while(!Is_empty){
			
			Console.WriteLine("Input A Box Number");
			a_num = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Input A Amount");
			a_amg = Int32.Parse(Console.ReadLine());
			
			Console.WriteLine("Input B Box Number");
			b_num = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Input B Amount");
			b_amg = Int32.Parse(Console.ReadLine());
			
			//if(a_num>input_num_box.Length||b_num>input_num_box.Length) throw new ArgumentOutOfRangeException("Input A Box Number is more than  box number");
			
			//if(a_amg>3&&a_amg<=0||b_amg>3&&b_amg<=0) throw new ArgumentOutOfRangeException("Can only pick 1 or 2");
			
			input_num_box[a_num] = input_num_box[a_num] - a_amg;
			turn++;
			
			
			for(int i = 0;i<=input_num_box.Length-1;i++){
				if(input_num_box[i]<=0){
					if(turn % 2 == 0){
					Console.WriteLine("A is winner");
					}else{
					Console.WriteLine("B is winner");		
					}
					Is_empty = true;
				}
			}
			
			input_num_box[b_num] = input_num_box[b_num] - b_amg;
			turn++;
			for(int i = 0;i<=input_num_box.Length-1;i++){
				if(input_num_box[i]<=0){
					if(turn % 2 == 0){
					Console.WriteLine("A is winner");	
					}else{
					Console.WriteLine("B is winner");		
					}
					Is_empty = true;
				}
			
			}
			
		}
	}	
}