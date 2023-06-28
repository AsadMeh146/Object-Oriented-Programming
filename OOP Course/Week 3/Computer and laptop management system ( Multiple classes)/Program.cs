using System;

namespace Computer_and_laptop_management_system___Multiple_classes_
{
    class admin
    {
        public string name = "Asad";
        public string pass = "12345";
        public void admin_welcome()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Welcome to admin page ");
            Console.WriteLine("**********************");
        }
        public employee add_employee()
        {
            string employee_name = "";
            string employee_cnic = "";
            string employee_pass = "";
            Console.Clear();
            string agree;
            admin_welcome();
            Console.WriteLine("There are some rules for the job.  ");
            Console.WriteLine("1. You have to come on time which is 9'o clock. ");
            Console.WriteLine("2. Your job time will be 8 hours. ");
            Console.WriteLine("3. You will get salary on 5 of every month and your salary will be fixed which is 15000. ");
            Console.WriteLine("Are you agree to all the terms and conditions : ");
            agree = Console.ReadLine();
            if (agree == "Yes")
            {
                Console.WriteLine("Enter your name : ");
                employee_name = Console.ReadLine();
                Console.WriteLine("Enter your CNIC number : ");
                employee_cnic = Console.ReadLine();
                Console.WriteLine("Enter your password : ");
                employee_pass = Console.ReadLine();
                Console.WriteLine("Congratulations!!!You are hired....... ");    // employee will be added one by one
                Console.ReadLine();
                Console.Clear();
                admin_welcome();
            }
            if (agree == "No")
            {
                Console.WriteLine("Hope for your better future.Have a nice day ");
                Console.ReadLine();
                Console.Clear();
                admin_welcome();
            }
            employee p = new employee(employee_name, employee_pass, employee_cnic);
            return p;

        }
        public void view_employee(employee[] employee_list, int i)
        {
            for (int idx2 = 0; idx2 < i; idx2++)
            {
                Console.WriteLine(employee_list[idx2].name + "              " + employee_list[idx2].cnic + "              " + employee_list[idx2].pass);
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to continue");
        }
        public void delete_employee(employee[] employee_list, int i)
        {
            Console.Clear();
            string check_name, check_cnic, check_password;
            bool isFound = false;
            admin_welcome();
            Console.WriteLine("Enter your name : ");
            check_name = Console.ReadLine();
            Console.WriteLine("Enter your CNIC number : ");
            check_cnic = Console.ReadLine();
            Console.WriteLine("Enter your password : ");
            check_password = Console.ReadLine();
            for (int w = 0; w < i; w++)
            {
                if (check_name == employee_list[w].name && check_cnic == employee_list[w].cnic && check_password == employee_list[w].pass)
                {
                    employee_list[w].name = " ";
                    employee_list[w].cnic = " ";
                    employee_list[w].pass = " ";
                    isFound = true;
                }
            }
            if (isFound == true)
            {
                Console.WriteLine("User deleted successfully ......");
            }
            else if (isFound == false)
            {
                Console.WriteLine("User is not available.....");
            }
        }
    }
    class employee
    {
        public string name;
        public string cnic;
        public string pass;
        public employee(string employee_name, string employee_pass, string employee_cnic)
        {
            name = employee_name;
            pass = employee_pass;
            cnic = employee_cnic;
        }
    }
    class main_employee
    {
        public void employee_welcome()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("Welcome to employee page ");
            Console.WriteLine("**************************");
        }

        public string item_name = "";
        public int item_price = 0;
        public int item_quantity = 0;
        public employee_item add_items()
        {
            Console.WriteLine("Enter item name : ");
            item_name = Console.ReadLine();
            Console.WriteLine("Enter item price : ");
            item_price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter item quantity : ");
            item_quantity = int.Parse(Console.ReadLine());
            employee_item p_1 = new employee_item(item_name, item_price, item_quantity);
            return p_1;
        }
        public void view_items(employee_item[] computer_list, employee_item[] laptop_list, int computer_i, int laptop_i)
        {
            string select;
            Console.WriteLine("Enter the category : ");
            select = Console.ReadLine();
            if (select == "Computer")
            {
                Console.WriteLine("Item Name " + "\t" + "Price " + "\t" + "Quantity");
                for (int y_01 = 0; y_01 < computer_i; y_01++)
                {
                    Console.WriteLine(computer_list[y_01].item + "\t" + computer_list[y_01].price + "\t" + computer_list[y_01].quantity);
                }
            }
            if (select == "Laptop")
            {
                Console.WriteLine("Item Name " + "\t" + "Price " + "\t" + "Quantity");
                for (int y_2 = 0; y_2 < laptop_i; y_2++)
                {
                    Console.WriteLine(laptop_list[y_2].item + "\t" + laptop_list[y_2].price + "\t" + laptop_list[y_2].quantity);
                }
            }
        }
        public void change_the_price(employee_item[] computer_list, employee_item[] laptop_list, int computer_i, int laptop_i)
        {
            int newprice;
            int old_price;
            string item_name;
            string category;
            Console.WriteLine("Enter the category : ");
            category = Console.ReadLine();
            if (category == "Computer")
            {
                Console.WriteLine("Enter name of item : ");
                item_name = Console.ReadLine();
                Console.WriteLine("Enter price of old price of item : ");
                old_price = int.Parse(Console.ReadLine());
                for (int u = 0; u < computer_i; u++)
                {
                    if (item_name == computer_list[u].item && old_price == computer_list[u].price)
                    { // this will check entered name and price is same as added
                        Console.WriteLine("Enter the new price of item : ");
                        newprice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Price of item is changed successfully....");
                        Console.ReadLine();
                        computer_list[u].price = newprice;
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
            if (category == "Laptop")
            {
                Console.WriteLine("Enter name of item : ");
                item_name = Console.ReadLine();
                Console.WriteLine("Enter price of old price of item : ");
                old_price = int.Parse(Console.ReadLine());
                for (int o = 0; o < laptop_i; o++)
                {
                    if (item_name == laptop_list[o].item && old_price == laptop_list[o].price)
                    {
                        Console.WriteLine("Enter the new price of item : ");
                        newprice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Price of item is changed successfully....");
                        Console.ReadLine();
                        laptop_list[o].price = newprice;
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
        }
        public void sorting(employee_item[] computer_list, employee_item[] laptop_list, int computer_i, int laptop_i)
        {
            Console.Clear();
            employee_welcome();
            int[] newarray = new int[10];
            for (int f = 0; f < computer_i; f++)
            {
                newarray[f] = computer_list[f].price;
            }
            int largesti = 0;
            int largest = 0;
            int[] copyarray = new int[10];
            largest = newarray[0];
            for (int v = 0; v < computer_i; v++)
            {
                for (int x = 1; x < computer_i; x++)
                {
                    if (largest < newarray[x])
                    {
                        largest = newarray[x];
                        largesti = x;
                    }
                }
                copyarray[v] = largesti;
                newarray[largesti] = -1;
                largest = newarray[0];
                largesti = 0;
            }
            int[] newarray2 = new int[10];
            for (int f2 = 0; f2 < laptop_i; f2++)
            {
                newarray2[f2] = laptop_list[f2].price;
            }
            int largesti2 = 0;
            int largest2 = 0;
            int[] copyarray2 = new int[10];
            largest2 = newarray2[0];
            for (int v2 = 0; v2 < laptop_i; v2++)
            {
                for (int x2 = 1; x2 < laptop_i; x2++)
                {
                    if (largest2 < newarray2[x2])
                    {
                        largest2 = newarray2[x2];
                        largesti2 = x2;
                    }
                }
                copyarray2[v2] = largesti2;
                newarray2[largesti2] = -1;
                largest2 = newarray2[0];
                largesti2 = 0;
            }
            Console.WriteLine("           Following are the computer items ");
            Console.WriteLine("Item Name " + "\t" + "Price " + "\t" + "Quantity");
            for (int m = 0; m < computer_i; m++)
            {
                int id = copyarray[m];
                Console.WriteLine(computer_list[id].item + "\t" + computer_list[id].price + "\t" + computer_list[id].quantity);
            }
            Console.WriteLine("           Following are the laptop items ");
            Console.WriteLine("Item Name " + "\t" + "Price " + "\t" + "Quantity");
            for (int m2 = 0; m2 < laptop_i; m2++)
            {
                int id2 = copyarray2[m2];
                Console.WriteLine(laptop_list[id2] + "\t" + laptop_list[id2].price + "\t" + laptop_list[id2].quantity);
            }
        }


    }
    class employee_item
    {
        public string item = "";
        public int price = 0;
        public int quantity = 0;
        public employee_item(string item_name, int item_price, int item_quantity)
        {
            if (item_price > 0 && item_quantity > 0)
            {
                item = item_name;
                price = item_price;
                quantity = item_quantity;
                Console.WriteLine("Item added successfully.....");
            }
            else if (item_price < 0 || item_quantity < 0)
            {
                Console.WriteLine("You entered wrong details....");
            }
        }
    }
    class customer
    {
        
       public string computer_order_item="";
       public int computer_order_quantity=0;
       public string check_computer_item="";
       public int check_computer_quantity=0;
       public int computer_order_price=0;
       public string laptop_order_item="";
       public int laptop_order_quantity=0;
       public string check_laptop_item="";
       public int check_laptop_quantity=0;
       public int laptop_order_price=0;

        public void customer_welcome()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Welcome to customer page ");
            Console.WriteLine("*************************");
        }
        public customer_computer computer_order(employee_item [] computer_list, int computer_i)
        {
          Console.WriteLine("Enter Your Item : ");
	      check_computer_item = Console.ReadLine();
	      Console.WriteLine("Enter The Quantity : ");
	      check_computer_quantity = int.Parse(Console.ReadLine());
          for(int idx1=0;idx1<computer_i;idx1++)
          {
		  if(check_computer_item==computer_list[idx1].item)
          {
		  if(computer_list[idx1].quantity==0 || computer_list[idx1].quantity< check_computer_quantity)
          {
	        Console.WriteLine("Sorry product is not available......");
		  }
		  else if(check_computer_quantity<=computer_list[idx1].quantity)
           {
			Console.WriteLine("Your order is added successfully......");
			computer_list[idx1].quantity= computer_list[idx1].quantity-check_computer_quantity;
            computer_order_item = check_computer_item;
            computer_order_quantity = check_computer_quantity;
            computer_order_price = computer_order_quantity * computer_list[idx1].price;
            } 
	     }
	     }
         customer_computer q1 = new customer_computer(computer_order_item,computer_order_quantity,computer_order_price);  
         return q1;
         }
         public customer_laptop laptop_order(employee_item [] laptop_list, int laptop_i)
        {
          Console.WriteLine("Enter Your Item : ");
	      check_laptop_item = Console.ReadLine();
	      Console.WriteLine("Enter The Quantity : ");
	      check_laptop_quantity = int.Parse(Console.ReadLine());
          for(int idx2=0;idx2<laptop_i;idx2++)
          {
		  if(check_laptop_item==laptop_list[idx2].item)
          {
		  if(laptop_list[idx2].quantity==0 || laptop_list[idx2].quantity< check_laptop_quantity)
          {
	        Console.WriteLine("Sorry product is not available......");
		  }
		  else if(check_laptop_quantity<=laptop_list[idx2].quantity)
           {
			Console.WriteLine("Your order is added successfully......");
			laptop_list[idx2].quantity= laptop_list[idx2].quantity-check_laptop_quantity;;
            laptop_order_item = check_laptop_item;
            laptop_order_quantity = check_laptop_quantity;
            laptop_order_price = laptop_order_quantity * laptop_list[idx2].price;
            } 
            
	     }
	     }
         customer_laptop q2 = new customer_laptop(laptop_order_item,laptop_order_quantity,laptop_order_price);  
         return q2;
         }
         public void pay_the_bill(customer_computer [] computer_order_list,customer_laptop [] laptop_order_list, int s, int s1)
         {
             int bill1=0;
             int bill2=0;
             int total=0;
             for(int b1=0;b1<s;b1++)
             {
                 bill1 += computer_order_list[b1].order_price;
             }
             for(int b2=0;b2<s1;b2++)
             {
                 bill2 += laptop_order_list[b2].order_price_1;
             }
            Console.WriteLine("Following is the bill for computer items ");
	        Console.WriteLine("Name Of Items"+"\t"+"Quantity"+"\t"+"Price");
	        for(int id4=0;id4<s;id4++)
            {	
	        Console.WriteLine(computer_order_list[id4].order_item+"\t"+computer_order_list[id4].order_quantity+"\t"+computer_order_list[id4].order_price);
	        }
            Console.WriteLine("Your computer product bill is : "+bill1);
            Console.WriteLine("Following is the bill for laptop items ");
            Console.WriteLine("Name Of Items"+"\t"+"Quantity"+"\t"+"Price");
	        for(int id6=0;id6<s1;id6++)
            {	
	        Console.WriteLine(laptop_order_list[id6].order_item_1+"\t"+laptop_order_list[id6].order_quantity_1+"\t"+laptop_order_list[id6].order_price_1);
	        }
            Console.WriteLine("Your laptop product bill is : "+bill2);
            total=bill1+bill2;
            Console.WriteLine("Your total bill will be : "+total);
            Console.WriteLine("Thanks For Your Payment....");
            }
            }
    class customer_computer
    {
     public string order_item = "";
     public int order_quantity = 0;   
     public int order_price = 0;
     public customer_computer(string computer_order_item,int computer_order_quantity,int computer_order_price)
     {
         order_item = computer_order_item;
         order_quantity = computer_order_quantity;
         order_price =  computer_order_price;
     }
     }
    class customer_laptop
    {
     public string order_item_1 = "";
     public int order_quantity_1 = 0;
     public int order_price_1 = 0;   
     public customer_laptop(string laptop_order_item,int laptop_order_quantity,int laptop_order_price)
     {
         order_item_1 = laptop_order_item;
         order_quantity_1 = laptop_order_quantity;
         order_price_1 = laptop_order_price;
     }
    }    
    class driver
    {
        static void main_menu()
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("Welcome to Computer and Laptop Accessories Management System");
            Console.WriteLine("************************************************************");
        }
        static void Main(string[] args)
        {
            employee[] employee_list = new employee[10];
            employee_item[] computer_list = new employee_item[10];
            employee_item[] laptop_list = new employee_item[10];
            customer_computer [] computer_order_list = new customer_computer[10]; 
            customer_laptop [] laptop_order_list = new customer_laptop[10];
            admin p1 = new admin();
            main_employee p2 = new main_employee();
            customer p3 = new customer();
            int i = 0;
            int computer_i = 0;
            int laptop_i = 0;
            int option = 0;
            int s=0;
            int s1=0;
            string category;
            main_menu();
            while (option != -1)
            {
                Console.WriteLine("1. Admin ");
                Console.WriteLine("2. Employee ");
                Console.WriteLine("3. Customer ");
                Console.WriteLine("-1. Exit ");
                Console.WriteLine("Select your option : ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    main_menu();
                    Console.WriteLine("Enter admin name : ");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter admin pin : ");
                    string pin = Console.ReadLine();
                    
                    if ((username == p1.name) & (pin == p1.pass))
                    {
                        Console.WriteLine("You logged in successfully.....");
                        Console.WriteLine("Press any key to continue....");
                        Console.ReadLine();
                        Console.Clear();
                        p1.admin_welcome();
                        while (option != 5)
                        {
                            Console.WriteLine("1. Add an employee ");
                            Console.WriteLine("2. View all employees ");
                            Console.WriteLine("3. Delete an employee ");
                            Console.WriteLine("4. View all added stock ");
                            Console.WriteLine("5. Exit ");
                            Console.WriteLine("Select your option : ");
                            option = int.Parse(Console.ReadLine());
                            if (option == 1)
                            {
                                Console.Clear();
                                p1.admin_welcome();
                                employee_list[i] = p1.add_employee();
                                i++;
                            }
                            if (option == 2)
                            {
                                Console.Clear();
                                p1.admin_welcome();
                                Console.WriteLine("Employee Name" + "\t" + "CNIC Number" + "\t" + "Password");
                                p1.view_employee(employee_list, i);
                                Console.ReadLine();
                                Console.Clear();
                                p1.admin_welcome();

                            }
                            if (option == 3)
                            {
                                Console.Clear();
                                p1.admin_welcome();
                                p1.delete_employee(employee_list, i);
                                Console.ReadLine();
                                Console.Clear();
                                p1.admin_welcome();
                            }
                            if (option == 4)
                            {
                                Console.Clear();
                                p1.admin_welcome();
                                p2.view_items(computer_list, laptop_list, computer_i, laptop_i);
                                Console.ReadLine();
                                Console.Clear();
                                p1.admin_welcome();
                            }
                            if (option == 5)
                            {
                                Console.Clear();
                                main_menu();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid uername or password.......");
                        Console.WriteLine("Try again .....");
                        Console.ReadLine();
                        Console.Clear();
                        main_menu();
                    }
                }
                if (option == 2)
                {
                    Console.Clear();
                    string emp_Name;
                    string emp_Pass;
                    main_menu();
                    Console.WriteLine("Enter your name : ");
                    emp_Name = Console.ReadLine();
                    Console.WriteLine("Enter your password : ");
                    emp_Pass = Console.ReadLine();
                    for (int e = 0; e < i; e++)
                    {
                        if (emp_Name == employee_list[e].name && emp_Pass == employee_list[e].pass)
                        {   // this will check employee username and password and then log in
                            Console.WriteLine("Logged in successfully..........");
                            Console.WriteLine("Press any key to continue....... ");
                            Console.ReadLine();
                            Console.Clear();
                            p2.employee_welcome();
                            while (option != 5)
                            {
                                Console.WriteLine("1. Add items ");
                                Console.WriteLine("2. View items ");
                                Console.WriteLine("3. Change the price of items ");
                                Console.WriteLine("4. Sort the items ");
                                Console.WriteLine("5. Exit ");
                                Console.WriteLine("Select Your option : ");
                                option = int.Parse(Console.ReadLine());
                                if (option == 1)
                                {
                                    Console.Clear();
                                    p2.employee_welcome();
                                    Console.WriteLine("Enter the category : ");
                                    category = Console.ReadLine();
                                    if (category == "Computer")
                                    {
                                        computer_list[computer_i] = p2.add_items();
                                        computer_i++;
                                    }
                                    if (category == "Laptop")
                                    {
                                        laptop_list[laptop_i] = p2.add_items();
                                        laptop_i++;
                                    }
                                    Console.ReadLine();
                                    Console.Clear();
                                    p2.employee_welcome();
                                }
                                if (option == 2)
                                {
                                    Console.Clear();
                                    p2.employee_welcome();
                                    p2.view_items(computer_list, laptop_list, computer_i, laptop_i);
                                    Console.ReadLine();
                                    Console.Clear();
                                    p2.employee_welcome();
                                }
                                if (option == 3)
                                {
                                    Console.Clear();
                                    p2.employee_welcome();
                                    p2.change_the_price(computer_list, laptop_list, computer_i, laptop_i);
                                    Console.ReadLine();
                                    Console.Clear();
                                    p2.employee_welcome();
                                }
                                if (option == 4)
                                {
                                    Console.Clear();
                                    p2.employee_welcome();
                                    p2.sorting(computer_list, laptop_list, computer_i, laptop_i);
                                    Console.ReadLine();
                                    Console.Clear();
                                    p2.employee_welcome();
                                }
                                if (option == 5)
                                {
                                    Console.Clear();
                                    main_menu();
                                }

                            }
                        }
                    }
                }
                if (option == 3)
                {
                    Console.Clear();
                    p3.customer_welcome();
                    while (option != 4)
                    {
                        Console.WriteLine("1. View the items  ");
                        Console.WriteLine("2. Place your order ");
                        Console.WriteLine("3. Pay your bill ");
                        Console.WriteLine("4. Exit ");
                        Console.WriteLine("Select your option : ");
                        option = int.Parse(Console.ReadLine());
                        if (option == 1)
                        {
                            Console.Clear();
                            p3.customer_welcome();
                            p2.view_items(computer_list, laptop_list, computer_i, laptop_i);
                            Console.ReadLine();
                            Console.Clear();
                            p3.customer_welcome();
                        }
                        if(option == 2)
                        {
                            Console.Clear();
                            p3.customer_welcome();
                            Console.WriteLine("Enter your category : ");
                            category = Console.ReadLine();
                            if(category == "Computer")
                            {
                                computer_order_list[s] = p3.computer_order(computer_list,computer_i);
                                s++;
                            }
                            if(category == "Laptop")
                            {
                                laptop_order_list[s1] = p3.laptop_order(laptop_list,laptop_i);
                                s1++;
                            }
                            Console.ReadLine();
                            Console.Clear();
                            p3.customer_welcome();
                        }
                        if(option == 3)
                        {
                            Console.Clear();
                            p3.customer_welcome();
                            p3.pay_the_bill(computer_order_list,laptop_order_list,s,s1);
                            Console.ReadLine();
                            Console.Clear();
                            p3.customer_welcome();
                        }
                        if(option == 4)
                        {
                            Console.Clear();
                            main_menu();
                        }
                    }
                }
            }
        }
    }
}
