using System;

namespace Shop_Record_Constructor
{
    class shop
    {
        shop(string pro_id,string name)
        {
          sproductid = pro_id  ;
          sname = name  ;
        }   
        string sproductid ="";
        string sname ="";
        float sprice =0;
        string scategory ="";
        string sbrandname ="";
        string scountry ="";

        static shop addproduct()
        {
           string pro_id,name;
           Console.WriteLine("Enter your product id : ");
           pro_id = Console.ReadLine();
           Console.WriteLine("Enter your product name : ");
           name = Console.ReadLine();
           shop s = new shop(pro_id,name);
           Console.WriteLine("Enter the product price : ");
           s.sprice = float.Parse(Console.ReadLine());
           Console.WriteLine("Enter the product category : ");
           s.scategory = Console.ReadLine();
           Console.WriteLine("Enter the product brand : ");
           s.sbrandname = Console.ReadLine(); 
           Console.WriteLine("Enter the product country : ");
           s.scountry = Console.ReadLine(); 
           return s;
        }
        static void viewproducts(shop [] s1,int i)
        {
            for(int j=0;j<i;j++)
            {
              Console.WriteLine(s1[j].sproductid+"\t"+s1[j].sname+"\t"+s1[j].sprice+"\t"+s1[j].scategory+"\t"+s1[j].sbrandname+"\t"+s1[j].scountry);
            }
        }
        static void totalworth(shop [] s1,int i)
        {
            float total=0;
            for(int k=0;k<i;k++)
            {
              total += s1[k].sprice;
            }
            Console.WriteLine("Total worth of all products added is : "+total);
        }
        static void Main(string[] args)
        {
           shop [] s1 = new shop[5];
           int i=0;
           int option = 0;
           while(option!=4) 
           {
               Console.WriteLine("1. Add products ");
               Console.WriteLine("2. Show all products ");
               Console.WriteLine("3. Total worth ");
               Console.WriteLine("4. Exit ");
               Console.WriteLine("Enter your option : ");
               option = int.Parse(Console.ReadLine());
           if(option==1)
           {
               s1[i] = addproduct();
               i++;
               Console.ReadLine();
               Console.Clear();
           }
           if(option==2)
           {
               Console.WriteLine("Product ID"+"\t"+"Name"+"\t"+"Price"+"\t"+"Category"+"\t"+"Brand Name"+"\t"+"Country");
               viewproducts(s1,i);
               Console.ReadLine();
               Console.Clear();
           }
           if(option==3)
           {
               totalworth(s1,i);
               Console.ReadLine();
               Console.Clear();
            }
           }
        }
    }
}
