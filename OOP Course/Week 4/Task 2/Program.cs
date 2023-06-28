using System;

namespace Task_2
{
    class points
    {
        int x = 0;
        int y = 0;
        int real_x = 0;
        int real_y = 0;
    points ()
    {

    }
    public points (int x_1 , int y_1)
    {
          this.x = x_1;
          this.y = y_1;
    }
    public void set_points()
    {
           Console.WriteLine("( "+ x + " , " + y + ")" );
    }
    public void get_X(int x_1)
       {
         this.real_x = x_1;
       }
     public void set_X()
       {
         Console.WriteLine("Value of x co-ordinate is : "+real_x);
       }
       public void get_Y(int y_1)
       {
         this.real_y = y_1;
       }
     public void set_Y()
       {
         Console.WriteLine("Value of y co-ordinate is : "+this.real_y);
       }
       public void get_XY()
       {
           int [] array = new int[2];
           array [0] = this.real_x;
           array [1] = this.real_y;
           Console.WriteLine("( "+ array[0] + " , " + array[1] + ")");
       }
       public void toString()
       {
           Console.WriteLine("( "+ this.real_y.ToString() + " , " + this.real_y.ToString() + ")");
       }

    }
    
    class driver
    {
        static void Main(string[] args)
        {
            int x_1 = 0;
            int y_1 = 0;
            Console.WriteLine("Enter your value of x co-ordinate : ");
            x_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your value of y co-ordinate : ");
            y_1 = int.Parse(Console.ReadLine());
            points s1 = new points(x_1,y_1);
            s1.set_points();
            Console.WriteLine("Enter your value of x co-ordinate : ");
            x_1 = int.Parse(Console.ReadLine());
            s1.get_X(x_1);
            s1.set_X();
            Console.WriteLine("Enter your value of y co-ordinate : ");
            y_1 = int.Parse(Console.ReadLine());
            s1.get_Y(y_1);
            s1.set_Y();
            s1.get_XY();
            s1.toString();       
        }
    }
}
