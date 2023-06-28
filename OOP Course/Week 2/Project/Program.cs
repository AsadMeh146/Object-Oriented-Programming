using System;

namespace Project
{
    class shop
    {
         shop(string name,string category)
        {
          sname = name;
          scategory = category;  
        }   
        string sname ="";
        string scategory ="";
        int sprice =0;
        int squantity =0;
        int smini_quan =0;
        float salestax=0;
        static void main_menu()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("        Store Management System           ");
            Console.WriteLine("*******************************************");
        }
         static shop addproduct()
        {
           string category,name;
           Console.WriteLine("Enter your product name : ");
           name = Console.ReadLine();
           Console.WriteLine("Enter your product category : ");
           category = Console.ReadLine();
           shop s = new shop(name,category);
           Console.WriteLine("Enter the product price : ");
           s.sprice = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter the product quantity : ");
           s.squantity = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter the product minimum quantity : ");
           s.smini_quan = int.Parse(Console.ReadLine());
           if(s.scategory=="Fruit")
           {
               s.salestax = (s.sprice * 5) / 100;
           }
           else if(s.scategory=="Grocery")
           {
               s.salestax = (s.sprice * 10) /100 ;
           }
           else if(s.scategory!="Grocery" || s.scategory!="Fruit")
           {
               s.salestax = (s.sprice * 20) /100;
           }  
           return s;
        }
        static void viewproducts(shop [] s1,int i)
        {
            for(int j=0;j<i;j++)
            {
              Console.WriteLine(s1[j].sname+"\t"+s1[j].scategory+"\t"+s1[j].sprice+"\t"+s1[j].squantity+"\t"+s1[j].smini_quan);
            }
        }
        static void showthehighest(shop [] s1,int i)
        {
        int largestidx=0;
        int largest=s1[0].sprice;
	    for(int idx=1;idx<i;idx++){
		if(s1[idx].sprice>largest){
			largest=s1[idx].sprice;
			largestidx=idx;
		}
	    }
        Console.WriteLine("Name"+"\t"+"Category"+"\t"+"Price"+"\t"+"Quantity");       
        Console.WriteLine(s1[largestidx].sname+"\t"+s1[largestidx].scategory+"\t"+largest+"\t"+s1[largestidx].squantity);
        }
        static void viewsalestax(shop [] s1,int i)
        {
            for(int k=0;k<i;k++)
            {
              Console.WriteLine(s1[k].sname+"\t"+s1[k].scategory+"\t"+s1[k].sprice+"\t"+s1[k].squantity+"\t"+s1[k].smini_quan+"\t"+s1[k].salestax);
            }
        }
        static void itemorder(shop [] s1,int i)
        {
            int order = 0;
            for(int m=0;m<i;m++)
            {
              if(s1[m].squantity<s1[m].smini_quan) 
              {
                  order = 1;
              } 
              else if(s1[m].squantity>=s1[m].smini_quan)
              {
                  order = 0;
              }
              Console.WriteLine(s1[m].sname+"\t"+s1[m].scategory+"\t"+s1[m].sprice+"\t"+s1[m].squantity+"\t"+s1[m].smini_quan+"\t"+order);
            }
        }

        static void Main(string[] args)
        {
           shop [] s1 = new shop[10];
           int i=0;
           int option = 0;
           main_menu();
           while(option!=6) 
           {
               Console.WriteLine("1. Add products ");
               Console.WriteLine("2. View all products ");
               Console.WriteLine("3. Find product with highest unit price ");
               Console.WriteLine("4. View Sale tax of all products ");
               Console.WriteLine("5. Product to be ordered ");
               Console.WriteLine("6. Exit ");
               Console.WriteLine("Enter your option : ");
               option = int.Parse(Console.ReadLine());
           if(option==1)
           {
               s1[i] = addproduct();
               i++;
               Console.ReadLine();
               Console.Clear();
               main_menu();
           }
           if(option==2)
           {
               Console.WriteLine("Name"+"\t"+"Category"+"\t"+"Price"+"\t"+"Quantity"+"\t"+"Minimum Quantity");
               viewproducts(s1,i);
               Console.ReadLine();
               Console.Clear();
               main_menu();
           }
           if(option==3)
           {
               showthehighest(s1,i);
               Console.ReadLine();
               Console.Clear();
               main_menu();
            }
            if(option==4)
            {
               Console.WriteLine("Name"+"\t"+"Category"+"\t"+"Price"+"\t"+"Quantity"+"\t"+"Minimum Quantity"+"\t"+"Sales Tax");
               viewsalestax(s1,i);
               Console.ReadLine();
               Console.Clear();
               main_menu();
            }
            if(option==5)
            {
               Console.WriteLine("Name"+"\t"+"Category"+"\t"+"Price"+"\t"+"Quantity"+"\t"+"Minimum Quantity"+"\t"+"Product to be ordered");
               itemorder(s1,i);
               Console.ReadLine();
               Console.Clear();
               main_menu();
            }
           }
        }
    }
}
