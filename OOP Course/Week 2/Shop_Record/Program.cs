using System;

namespace Shop_Record
{
    class shop
    {
        public string sproductid ="";
        public string sname ="";
        public float sprice =0;
        public string scategory ="";
        public string sbrandname ="";
        public string scountry ="";
        static void addproducts(shop s)
        {
            Console.WriteLine("Enter the product ID : ");
            s.sproductid = Console.ReadLine();
            Console.WriteLine("Enter the product name : ");
            s.sname = Console.ReadLine();
            Console.WriteLine("Enter the product price : ");
            s.sprice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the product category : ");
            s.scategory = Console.ReadLine();
            Console.WriteLine("Enter the product brand : ");
            s.sbrandname = Console.ReadLine(); 
            Console.WriteLine("Enter the product country : ");
            s.scountry = Console.ReadLine(); 
        }
        static void viewproducts(shop s)
        {
           Console.WriteLine(s.sproductid+"\t"+s.sname+"\t"+s.sprice+"\t"+s.scategory+"\t"+s.sbrandname+"\t"+s.scountry);
        }
        static void totalworth(shop s1,shop s2,shop s3,shop s4,shop s5)
        {
            float total = 0;
            total = s1.sprice+s2.sprice+s3.sprice+s4.sprice+s5.sprice;
            Console.WriteLine("The total worth of all added products is : "+total);
        }
        static void Main(string[] args)
        {
           shop s1 = new shop();
           shop s2 = new shop();
           shop s3 = new shop();
           shop s4 = new shop();
           shop s5 = new shop();
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
               addproducts(s1);
               addproducts(s2);
               addproducts(s3);
               addproducts(s4);
               addproducts(s5);
               Console.ReadLine();
               Console.Clear();
           }
           if(option==2)
           {
               Console.WriteLine("Product ID"+"\t"+"Name"+"\t"+"Price"+"\t"+"Category"+"\t"+"Brand Name"+"\t"+"Country");
               viewproducts(s1);
               viewproducts(s2);
               viewproducts(s3);
               viewproducts(s4);
               viewproducts(s5);
               Console.ReadLine();
               Console.Clear();
           }
           if(option==3)
           {
               totalworth(s1,s2,s3,s4,s5);
               Console.ReadLine();
               Console.Clear();
            }
           }
        }
    }
}
