using System;

namespace Gender_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
           string [,] gender_name =  {{"Bob","Ana"},{"Josh","Amy"},{"Tim","Lisa"}};
           string [,] result_array = new string [3,2]; 
           string get_gender;
           int idx=0;
           int idx1=0;
           string [] first_data = new string[3];
           string [] second_data = new string [3];
           for(int i=0;i<3;i++)
           {
               for(int j=0;j<2;j++)
               {
                   Console.WriteLine(gender_name[i,j]);
               }
           }
          Console.WriteLine("Enter the gender whose name you want to change : ");
          get_gender = Console.ReadLine();
          if(get_gender == "Male")
          {
            for(int a=2;a>=0;a--)
            {  
                first_data[idx]=gender_name[a,0];
                idx++;
            }
            for(int a1=0;a1<3;a1++)
            {  
                second_data[idx1]=gender_name[a1,1];
                idx1++;
            }
            for(int s=0;s<3;s++)
            {
              result_array[s,0] = first_data[s];
            }
            for(int s1=0;s1<3;s1++)
            {
              result_array[s1,1] = second_data[s1];
            }
            for(int i1=0;i1<3;i1++)
            {
                for(int j1=0;j1<2;j1++)
                {
                  Console.WriteLine(result_array[i1,j1]);
                }
            }
          }
          else if(get_gender == "Female")
          {
            for(int a=2;a>=0;a--)
            {  
                first_data[idx]=gender_name[a,1];
                idx++;
            }
            for(int a1=0;a1<3;a1++)
            {  
                second_data[idx1]=gender_name[a1,0];
                idx1++;
            }
            for(int s=0;s<3;s++)
            {
              result_array[s,1] = first_data[s];
            }
            for(int s1=0;s1<3;s1++)
            {
              result_array[s1,0] = second_data[s1];
            }
            for(int i1=0;i1<3;i1++)
            {
                for(int j1=0;j1<2;j1++)
                {
                  Console.WriteLine(result_array[i1,j1]);
                }
            }
          }
          }
        }
    }

