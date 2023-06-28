using System;

namespace Computer_and_Laptop_Management_System
{
    class Admin
    {
        private string name = "Asad";
        private string pass = "12345";
        private string get_employee_name = "";
        private string get_employee_pass = "";
        private string get_employee_cnic = "";
        public int i = 0;
        public int m = 0;
        public Admin()
        {

        }
        public Admin(string employee_name, string employee_pass, string employee_cnic)
        {
            this.get_employee_name = employee_name;
            this.get_employee_pass = employee_pass;
            this.get_employee_cnic = employee_cnic;

        }
        public void getEmployeeName(string employee_name)
        {
            this.get_employee_name = employee_name;
        }
        public void getEmployeeCnic(string employee_cnic)
        {
            this.get_employee_cnic = employee_cnic;
        }
        public void getEmployeepPass(string employee_pass)
        {
            this.get_employee_pass = employee_pass;
        }
        public string setEmployeeName()
        {
            return this.get_employee_name;
        }
        public string setEmployeeCnic()
        {
            return this.get_employee_cnic;
        }
        public string setEmployeePass()
        {
            return this.get_employee_pass;
        }
        public string admin_name()
        {
            return name;
        }
        public string admin_pass()
        {
            return pass;
        }
        public void admin_welcome()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Welcome to admin page ");
            Console.WriteLine("**********************");
        }
        public Admin add_employee()
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
            Admin p = new Admin(employee_name, employee_pass, employee_cnic);
            return p;
        }
        public void view_employee(Admin[] employee_list, int i)
        {
            for (int idx2 = 0; idx2 < i; idx2++)
            {
                Console.WriteLine(employee_list[idx2].get_employee_name + "              " + employee_list[idx2].get_employee_cnic + "              " + employee_list[idx2].get_employee_pass);
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to continue");
        }
        public void delete_employee(Admin[] employee_list, int i)
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
                if (check_name == employee_list[w].get_employee_name && check_cnic == employee_list[w].get_employee_cnic && check_password == employee_list[w].get_employee_pass)
                {
                    employee_list[w].get_employee_name = " ";
                    employee_list[w].get_employee_cnic = " ";
                    employee_list[w].get_employee_pass = " ";
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
    class Employee
    {
        public Employee()
        {

        }
        string item = "";
        string condition = "";
        int price = 0;
        public int quantity = 0;

        public Employee(string item_name,string item_condition, int item_price, int item_quantity)
        {
            if (item_price > 0 && item_quantity > 0)
            {
                item = item_name;
                condition = item_condition;
                price = item_price;
                quantity = item_quantity;
                Console.WriteLine("Item added successfully.....");
            }
            else if (item_price < 0 || item_quantity < 0)
            {
                Console.WriteLine("You entered wrong details....");
            }
        }
        public void employee_welcome()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("Welcome to employee page ");
            Console.WriteLine("**************************");
        }
        string item_name = "";
        string item_condition = "";
        int item_price = 0;
        int item_quantity = 0;
        public void getItemName(string item_name)
        {
            this.item = item_name;
        }
        public void getItemCondition(string item_condition)
        {
            this.condition = item_condition;
        }
        public void getItemPrice(int item_price)
        {
            this.price = item_price;
        }
        public void getItemQuantity(int item_quantity)
        {
            this.quantity = item_quantity;
        }
        public string setItemName()
        {
            return this.item;
        }
        public string setItemCondition()
        {
            return this.condition;
        }
        public int setItemPrice()
        {
            return this.price;
        }
        public int setItemQuantity()
        {
            return this.quantity;
        }
         
        public Employee add_items()
        {
            Console.WriteLine("Enter item name : ");
            item_name = Console.ReadLine();
            Console.WriteLine("Enter item condition : ");
            item_condition = Console.ReadLine();
            Console.WriteLine("Enter item price : ");
            item_price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter item quantity : ");
            item_quantity = int.Parse(Console.ReadLine());
            Employee p_1 = new Employee(item_name,item_condition, item_price, item_quantity);
            return p_1;
        }
        public void view_items(Employee[] computer_list, Employee[] laptop_list, int computer_i, int laptop_i)
        {
            string select;
            Console.WriteLine("Enter the category : ");
            select = Console.ReadLine();
            if (select == "Computer")
            {
                Console.WriteLine("Item Name " + "\t" +"Item Condition " + "\t" + "Price " + "\t" + "Quantity");
                for (int y_01 = 0; y_01 < computer_i; y_01++)
                {
                    Console.WriteLine(computer_list[y_01].item + "\t" +computer_list[y_01].condition + "\t" + computer_list[y_01].price + "\t" + computer_list[y_01].quantity);
                }
            }
            if (select == "Laptop")
            {
                Console.WriteLine("Item Name " + "\t" +"Item Condition " + "\t" + "Price " + "\t" + "Quantity");
                for (int y_2 = 0; y_2 < laptop_i; y_2++)
                {
                    Console.WriteLine(laptop_list[y_2].item + "\t" + laptop_list[y_2].condition + "\t" +laptop_list[y_2].price + "\t" + laptop_list[y_2].quantity);
                }
            }
        }
        public void change_the_price(Employee[] computer_list, Employee[] laptop_list, int computer_i, int laptop_i)
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
        public void sorting(Employee[] computer_list, Employee[] laptop_list, int computer_i, int laptop_i)
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
            Console.WriteLine("Item Name " + "\t" +"Item Condition " + "\t" + "Price " + "\t" + "Quantity");
            for (int m = 0; m < computer_i; m++)
            {
                int id = copyarray[m];
                Console.WriteLine(computer_list[id].item + "\t" +computer_list[id].condition + "\t" + computer_list[id].price + "\t" + computer_list[id].quantity);
            }
            Console.WriteLine("           Following are the laptop items ");
            Console.WriteLine("Item Name " + "\t" +"Item Condition " + "\t" + "Price " + "\t" + "Quantity");
            for (int m2 = 0; m2 < laptop_i; m2++)
            {
                int id2 = copyarray2[m2];
                Console.WriteLine(laptop_list[id2] + "\t" +laptop_list[id2].condition + "\t" + laptop_list[id2].price + "\t" + laptop_list[id2].quantity);
            }
        }
        
    }
    class Customer
    {
    string order_item_1 = "";
    int order_quantity_1 = 0;
    int order_price_1 = 0;
    protected int bill1=0;
    protected int bill2=0;
    public Customer()
    {

    }   
     public Customer(string order_item,int order_quantity,int order_price)
     {
         this.order_item_1 = order_item;
         this.order_quantity_1 = order_quantity;
         this.order_price_1 = order_price;
     }
     public void getOrderItem(string order_item)
     {
        this.order_item_1 = order_item;
     }
     public void getOrderQuantity(int order_quantity)
     {
        this.order_quantity_1 = order_quantity;
     }
     public void getOrderPrice(int order_price)
     {
         this.order_price_1 = order_price;
     }
     public string setOrderItem()
     {
         return this.order_item_1;
     }
     public int setOrderPrice()
     {
         return this.order_price_1;
     }
     public int setOrderQuantity()
     {
         return this.order_quantity_1;
     }
        string order_item="";
        int order_quantity=0;
        int order_price=0;
        string check_item = "";
        int check_quantity = 0;

        public void customer_welcome()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Welcome to customer page ");
            Console.WriteLine("*************************");
        }
        public Customer computer_order(Employee [] computer_list, int computer_i)
        {
          Console.WriteLine("Enter Your Item : ");
	      check_item = Console.ReadLine();
	      Console.WriteLine("Enter The Quantity : ");
	      check_quantity = int.Parse(Console.ReadLine());
          for(int idx1=0;idx1<computer_i;idx1++)
          {
		  if(check_item==computer_list[idx1].setItemName())
          {
		  if(computer_list[idx1].setItemQuantity()==0 || computer_list[idx1].setItemQuantity()< check_quantity)
          {
	        Console.WriteLine("Sorry product is not available......");
		  }
		  else if(check_quantity<=computer_list[idx1].setItemQuantity())
           {
			Console.WriteLine("Your order is added successfully......");
			computer_list[idx1].quantity = computer_list[idx1].setItemQuantity()-check_quantity;
            order_item = check_item;
            order_quantity = check_quantity;
            order_price = order_quantity * computer_list[idx1].setItemPrice();
            } 
	     }
	     }
         Customer q1 = new Customer(order_item,order_quantity,order_price);  
         return q1;
         }
        public Customer laptop_order(Employee [] laptop_list, int laptop_i)
        {
          Console.WriteLine("Enter Your Item : ");
	      check_item = Console.ReadLine();
	      Console.WriteLine("Enter The Quantity : ");
	      check_quantity = int.Parse(Console.ReadLine());
          for(int idx2=0;idx2<laptop_i;idx2++)
          {
		  if(check_item==laptop_list[idx2].setItemName())
          {
		  if(laptop_list[idx2].setItemQuantity()==0 || laptop_list[idx2].setItemQuantity()< check_quantity)
          {
	        Console.WriteLine("Sorry product is not available......");
		  }
		  else if(check_quantity<=laptop_list[idx2].setItemQuantity())
           {
			Console.WriteLine("Your order is added successfully......");
			laptop_list[idx2].quantity = laptop_list[idx2].setItemQuantity()-check_quantity;;
            order_item = check_item;
            order_quantity = check_quantity;
            order_price = order_quantity * laptop_list[idx2].setItemPrice();
            } 
            
	     }
	     }
         Customer q2 = new Customer(order_item,order_quantity,order_price);  
         return q2;
         }
         public virtual int pay_the_bill(Customer[] computer_order_list,Customer [] laptop_order_list, int m1, int m2)
         {
            int total = 0;
             for(int b1=0;b1<m1;b1++)
             {
                 bill1 += computer_order_list[b1].order_price_1;
             }
             for(int b2=0;b2<m2;b2++)
             {
                 bill2 += laptop_order_list[b2].order_price_1;
             }
            
            total=bill1+bill2;
            return total;
            }
            }
    class MemberShip : Customer
    {
        public MemberShip()
        {

        }
        public override int pay_the_bill(Customer[] computer_order_list,Customer [] laptop_order_list, int m1, int m2)
        {
            int total = base.pay_the_bill(computer_order_list,laptop_order_list,m1,m2);
            total = total - ((total * 10) / 100);
            return total;    
        }    
    }
    class Driver
    {
        static void main_menu()
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("Welcome to Computer and Laptop Accessories Management System");
            Console.WriteLine("************************************************************");
        }
        static void Main(string[] args)
        {
            Admin s = new Admin();
            Admin [] employee_list = new Admin[10];
            Employee [] computer_list = new Employee[10];
            Employee [] laptop_list = new Employee[10];
            Customer [] computer_order_list = new Customer[10]; 
            Customer [] laptop_order_list = new Customer[10];
            Employee p2 = new Employee();
            Customer p3 = new Customer();
            MemberShip p4 = new MemberShip();
            string get_name;
            string get_pass;
            string category;
            get_name = s.admin_name();
            get_pass = s.admin_pass();
            int option = 0;
            int i = 0;
            int computer_i = 0;
            int laptop_i = 0;
            int m1 = 0;
            int m2 = 0;
            int real_bill1 = 0;
            int real_bill2 = 0;
            bool isMembership = false;
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
                    if ((username == get_name) & (pin == get_pass))
                    {
                        Console.WriteLine("You logged in successfully.....");
                        Console.WriteLine("Press any key to continue....");
                        Console.ReadLine();
                        Console.Clear();
                        s.admin_welcome();
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
                                s.admin_welcome();
                                employee_list[i] = s.add_employee();
                                i++;
                            }
                            if (option == 2)
                            {
                                Console.Clear();
                                s.admin_welcome();
                                Console.WriteLine("Employee Name" + "\t" + "CNIC Number" + "\t" + "Password");
                                s.view_employee(employee_list, i);
                                Console.ReadLine();
                                Console.Clear();
                                s.admin_welcome();
                            }
                            if (option == 3)
                            {
                                Console.Clear();
                                s.admin_welcome();
                                s.delete_employee(employee_list, i);
                                Console.ReadLine();
                                Console.Clear();
                                s.admin_welcome();
                            }
                            if (option == 4)
                            {
                                Console.Clear();
                                s.admin_welcome();
                                p2.view_items(computer_list, laptop_list, computer_i, laptop_i);
                                Console.ReadLine();
                                Console.Clear();
                                s.admin_welcome();
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
                        if (emp_Name == employee_list[e].setEmployeeName()&& emp_Pass == employee_list[e].setEmployeePass())
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
                if(option == 3)
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
                                computer_order_list[m1] = p3.computer_order(computer_list,computer_i);
                                m1++;
                            }
                            if(category == "Laptop")
                            {
                                laptop_order_list[m2] = p3.laptop_order(laptop_list,laptop_i);
                                m2++;
                            }
                            Console.ReadLine();
                            Console.Clear();
                            p3.customer_welcome();
                        }
                        if(option == 3)
                        {
                            Console.Clear();
                            p3.customer_welcome();
                            Console.WriteLine("Do you have membership : ( true / false )");
                            isMembership = bool.Parse(Console.ReadLine());
                            Console.WriteLine("Following is the bill for computer items ");
	                        Console.WriteLine("Name Of Items"+"\t"+"Quantity"+"\t"+"Price");
                            for(int b1=0;b1<m1;b1++)
                            {
                            real_bill1 += computer_order_list[b1].setOrderPrice();
                            }
                            for(int b2=0;b2<m2;b2++)
                            {
                            real_bill2 += laptop_order_list[b2].setOrderPrice();
                            }
	                        for(int id4=0;id4<m1;id4++)
                            {	
	                        Console.WriteLine(computer_order_list[id4].setOrderItem()+"\t"+computer_order_list[id4].setOrderQuantity()+"\t"+computer_order_list[id4].setOrderPrice());
	                        }
                            Console.WriteLine("Your computer product bill is : "+real_bill1);
                            Console.WriteLine("Following is the bill for laptop items ");
                            Console.WriteLine("Name Of Items"+"\t"+"Quantity"+"\t"+"Price");
	                        for(int id6=0;id6<m2;id6++)
                            {	
	                        Console.WriteLine(laptop_order_list[id6].setOrderItem()+"\t"+laptop_order_list[id6].setOrderQuantity()+"\t"+laptop_order_list[id6].setOrderPrice());
	                        }
                            Console.WriteLine("Your laptop product bill is : "+real_bill2);
                            if(isMembership == true)
                            {
                               p3 = p4; 
                               int discount_bill = p3.pay_the_bill(computer_order_list,laptop_order_list,m1,m2);
                               Console.WriteLine("Your discounted bill due to membership is : "+discount_bill);
                            }
                            else if(isMembership == false)
                            {
                               int get_bill = p3.pay_the_bill(computer_order_list,laptop_order_list,m1,m2);
                               Console.WriteLine("Your total bill is : "+get_bill);
                            }
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
