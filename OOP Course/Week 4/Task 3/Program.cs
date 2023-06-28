using System;

namespace Task_3
{
    class points
    {
        int start_x = 0;
        int start_y = 0;
        int end_x = 0;
        int end_y = 0;
        int real_start_x = 0;
        int real_start_y = 0;
        int real_end_x = 0;
        int real_end_y = 0;
        points()
        {

        }
        public points(int x_1,int y_1,int x_2,int y_2)
        {
            this.real_start_x = x_1;
            this.real_start_y = y_1;
            this.real_end_x = x_2;
            this.real_end_y = y_2;
        }
        public void set_points()
        {
            Console.WriteLine("Starting points of line are : ( "+this.real_start_x+" , "+this.real_start_y+")");
            Console.WriteLine("Ending points of line are : ( "+this.real_end_x+" , "+this.real_end_y+")");
        }
        public void getBegin(int x_1,int y_1)
        {
            this.start_x = x_1;
            this.start_y = y_1;
        }
        public void setBegin()
        {
            Console.WriteLine("Starting points of line are : ( "+this.start_x+" , "+this.start_y+")");
        }
        public void array_start()
        {
            int [] arr_start = new int[2];
            arr_start[0] =  this.start_x;
            arr_start[1] =  this.start_y;
            Console.WriteLine("Now these values in arrays are ");
            Console.WriteLine("Starting points of line are : ( "+arr_start[0]+" , "+arr_start[1]+")"); 
        }
        public void getEnd(int x_2,int y_2)
        {
            this.end_x = x_2;
            this.end_y = y_2;
            
        }
        public void setEnd()
        {
            Console.WriteLine("Ending points of line are : ( "+this.end_x+" , "+this.end_y+")");
        }
        public void array_end()
        {
            int [] arr_end = new int[2];
            arr_end[0] =  this.end_x;
            arr_end[1] =  this.end_y; 
            Console.WriteLine("Now these values in arrays are ");
            Console.WriteLine("Ending points of line are : ( "+arr_end[0]+" , "+arr_end[1]+")");
        }


    }
    class driver
    {
        static void Main(string[] args)
        {
            int x_1 = 0;
            int y_1 = 0;
            int x_2 = 0;
            int y_2 = 0;
            Console.WriteLine("Enter your starting value of x line : ");
            x_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your starting value of y line : ");
            y_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your starting value of x line : ");
            x_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your starting value of y line : ");
            y_2 = int.Parse(Console.ReadLine());
            points s1 = new points(x_1,y_1,x_2,y_2);
            s1.set_points();
            Console.WriteLine("Enter your starting value of x line : ");
            x_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your starting value of y line : ");
            y_1 = int.Parse(Console.ReadLine());
            s1.getBegin(x_1,y_1);
            s1.setBegin();
            x_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your starting value of y line : ");
            y_2 = int.Parse(Console.ReadLine());
            s1.getEnd(x_2,y_2);
            s1.setEnd();
        }
    }
}
