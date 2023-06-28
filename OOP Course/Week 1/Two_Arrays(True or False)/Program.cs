using System;

namespace Two_Arrays_True_or_False_
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            bool isFound = false;
            Console.WriteLine("Enter the size of your arrays : ");
            size = int.Parse(Console.ReadLine());
            int [] first_array = new int[size];
            int [] second_array = new int[size];
            for(int idx=0;idx<size;idx++)
            {
                Console.WriteLine("Enter your values for 1st array : ");
                first_array[idx] = int.Parse(Console.ReadLine());
            }
            for(int idx1=0;idx1<size;idx1++)
            {
                Console.WriteLine("Enter your values for 2nd array : ");
                second_array[idx1] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<size-1;i++)
            {
                for(int j=1;j<size;j++)
                {
                    if(first_array[i] == second_array[j] && j == i+1)
                    {
                        isFound = true;
                    }
                }
            }
            if(isFound == true)
            {
                Console.WriteLine("True");
            }
            else if(isFound == false)
            {
                Console.WriteLine("False");
            }
        }
    }
}
