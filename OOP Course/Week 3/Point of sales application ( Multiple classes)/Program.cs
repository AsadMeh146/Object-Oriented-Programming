using System;
using static System.Console;
namespace day2
{
    class Admin
    {
        public string AdminName = "Moiz";
        public int AdminPin = 472;
        public Product AddProducts()
        {
            string proname = "";
            string procate = "";
            float price = 0;
            float quan = 0;
            float minQuan = 0;
            float taxs = 0;
            float sum = 0;
            Write("Enter Name of Product : ");
            proname = ReadLine();
            Write("Enter Category of Product : ");
            procate = ReadLine();
            Write("Enter Price of Product : ");
            price = float.Parse(ReadLine());
            Write("Enter Quantity of Product : ");
            quan = float.Parse(ReadLine());
            Write("Enter Minimum Quantity of Product : ");
            minQuan = float.Parse(ReadLine());

            if ((procate == "Grocery") || (procate == "grocery"))
            {
                taxs = (price);
                // WriteLine(taxs);
                taxs = (taxs * 10);
                // WriteLine(taxs);
                taxs = (taxs / 100);
                sum = (taxs);
                // WriteLine(taxs);
                // WriteLine(sum);
            }
            else if ((procate == "Fruit") || (procate == "fruit"))
            {
                taxs = (price);
                // WriteLine(taxs);
                taxs = (taxs * 5);
                // WriteLine(taxs);
                taxs = (taxs / 100);
                sum = (taxs);
                // WriteLine(taxs);
                // WriteLine(sum);
            }
            else if ((procate != "Fruit") && (procate != "fruit") && (procate != "Grocery") && (procate != "grocery"))
            {
                taxs = (price);
                // WriteLine(taxs);
                taxs = (taxs * 15);
                // WriteLine(taxs);
                taxs = (taxs / 100);
                // WriteLine(taxs);
                sum = (taxs);
                // WriteLine(sum);
            }
            Product p = new Product(proname, procate, price, quan, minQuan, sum);
            return p;
        }
        public void getAllProduct(Product[] productList, int idx)
        {
            WriteLine("Name" + "              " + "Category" + "            " + "Price" + "             " + "Quantity" + "      " + "Minimum Stock");
            for (int i = 0; i < idx; i++)
            {
                WriteLine(productList[i].name + "              " + productList[i].category + "              " + productList[i].prices + "              " + productList[i].proQuan + "             " + productList[i].min);
                WriteLine();
            }
            WriteLine("Press any key to continue");
            ReadLine();
            // Clear();
        }
        public void highestProduct(Product[] productList, int idx)
        {
            float largestPrice = 0;
            string largestProName = "";
            string largestProCate = "";
            float largestProQuan = 0;
            WriteLine("Name" + "              " + "Category" + "            " + "Price" + "             " + "Quantity");
            for (int i = 0; i < idx; i++)
            {
                if (productList[i].prices > largestPrice)
                {
                    largestPrice = productList[i].prices;
                    largestProName = productList[i].name;
                    largestProCate = productList[i].category;
                    largestProQuan = productList[i].proQuan;
                }
                // WriteLine();
            }
            WriteLine(largestProName + "              " + largestProCate + "              " + largestPrice + "              " + largestProQuan);
            WriteLine("Press any key to continue");
            ReadLine();
            Clear();
        }
        public void salesTaxProduct(Product[] productList, int idx)
        {
            WriteLine("Name" + "              " + "Category" + "            " + "Price" + "             " + "Quantity" + "   " + "SalesTax");
            for (int i = 0; i < idx; i++)
            {
                WriteLine(productList[i].name + "              " + productList[i].category + "              " + productList[i].prices + "                   " + productList[i].proQuan + "             " + productList[i].salestax);
            }
            WriteLine("Press any key to continue");
            ReadLine();
            Clear();
        }
        public void toBeOrdered(Product[] productList, int idx)
        {
            float order = 0;
            WriteLine("Name" + "              " + "Category" + "            " + "Price" + "             " + "Quantity" + "     " + "Minimum Stock" + "       " + "Tome to order");
            for (int i = 0; i < idx; i++)
            {
                if (productList[i].min > productList[i].proQuan)
                {
                    order = 1;
                }
                else
                {
                    order = 0;
                }
                WriteLine(productList[i].name + "              " + productList[i].category + "              " + productList[i].prices + "                   " + productList[i].proQuan + "             " + productList[i].min + "                     " + order);
            }
            WriteLine("Press any key to continue");
            ReadLine();
            Clear();
        }
    }
    class Product
    {
        public string name = "";
        public string category = "";
        public float prices = 0;
        public float proQuan = 0;
        public float min = 0;
        public float salestax = 0;
        public Product(string proname, string procate, float price, float quan, float minQuan, float sales)
        {
            name = proname;
            category = procate;
            prices = price;
            proQuan = quan;
            min = minQuan;
            salestax = sales;
        }

    }
    class Customer
    {
        public string customerName = "";
        public string customerAddress = "";
        public int phoneNo = 0;
        public Customer(string CName, string CAdress, int phone)
        {
            customerName = CName;
            customerAddress = CAdress;
            phoneNo = phone;
        }
    }
    class buyer
    {
        public void buyProducts(Product[] productList, int idx)
        {
            float bill = 0;
            // getAllProduct(productList, idx);
            WriteLine("Enter Product Name : ");
            string productname = ReadLine();
            WriteLine("Enter Category Name : ");
            string productcategory = ReadLine();
            WriteLine("Enter Quantity you want : ");
            float productQuantity = float.Parse(ReadLine());
            for (int u = 0; u < idx; u++)
            {
                if ((productname == productList[u].name) && (productcategory == productList[u].category))
                {
                    bill = (productList[u].prices * productQuantity) + (productQuantity * productList[u].salestax);
                    productList[u].proQuan = productList[u].proQuan - productQuantity;
                }
            }
            WriteLine("Dear Customer your bill is : " + bill);
            ReadLine();
        }
    }
    class Driver
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int idx = 0;
            int index = 0;
            Product[] productList = new Product[50];
            Customer[] customerList = new Customer[50];
            int press = 0;
            while (press != 3)
            {
                mainMenu();
                press = int.Parse(ReadLine());
                if (press == 1)
                {
                    WriteLine("Enter Product name : ");
                    string name = ReadLine();
                    WriteLine("Enter Product pin : ");
                    int pin = int.Parse(ReadLine());
                    Admin p1 = new Admin();
                    Clear();
                    if ((name == p1.AdminName) & (pin == p1.AdminPin))
                    {
                        while (choice != 6)
                        {
                            choice = DisplayMenu();
                            if (choice == 1)
                            {
                                subheader();
                                productList[idx] = p1.AddProducts();
                                idx++;
                            }
                            if (choice == 2)
                            {
                                subheader();
                                p1.getAllProduct(productList, idx);
                                Clear();
                            }
                            if (choice == 3)
                            {
                                subheader();
                                p1.highestProduct(productList, idx);
                            }
                            if (choice == 4)
                            {
                                subheader();
                                p1.salesTaxProduct(productList, idx);
                            }
                            if (choice == 5)
                            {
                                subheader();
                                p1.toBeOrdered(productList, idx);
                            }
                        }
                        choice = 0;
                    }
                    else
                    {
                        WriteLine("Your entered wrong info!");
                        ReadLine();
                    }
                }
                else if (press == 2)
                {
                    int Custom = 0;
                    customerList[index] = addCustomer();
                    index++;
                    Clear();
                    Admin p2 = new Admin();
                    while (Custom != 3)
                    {
                        Custom = DisplayMenuCustomer();
                        if (Custom == 1)
                        {
                            subheader();
                            p2.getAllProduct(productList, idx);
                            Clear();
                        }
                        else if (Custom == 2)
                        {
                            buyer p = new buyer();
                            subheader();
                            p2.getAllProduct(productList,idx);
                            p.buyProducts(productList, idx);
                        }
                    }
                }
            }
            press = 0;
        }
        static Customer addCustomer()
        {
            WriteLine("Enter your name : ");
            string name = ReadLine();
            WriteLine("Enter your address : ");
            string address = (ReadLine());
            WriteLine("Enter your phoneNo : ");
            int phones = int.Parse(ReadLine());
            Customer p1 = new Customer(name, address, phones);
            return p1;
        }
        static int DisplayMenu()
        {
            int option = 0;
            WriteLine("---------------------------------------------------------------------------");
            WriteLine("|                                                                         |");
            WriteLine("|                          Store Management System                        |");
            WriteLine("|                                                                         |");
            WriteLine("---------------------------------------------------------------------------");
            WriteLine("|                                                                         |");
            WriteLine("|                          1.Add Product                                  |");
            WriteLine("|                          2.View All Products                            |");
            WriteLine("|                          3.Find Product With Highest Unit Price         |");
            WriteLine("|                          4.View Sales Tax Of All Products               |");
            WriteLine("|                          5.Products To Be Ordered                       |");
            WriteLine("|                          6.Exit                                         |");
            WriteLine("---------------------------------------------------------------------------");
            option = int.Parse(ReadLine());
            Clear();
            return option;
        }
        static int DisplayMenuCustomer()
        {
            int option = 0;
            WriteLine("---------------------------------------------------------------------------");
            WriteLine("|                                                                         |");
            WriteLine("|                          Store Management System                        |");
            WriteLine("|                                                                         |");
            WriteLine("---------------------------------------------------------------------------");
            WriteLine("|                                                                         |");
            WriteLine("|                          1.View All Products                            |");
            WriteLine("|                          2.Buy Products                                 |");
            WriteLine("|                          3.Exit                                         |");
            WriteLine("---------------------------------------------------------------------------");
            option = int.Parse(ReadLine());
            Clear();
            return option;
        }
        static void subheader()
        {
            WriteLine("---------------------------------------------------------------------------");
            WriteLine("|                                                                         |");
            WriteLine("|                          Store Management System                        |");
            WriteLine("|                                                                         |");
            WriteLine("---------------------------------------------------------------------------");
        }
        static void mainMenu()
        {
            WriteLine("---------------------------------------------------------------------------");
            WriteLine("|                           Enter 1 For Product                           |");
            WriteLine("|                           Enter 2 For Customer                          |");
            WriteLine("|                           Enter 3 For Exit                              |");
            WriteLine("---------------------------------------------------------------------------");
        }
    }
}
