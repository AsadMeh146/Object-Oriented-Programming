using System;
using System.IO;
namespace Fruit_Shop
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
    static void User_option(string [] fruit_name,string [] item_price,int counter)
    {
        string get_fruit;
        int quantity;
        int price;
        int idx=0;
        float total=0;
        bool isFound = false;
        Console.WriteLine("Enter the fruit name : ");
        get_fruit = Console.ReadLine();
        for(int k=0;k<counter;k++)
        {
           if(get_fruit == fruit_name[k])
           { 
            Console.WriteLine("Enter your quantity : ");
            quantity = int.Parse(Console.ReadLine());  
            idx = k;
            price = int.Parse(item_price[idx]);
            total = quantity * price;  
            isFound = true;
           }
        }
        if(isFound == true)
        {
             Console.WriteLine("Your total price will be : "+total);
        }
        else if(isFound == false)
        {
             Console.WriteLine("Fruit is not available");
        }
    }
    static void Admin_option(string path)
    {
        string new_fruit;
        int new_price;
        Console.WriteLine("Enter the fruit you want to add : ");
        new_fruit = Console.ReadLine();
        Console.WriteLine("Enter the price for added fruit : ");
        new_price = int.Parse(Console.ReadLine());
        File.AppendAllText(path,new_fruit + "," + new_price);
    }
        static void Main(string[] args)
        { 
            int option=0;
            int counter=0;
            string path = "D://Asad's Data/University Work/Object Oriented Programming ( Summer )/Week 1/Fruit_Shop/fruits.txt";
            string [] record = File.ReadAllLines(path);
            string [] fruit_name = new string[10]; 
            string [] item_price = new string[10];
            for(int a=0;a < record.Length;a++)
            {
            fruit_name[a] = parseData(record[a],0);
            item_price[a] = parseData(record[a],1);
            counter++;
            }
            while(option!=3)
            {
            Console.WriteLine("1. User Panel ");
            Console.WriteLine("2. Admin Panel ");
            Console.WriteLine("3. Exit ");
            Console.WriteLine("Select your option : ");
            option = int.Parse(Console.ReadLine());
            if(option==1)
            {
             User_option(fruit_name,item_price,counter);   
             Console.ReadLine();
             Console.Clear(); 
            }    
            if(option==2)
            {
            Admin_option(path);
            Console.ReadLine();
            Console.Clear();  
            }
            }
            
    }
    }
}
 