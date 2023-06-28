using System;
using System.IO;

namespace Computer_And_Laptop_Accessories_Management_System
{
    class Program
    {
    // Arrays 
	static string [] employee_name = new string[10];
    static string [] employee_cnic = new string[10];
    static string [] employee_pass = new string[10];
    static string [] employee_name2 = new string[10];      
    static string [] employee_cnic2 = new string[10];
    static string [] employee_pass2 = new string[10];
    static string [] computer_items = new string[10];
    static int [] computer_price = new int[10];
    static int [] computer_quantity = new int[10];
    static string [] computer_items2 = new string[10];
    static int [] computer_price2 = new int[10];
    static int [] computer_quantity2 = new int[10];
    static string [] laptop_items = new string[10];
    static int [] laptop_price = new int[10];
    static int [] laptop_quantity = new int[10];
    static string [] laptop_items2 = new string[10];
    static int [] laptop_price2 = new int[10];
    static int [] laptop_quantity2 = new int [10];
    static string [] computerorder = new string[10];
    static int [] computerquantity = new int[10];
    static string [] laptoporder = new string[10];
    static int [] laptopquantity = new int[10];
    // Counters and variables
    static int i=0;
    static int q=0;
    static int r=0;
    static int t=0;
    static int a=0;
    static int s=0;
    static int id3=0;
    static int id5=0;
    static int s1=0;
    static int idx_1=0;
    static int s2=0;
    static int idx_2=0;
    static int s_3=0;
    static int idx_3=0;
    static int s_2=0;
    static int a_2=0;
    static string file = "D://Asad's Data/University Work/Object Oriented Programming ( Summer )/Week 1/Project/Computer And Laptop Accessories Management System/admin.txt";
    static string file2 = "D://Asad's Data/University Work/Object Oriented Programming ( Summer )/Week 1/Project/Computer And Laptop Accessories Management System/items.txt";
     static string file3 = "D://Asad's Data/University Work/Object Oriented Programming ( Summer )/Week 1/Project/Computer And Laptop Accessories Management System/items2.txt";
    static string select;
    static string computer_order_item;
    static string laptop_order_item;
    static int computer_order_quantity;
    static int laptop_order_quantity;
    static string write_emp_name;
    static string write_emp_cnic;
    static string write_emp_pass;    
    static void main_menu()
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("Welcome to Computer and Laptop Accessories Management System");
            Console.WriteLine("************************************************************");
        }
        static void admin_welcome()
        {
	        Console.WriteLine("**********************");
	        Console.WriteLine("Welcome to admin page ");
            Console.WriteLine("**********************");
        }
        static void admin(int option)
        {
            Console.Clear(); 
	        string user = "Asad";    // admin fixed username
	        string pass = "12345";   // admin fixed password
	        string userName;     
	        string userPass;
	        main_menu();
	        Console.WriteLine("Enter your name : ");
	        userName = Console.ReadLine();              
	        Console.WriteLine("Enter your password : ");
	        userPass = Console.ReadLine();
            if(userName==user && userPass==pass)
            { // this will check admin name and pass is correct or not
		    Console.WriteLine("Logged in successfully..........");
		    Console.WriteLine("Press any key to continue....... ");
		    Console.ReadLine();
		    Console.Clear();
		    admin_welcome();
            while(option!=5)
            {
     	    Console.WriteLine("1. Add an employee ");
     	    Console.WriteLine("2. View an employee ");
     	    Console.WriteLine("3. Delete an employee ");
     	    Console.WriteLine("4. View the availabe stock ");
     	    Console.WriteLine("5. Exit ");
     	    Console.WriteLine("Select any option : ");
     	    option = int.Parse(Console.ReadLine());
     	    if(option==1)
            {
     		add_employee();        // this will call add employee function
		    read_employee();
		    }
		    if(option==2)
            {
			view_employee();      // this will call view employee function
			Console.ReadLine();
			Console.Clear();
			admin_welcome();
		    }
		    if(option==3)
            {
			delete_employee();   // this will call delete the employee function
			Console.ReadLine();
			Console.Clear();
			admin_welcome();
		    }
		    if(option==4)
            {
			view_stock();       // this will call view stock function
			Console.ReadLine();
			Console.Clear();
			admin_welcome();
		    }
		    if(option==5){
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
       static void add_employee()
       {
       Console.Clear(); 	
       string agree;
	   admin_welcome();
	   Console.WriteLine("There are some rules for the job.  ");
       Console.WriteLine("1. You have to come on time which is 9'o clock. ");
       Console.WriteLine("2. Your job time will be 8 hours. ");
       Console.WriteLine("3. You will get salary on 5 of every month and your salary will be fixed which is 15000. ");
       Console.WriteLine("Are you agree to all the terms and conditions : ");
       agree = Console.ReadLine();
       if(agree=="Yes")
       {
        Console.WriteLine("Enter your name : ");
       	employee_name[i] = Console.ReadLine();
        write_emp_name = employee_name[i];       
		Console.WriteLine("Enter your CNIC number : ");
       	employee_cnic[i] = Console.ReadLine();
        write_emp_cnic = employee_cnic[i];
		Console.WriteLine("Enter your password : ");
       	employee_pass[i] = Console.ReadLine();
		write_emp_pass = employee_pass[i];
        Console.WriteLine("Congratulations!!!You are hired....... ");    // employee will be added one by one
       	Console.ReadLine();
        File.WriteAllText(file,write_emp_name + "," + write_emp_cnic + "," + write_emp_pass);   
       	q=i;               // this counter will take index value
       	i++;       
		Console.Clear();
       	admin_welcome();
	   }
	   if(agree=="No")
       {
	   	Console.WriteLine("Hope for your better future.Have a nice day ");
	   	Console.ReadLine();
        Console.Clear();
		admin_welcome();
	}
    }
    static void read_employee()
    {
        string record = File.ReadAllText(file);
        employee_name2[idx_1] = (getrecord(record, 0));
		employee_cnic2[idx_1] = (getrecord(record, 1));
		employee_pass2[idx_1] = (getrecord(record, 2));    
	    s1=idx_1;
		idx_1++;
    }
    static void view_employee()
    {
	   Console.Clear(); 	
	   admin_welcome();
	   Console.WriteLine("Employee Name"+"\t"+"CNIC Number"+"\t"+"Password");
	   for(int k1=0;k1<=q;k1++)
       {	
       Console.WriteLine(employee_name2[k1]+"\t"+employee_cnic2[k1]+"\t"+employee_pass2[k1]);  
    }
    }
    static void delete_employee()
    {
	   Console.Clear();
	   string name,cnic,password; 	
	   bool isFound = false;
       admin_welcome();
       Console.WriteLine("Enter your name : ");
       name = Console.ReadLine();
       Console.WriteLine("Enter your CNIC number : ");
       cnic = Console.ReadLine();
       Console.WriteLine("Enter your password : ");
       password = Console.ReadLine();
       for(int w=0;w<=q;w++)
       {
       if(name==employee_name2[w] && cnic==employee_cnic2[w] && password==employee_pass2[w])
       {
         employee_name2[w]=" ";
		 employee_cnic2[w]=" ";      	   	
		 employee_pass2[w]=" ";
         isFound = true;
	   }
       }
	    if(isFound == true)
        {
        Console.WriteLine("User deleted successfully ......");
        }
       else if(isFound == false)
        {
	   	Console.WriteLine("User is not available.....");
	    }	
	}
    static void view_stock(){
	Console.Clear(); 	
    admin_welcome();
	Console.WriteLine("Enter the category : ");
    select = Console.ReadLine();                       
    if(select=="Computer")
    {
    Console.WriteLine("Item Name "+"\t"+"Price "+"\t"+"Quantity");
	for(int y=0;y<=t;y++){	
    Console.WriteLine(computer_items2[y]+"\t"+computer_price2[y]+"\t"+computer_quantity2[y]);
    }	
	}
	if(select=="Laptop"){
	Console.WriteLine("Item Name "+"\t"+"Price "+"\t"+"Quantity");
	for(int y2=0;y2<=s_2;y2++){	
    Console.WriteLine(laptop_items2[y2]+"\t"+laptop_price2[y2]+"\t"+laptop_quantity2[y2]);
    } 
    }
    } 
    static string getrecord(string record, int x_1)
    {
	   int commas = x_1;
	int commasfound = 0;
	string store_1 = "";
	int f_1 = 0;
	while (commasfound < 3 && f_1 < record.Length)
	{
		char c_1 = record[f_1];
		if (c_1 == ',')
		{
			commasfound = commasfound + 1;

		}
		else if (commasfound == x_1)
		{
			store_1 = store_1 + c_1;
		}
		f_1 = f_1 + 1;
	}
	return store_1;
}
    static void employee_welcome()
    {
      Console.WriteLine("**************************");
	  Console.WriteLine("Welcome to employee page ");	
      Console.WriteLine("**************************");
    }
    static void employee(int option)
    {
    Console.Clear();
	string emp_Name;
	string emp_Pass;
	main_menu();
	Console.WriteLine("Enter your name : ");               
	emp_Name = Console.ReadLine(); 
	Console.WriteLine("Enter your password : ");
    emp_Pass = Console.ReadLine();	
	for(int e=0;e<=q;e++)
    {
		if(emp_Name==employee_name2[e] && emp_Pass==employee_pass2[e])
		{   // this will check employee username and password and then log in
		Console.WriteLine("Logged in successfully..........");
		Console.WriteLine("Press any key to continue....... ");
		Console.ReadLine();
		Console.Clear();
		employee_welcome();
		while(option!=6){
			Console.WriteLine("1. Add items ");
			Console.WriteLine("2. View items ");
			Console.WriteLine("3. Change the price of items ");
			Console.WriteLine("4. Sort the items ");
			Console.WriteLine("5. Change the password of account ");
			Console.WriteLine("6. Exit ");
			Console.WriteLine("Select Your option : ");
			option = int.Parse(Console.ReadLine());
			if(option==1){
				add_items();
				Console.ReadLine();
                Console.Clear();
	            employee_welcome();           // this will call add items function
			}
			if(option==2){
				view_items();        // this will call view items function
				Console.ReadLine();
                Console.Clear();
			    employee_welcome();
			}
			if(option==3){
				price_change();      //  this will call price change function
			}
			if(option==4){
				sorting();     // this will call sorting of items function
				Console.ReadLine();
                Console.Clear();
			    employee_welcome();
			}
			if(option==5){
				password_change();   // this will call password change function
			}
			if(option==6){
                Console.Clear();
				main_menu();
			}
	}
	}
	else if(emp_Name!=employee_name2[e] && emp_Pass!=employee_pass2[e]){
		Console.WriteLine("Invalid username or password.......");
		Console.ReadLine();
        Console.Clear();
		main_menu();
	}
	}
    }
    static void add_items(){
	Console.Clear();
	employee_welcome();
	string category;
	Console.WriteLine("Enter the category : ");
	category = Console.ReadLine();
	if(category=="Computer")
    {
	add_computer();
	read_items(); 
	}
	if(category=="Laptop")
    {
	add_laptop();
	read_items2();
    }
}
static void add_computer(){
	string computeritem1;
	int computerprice1,computerquantity1;
    string write_com_items;
    int write_com_price;
    int write_com_quan;
	Console.WriteLine("Enter the item : ");
	computeritem1 = Console.ReadLine();
	Console.WriteLine("Enter the price of item : ");
	computerprice1 = int.Parse(Console.ReadLine());
	Console.WriteLine("Enter the quantity : ");
	computerquantity1 = int.Parse(Console.ReadLine());
	if(computerprice1>0 && computerquantity1>0){
	computer_items[r]=computeritem1;	
	write_com_items = computer_items[r];
	computer_price[r]=computerprice1;
    write_com_price = computer_price[r]; 
	computer_quantity[r]=computerquantity1;
    write_com_quan = computer_quantity[r];
    File.WriteAllText(file2,write_com_items + "," + write_com_price + "," + write_com_quan);
	t=r;                          // this will store index value
	r++;
	Console.WriteLine("Item added successfully .....");	// items will be added one by one	
	}
	else if(computerprice1<0 || computerquantity1<0)
    {
	Console.WriteLine("You enter invalid value.....");	
	}
}
    static void add_laptop(){
	string laptopitem_1;
	int laptopprice_1,laptopquantity_1;
	string write_lap_items;
    int write_lap_price;
    int write_lap_quan;
	Console.WriteLine("Enter the item : ");
	laptopitem_1 = Console.ReadLine();
	Console.WriteLine("Enter the price of item : ");
	laptopprice_1 = int.Parse(Console.ReadLine());
	Console.WriteLine("Enter the quantity : ");
	laptopquantity_1 = int.Parse(Console.ReadLine());
	if(laptopprice_1>0 && laptopquantity_1>0)
    {
	laptop_items[a_2]=laptopitem_1;	
	write_lap_items = laptop_items[a_2];
	laptop_price[a_2]=laptopprice_1;
	write_lap_price = laptop_price[a_2]; 
	laptop_quantity[a_2]=laptopquantity_1;
	write_lap_quan = laptop_quantity[a_2];
    File.WriteAllText(file3,write_lap_items + "," + write_lap_price + "," + write_lap_quan);
	s_2=a_2;                          // this will store index value
	a_2++;
	Console.WriteLine("Item added successfully .....");	// items will be added one by one	
	}
	else if(laptopprice_1<0 || laptopquantity_1<0)
    {
	Console.WriteLine("You enter invalid value.....");	
	}
}
static void read_items()
{
	string record_2 = File.ReadAllText(file2);
    computer_items2[idx_2] = (getrecord(record_2, 0));
	computer_price2[idx_2] = int.Parse((getrecord(record_2, 1)));
	computer_quantity2[idx_2] = int.Parse((getrecord(record_2, 2)));
	s2=idx_2;
	idx_2++;	
    }    
static void read_items2()
{
    string record_3 = File.ReadAllText(file3);
    laptop_items2[idx_3] = (getrecord(record_3, 0));
	laptop_price2[idx_3] = int.Parse(getrecord(record_3, 1));
	laptop_quantity2[idx_3] = int.Parse(getrecord(record_3, 2));
	s_3=idx_3;
	idx_3++;
}
static void view_items(){
	Console.Clear(); 	
    employee_welcome();
	Console.WriteLine("Enter the category : ");
    select = Console.ReadLine();
    if(select=="Computer")
    {
    Console.WriteLine("Item Name "+"\t"+"Price "+"\t"+"Quantity");
	for(int y_01=0;y_01<=t;y_01++)
    {	
    Console.WriteLine(computer_items2[y_01]+"\t"+computer_price2[y_01]+"\t"+computer_quantity2[y_01]);
    }	
	}
	if(select=="Laptop")
    {
	Console.WriteLine("Item Name "+"\t"+"Price "+"\t"+"Quantity");
	for(int y_2=0;y_2<=s_2;y_2++)
    {	
    Console.WriteLine(laptop_items2[y_2]+"\t"+laptop_price2[y_2]+"\t"+laptop_quantity2[y_2]);
    } 
	}
}
string getrecord_3(string record_3, int x_3)
{
	int commas_3 = x_3;
	int commasfound_3 = 0;
	string store_3 = "";
	int f_3 = 0;
	while (commasfound_3 < 3 && f_3 < record_3.Length)
	{
		char c_3 = record_3[f_3];
		if (c_3 == ',')
		{
			commasfound_3 = commasfound_3 + 1;
		}
		else if (commasfound_3 == x_3)
		{
			store_3 = store_3 + c_3;
		}
		f_3 = f_3 + 1;
	}
	return store_3;
}
string getrecord_2(string record_2, int x_2)
{
	int commas_2 = x_2;
	int commasfound_2 = 0;
	string store_2 = "";
	int f_2 = 0;
	while (commasfound_2 < 3 && f_2 < record_2.Length)
	{
		char c_2 = record_2[f_2];
		if (c_2 == ',')
		{
			commasfound_2 = commasfound_2 + 1;

		}
		else if (commasfound_2 == x_2)
		{
			store_2 = store_2 + c_2;
		}
		f_2 = f_2 + 1;
	}
	return store_2;
}
static void price_change(){
	Console.Clear(); 	
    employee_welcome();
    int newprice;
    int old_price;
    string item_name;
    Console.WriteLine("Enter the category : ");
    select = Console.ReadLine();
    if(select=="Computer")
    {
    Console.WriteLine("Enter name of item : ");
    item_name = Console.ReadLine();
	Console.WriteLine("Enter price of old price of item : ");
	old_price = int.Parse(Console.ReadLine());
	for(int u=0;u<=t;u++)
    {
		if(item_name==computer_items2[u] && old_price==computer_price2[u])
        { // this will check entered name and price is same as added
			Console.WriteLine("Enter the new price of item : ");
			newprice = int.Parse(Console.ReadLine());
			Console.WriteLine("Price of item is changed successfully....");
			Console.ReadLine();
			computer_price2[u]=newprice;
			Console.ReadLine();
            Console.Clear();
	}
	}
    }
	if(select=="Laptop")
    {
	Console.WriteLine("Enter name of item : ");
	item_name = Console.ReadLine();
	Console.WriteLine("Enter price of old price of item : ");
	old_price = int.Parse(Console.ReadLine());
	for(int o=0;o<=s_2;o++)
    {
		if(item_name==laptop_items2[o] && old_price==laptop_price2[o])
        {
			Console.WriteLine("Enter the new price of item : ");
			newprice = int.Parse(Console.ReadLine());
			Console.WriteLine("Price of item is changed successfully....");
			Console.ReadLine();
			laptop_price2[o]=newprice;
			Console.ReadLine();
            Console.Clear();
	    }
	}
	}	
    }
    static void sorting(){
	Console.Clear(); 	
    employee_welcome();
	int [] newarray = new int [10];
	for(int f=0;f<=t;f++){
		newarray[f]=computer_price2[f];
	}
	int largesti=0;
	int largest=0;
	int [] copyarray = new int [10];
	largest=newarray[0];
	for(int v=0;v<=t;v++)
    {
		for(int x=1; x<=t; x++)
        {
		if(largest<newarray[x])
        {
			largest=newarray[x];
			largesti=x;
	}
	}
	copyarray[v]=largesti;
	newarray[largesti]=-1;
	largest=newarray[0];
	largesti=0;
	}
	int []newarray2 = new int[10];
	for(int f2=0;f2<=s_2;f2++)
    {
		newarray2[f2]=laptop_price2[f2];
	}
	int largesti2=0;
	int largest2=0;
	int [] copyarray2 = new int[10];
	largest2=newarray2[0];
	for(int v2=0;v2<=s_2;v2++)
    {
		for(int x2=1; x2<=s_2; x2++)
        {
		if(largest2<newarray2[x2])
        {
			largest2=newarray2[x2];
			largesti2=x2;
	}
	}
	copyarray2[v2]=largesti2;
	newarray2[largesti2]=-1;
	largest2=newarray2[0];
	largesti2=0;
	}
	Console.WriteLine("           Following are the computer items ");
	Console.WriteLine("Item Name "+"\t"+"Price "+"\t"+"Quantity");
	for(int m=0;m<=t;m++)
    {
	int id=copyarray[m];
	Console.WriteLine(computer_items2[id]+"\t"+computer_price2[id]+"\t"+computer_quantity2[id]);
	}
	Console.WriteLine("           Following are the laptop items ");
	Console.WriteLine("Item Name "+"\t"+"Price "+"\t"+"Quantity");
	for(int m2=0;m2<=s_2;m2++)
    {
	int id2=copyarray2[m2];
	Console.WriteLine(laptop_items2[id2]+"\t"+laptop_price2[id2]+"\t"+laptop_quantity2[id2]);
	}
    }
    static void password_change(){
	Console.Clear(); 	
    employee_welcome();
    string check_pass;
    string new_pass;
    Console.WriteLine("Enter your previous password : ");
    check_pass = Console.ReadLine();
    for(int id1=0;id1<=q;id1++)
    {
    if(check_pass==employee_pass2[id1])
    {
    	Console.WriteLine("Enter your new password : ");
    	new_pass = Console.ReadLine();
    	employee_pass2[id1]=new_pass;
    	Console.WriteLine("Your password is changed successfully.....");
	    Console.ReadLine();
        Console.Clear();
        employee_welcome();
	}
	else if(check_pass!=employee_pass2[id1]){
		Console.WriteLine("Wrong password ......");
        Console.ReadLine();
        Console.Clear();
        employee_welcome();
	}	
	}
    }
    static void customer_welcome()
    {
	Console.WriteLine("*************************");
	Console.WriteLine("Welcome to customer page ");
	Console.WriteLine("*************************");
    }
    static void customer(int option)
    {
    Console.Clear();
	customer_welcome();
	while(option!=4){
	Console.WriteLine("1. View the items  ");
	Console.WriteLine("2. Place your order ");
	Console.WriteLine("3. Pay your bill ");
	Console.WriteLine("4. Exit ");
	Console.WriteLine("Select your option : ");
	option = int.Parse(Console.ReadLine());
	if(option==1){
		view_stock();           // this will call view stock function
		Console.ReadLine();
        Console.Clear();
		customer_welcome();
	}
	if(option==2){
		place_the_order(select);  // this will call place the order function
	}
	if(option==3){
		pay_the_bill();             // this will call pay the bill function
		Console.ReadLine();
        Console.Clear();
	    customer_welcome();
	}
	if(option==4){
        Console.Clear();
		customer_welcome();
	}
	}
    }
    static void place_the_order(string select){
	Console.Clear();
	customer_welcome();
	Console.WriteLine("Select your category : ");
	select = Console.ReadLine();
	if(select=="Computer")
    {
	Console.WriteLine("Enter Your Item : ");
	computer_order_item = Console.ReadLine();
	Console.WriteLine("Enter The Quantity : ");
	computer_order_quantity = int.Parse(Console.ReadLine());
	for(int idx1=0;idx1<=t;idx1++)
    {
		if(computer_order_item==computer_items[idx1])
        {
		if(computer_quantity2[idx1]==0 || computer_quantity2[idx1]<computer_order_quantity)
        {
	        Console.WriteLine("Sorry product is not available......");
		}
		else if(computer_order_quantity<=computer_quantity2[idx1])
        {
			Console.WriteLine("Your order is added successfully......");
			computerorder[idx1]=computer_order_item;
			computerquantity[idx1]=computer_order_quantity;
			computer_quantity2[idx1]= computer_quantity2[idx1]-computer_order_quantity;
		    id3++;
	}
	}
	}	
	}
	if(select=="Laptop")
    {
	Console.WriteLine("Enter Your Item : ");
	laptop_order_item = Console.ReadLine();
	Console.WriteLine("Enter The Quantity : ");
	laptop_order_quantity = int.Parse(Console.ReadLine());
	for(int idx2=0;idx2<=s_2;idx2++)
    {
		if(laptop_order_item==laptop_items2[idx2])
        {
		if(laptop_quantity2[idx2]==0 || laptop_quantity2[idx2]<laptop_order_quantity){
	        Console.WriteLine("Sorry product is not available......");
		}
		else if(laptop_order_quantity<=laptop_quantity2[idx2])
        {
			Console.WriteLine("Your order is added successfully......");
			laptoporder[idx2]=laptop_order_item;
			laptopquantity[idx2]=laptop_order_quantity;
			laptop_quantity2[idx2]= laptop_quantity2[idx2]-laptop_order_quantity;
		    id5++;
	}
	}
	}
    }
	Console.ReadLine();
    Console.Clear();
	customer_welcome();
    }
    static void pay_the_bill(){
    Console.Clear();
	customer_welcome();
	int [] price1 = new int[10];
    int [] price2 = new int[10];
	int bill1=0,bill2=0,total=0;
	for(int as1=0;as1<id3;as1++)
    {
		for(int as2=0;as2<=t;as2++)
        {
		if(computerorder[as1]==computer_items2[as2])
        	{
			price1[as1]=computer_price2[as2]*computerquantity[as1];	
	}		
	}
	}
	for(int b1=0;b1<id3;b1++)
    {
		bill1+=price1[b1];
	}
	for(int as3=0;as3<id5;as3++)
    {
		for(int as4=0;as4<=s;as4++)
        {
		if(laptoporder[as3]==laptop_items2[as4])	{
			price2[as3]=laptop_price2[as4]*laptopquantity[as3];
	}		
	}
	}
	for(int b2=0;b2<id5;b2++)
    {
		bill2+=price2[b2];
	}
	Console.WriteLine("Following is the bill for computer items ");
	Console.WriteLine("Name Of Items"+"\t"+"Quantity"+"\t"+"Price");
	for(int id4=0;id4<id3;id4++)
    {	
	Console.WriteLine(computerorder[id4]+"\t"+computerquantity[id4]+"\t"+price1[id4]);
	}
    Console.WriteLine("Your computer product bill is : "+bill1);
    Console.WriteLine("Following is the bill for laptop items ");
    Console.WriteLine("Name Of Items"+"\t"+"Quantity"+"\t"+"Price");
	for(int id6=0;id6<id5;id6++)
    {	
	Console.WriteLine(laptoporder[id6]+"\t"+laptopquantity[id6]+"\t"+price2[id6]);
	}
    Console.WriteLine("Your laptop product bill is : "+bill2);
    total=bill1+bill2;
    Console.WriteLine("Your total bill will be : "+total);
    Console.WriteLine("Thanks For Your Payment....");
	}
    static void Main(string[] args)
        {
        main_menu();
        int option=0;
	    while(option!=-1){
		Console.WriteLine("1. Admin ");
		Console.WriteLine("2. Employee ");
		Console.WriteLine("3. Customer ");
		Console.WriteLine("-1. Exit ");
		Console.WriteLine("Select your option : ");
		option = int.Parse(Console.ReadLine());
		if(option==1){
			admin(option);     // this will call the admin function
	}
	    if(option==2){
	    	employee(option);   // this will call employee function
	}
		if(option==3){
			customer(option);   // this will call customer function
	}
	}
    }
    }
}
