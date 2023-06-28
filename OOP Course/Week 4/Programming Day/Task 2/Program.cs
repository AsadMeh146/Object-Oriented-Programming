using System;

namespace Task_2
{
    class Phone
    {
      protected string device_name = "";
      protected string device_model = "";
      protected string device_storage = "";
      public Phone()
      {
          
      }
      public Phone(string mobile_name,string mobile_model,string mobile_storage)
      {
          this.device_name = mobile_name;
          this.device_model = mobile_model;
          this.device_storage = mobile_storage;
      }
      public void getPhone(string mobile_name,string mobile_model,string mobile_storage)
      {
          this.device_name = mobile_name;
          this.device_model = mobile_model;
          this.device_storage = mobile_storage;
      }
      public void setPhone()
      {
          Console.WriteLine("Mobile name"+" "+"Mobile Model"+" "+"Mobile Storage");
          Console.WriteLine(this.device_name+" "+this.device_model+" "+this.device_storage);
      }
    }
    class computer: Phone
    {
        string comp_memory = "";
        public computer()
        {
          
        }
    
        public computer(string name,string model,string storage,string computer_memory)
        {
            this.device_name = name;
            this.device_model = model;
            this.device_storage = storage;
            this.comp_memory = computer_memory;
        }
        public void getMemory(string name,string model,string storage,string computer_memory)
        {
            this.device_name = name;
            this.device_model = model;
            this.device_storage = storage;
            this.comp_memory = computer_memory;
        }
        public void setMemory()
        {
            Console.WriteLine("Computer name"+" "+"Computer Model"+" "+"Computer Storage"+"Computer RAM Memory");
            Console.WriteLine(this.device_name+" "+this.device_model+" "+this.device_storage+" "+this.comp_memory);
        } 
       
    }
    class laptop: Phone
    {
        bool isSSDInstalled = true ;
        string ssd_check;
     public laptop()
     {
          
     }
     public laptop(string name_1,string model_1,string storage_1,bool isLaptopSSD)
     {
         this.device_name = name_1;
          this.device_model = model_1;
          this.device_storage = storage_1;
           isSSDInstalled = isLaptopSSD;
     }
     public void getSSD(string name_1,string model_1,string storage_1,bool isLaptopSSD)
     {
         this.device_name = name_1;
          this.device_model = model_1;
          this.device_storage = storage_1;
         isSSDInstalled = isLaptopSSD;
     }
     public void setSSD()
     {
         if(isSSDInstalled == true)
         {
            ssd_check = "Installed";
         }
         else
         {
            ssd_check = "Not Installed";
         }
         Console.WriteLine("Laptop name"+" "+"Laptop Model"+" "+"Laptop Storage"+" "+"Laptop SSD");
         Console.WriteLine(this.device_name+" "+this.device_model+" "+this.device_storage+" "+this.ssd_check);
     }

    }
    class driver
    {
        static void Main(string[] args)
        {
          string mobile_name;
          string mobile_model;
          string mobile_storage;
          string computer_memory;
          bool isLaptopSSD = true;
          Console.WriteLine("Enter the name of your mobile : ");
          mobile_name = Console.ReadLine();
          Console.WriteLine("Enter the model of your mobile : ");
          mobile_model = Console.ReadLine();
          Console.WriteLine("Enter storage capacity of your mobile : ");
          mobile_storage = Console.ReadLine();
          Console.WriteLine("Enter the ram of your computer : ");
          computer_memory = Console.ReadLine();
          Console.WriteLine("Is SSD installed in your laptop : (Ans in true / false)");
          isLaptopSSD = bool.Parse(Console.ReadLine());
          Phone p = new Phone(mobile_name,mobile_model,mobile_storage);
          computer c = new computer("HP","Core i3","1TB",computer_memory);
          laptop l = new laptop("DELL","Core i5","512GB",isLaptopSSD);
          p.getPhone(mobile_name,mobile_model,mobile_storage);
          p.setPhone();
          c.getMemory("HP","Core i3","1TB",computer_memory);
          c.setMemory();
          l.getSSD("DELL","Core i5","512GB",isLaptopSSD);
          l.setSSD();  
        }
    }
}
