using System;
using System.IO;

namespace Movie_Tickets
{
    class Program
    {
        static string parseData(string record, float parseNum)
        {
       int commas= 0;
	   string storeInfo="";
       for(int x=0;x < record.Length; x++)
       {
        if(record[x] == ',')
        {
        commas++;
        x++;
        }
        if(commas == parseNum)
        {
        storeInfo+= record[x];
        }
       }
       return storeInfo;
    }
    static void get_discount(string [] movie_name,string [] movie_price,int counter)
    {
        string get_name;
        int s=0;
        float get_price=0;
        float discount_price=0;
        Console.WriteLine("Enter the name of the movie : ");
        get_name = Console.ReadLine();
        for(int i=0;i<counter;i++)
        {
            if(get_name == movie_name[i])
            {
               if(i%2==1)
               {
                 s=i;
                 get_price = float.Parse(movie_price[s]);
                 discount_price = (get_price * 10)/100;
                 discount_price = get_price - discount_price;
               }
               else if(i%2==0)
               {
                 s=i;
                 get_price = float.Parse(movie_price[s]);
                 discount_price = (get_price * 5)/100;
                 discount_price = get_price - discount_price;
               } 
            }
        }
        Console.WriteLine("Your total with discounted price will be : "+discount_price);
    }
        static void Main(string[] args)
        {
            int counter=0;
            
            string path = "D://Asad's Data/University Work/Object Oriented Programming ( Summer )/Week 1/Movie_Tickets/tickets.txt";
            string [] record = File.ReadAllLines(path);
            string [] movie_name = new string[10]; 
            string [] movie_price = new string[10];
            for(int a=0;a < record.Length;a++)
            {
            movie_name[a] = parseData(record[a],0);
            movie_price[a] = parseData(record[a],1);
            counter++;
            }

            get_discount(movie_name,movie_price,counter);
        }
    }
}
