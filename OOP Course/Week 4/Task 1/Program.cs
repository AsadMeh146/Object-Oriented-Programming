using System;

namespace Task_1
{
    class angle
    {
        int degree = 0;
        float minute = 0;
        char direction ;
        int real_degree = 0;
        float real_minute = 0;
        char real_direction ;

        public angle()
        {
        }

        public angle(int degree, float minute, char letter)
        {
            this.degree = degree;
            this.minute = minute;
            this.direction = letter;
        }

        public void set_angle(int degree, float minute, char letter)
        {
            this.real_degree = degree;
            this.real_minute = minute;
            this.real_direction = letter;
        }

        public void get_angle()
        {
            Console.WriteLine(this.degree + "\x00B0" + this.minute + "`" + this.direction);
        }
        public void get_angle_1()
        {
            Console.WriteLine(this.real_degree + "\x00B0" + this.real_minute + "`" + this.real_direction);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int degree_1 = 0;
            float minute_1 = 0;
            char direction_1;
            angle s2 = new angle();
            Console.Write("Enter your angle:");
            degree_1 = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes:");
            minute_1 = float.Parse(Console.ReadLine());
            Console.Write("Enter  your direction:");
            direction_1 = char.Parse(Console.ReadLine());
            angle s1 = new angle(degree_1,minute_1,direction_1);
            s1.get_angle();
            Console.Write("Enter your range :");
            int range = int.Parse(Console.ReadLine());
            for (int i = 0; i < range; i++)
            {
                Console.Write("Enter your angle:");
                degree_1 = int.Parse(Console.ReadLine());
                Console.Write("Enter minutes:");
                minute_1 = float.Parse(Console.ReadLine());
                Console.Write("Enter  your direction:");
                direction_1 = char.Parse(Console.ReadLine());
                
                s2.set_angle(degree_1, minute_1, direction_1);
                s2.get_angle_1();
            }
        }
    }
}
