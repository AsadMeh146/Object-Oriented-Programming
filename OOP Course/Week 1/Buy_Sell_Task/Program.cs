using System;

namespace Buy_Sell_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] days = new int[6];
            int x=1;
            int profit=0;
            for(int idx=0;idx<=5;idx++)
            {
            Console.Write("Write price of "+x+" day : ");
            days[idx] = int.Parse(Console.ReadLine());
            x++; 
            }
            int buy_index=0;
            int buy_check=days[0];
            for(int j=1;j<=5;j++)
            {
            if(days[j]<buy_check)
            {
            buy_check = days[j];
            buy_index = j; 
            }    
            }
            int sell_index=0;
            int sell_check=days[buy_index];
            for(int k=buy_index+1;k<=5;k++)
            {
            if(days[k]>sell_check)
            {
            sell_check = days[k];
            sell_index = k; 
            }    
            }
        if(sell_check==buy_check)
        {
           Console.WriteLine("No transactions are done and max profit is : "+profit); 
        }
        else if(sell_check!=buy_check)
        {
           profit=sell_check-buy_check;
           buy_index=buy_index+1;
           sell_index=sell_index+1;
           Console.WriteLine("Best day to buy stock is "+buy_index+" and price will be : "+buy_check);
           Console.WriteLine("Best day to sell stock is "+sell_index+" and price will be : "+sell_check);
           Console.WriteLine("Your max profit will be : "+profit);
        }
        }
    }
}
