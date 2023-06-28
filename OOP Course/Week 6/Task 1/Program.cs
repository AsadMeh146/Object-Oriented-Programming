using System;
using System.Collections;
namespace Task_1
{
    class Shape
    {
        public Shape()
        {

        }
        public virtual double getArea()
        {
            return 0;
        }
        public virtual string getShapeType()
        {
            return "Undefined";
        }
        public virtual void getWidth(int width)
        {
    
        }
        public virtual void getHeight(int height)
        {
           
        } 

    }
    class Circle : Shape
    {
        public int radius = 0;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            double area = 0;
            area = 2 * Math.Pow(radius,2) * Math.PI;
            return area;
        }
        public override string getShapeType()
        {
            return "Circle";
        }
    }
    class Rectangle : Shape
    {
        public int width = 0;
        public int height = 0;
        public Rectangle(int width,int height)
        {
            this.width = width;
            this.height = height;
        }
        public override void getWidth(int width)
        {
            this.width = width;
        }
        public override void getHeight(int height)
        {
            this.height = height;
        }
        public override double getArea()
        {
            return width * height;
        }
        public override string getShapeType()
        {
            return "Rectangle";
        }
    }
    class Triangle : Shape
    {
        public int side_1 = 0;
        public int side_2 = 0;
        public int side_3 = 0;
        public Triangle(int side_1,int side_2,int side_3)
        {
            this.side_1 = side_1;
            this.side_2 = side_2;
            this.side_3 = side_3;
        }
        public override double getArea()
        {
            return this.side_1 * this.side_2 * this.side_3;
        }
        public override string getShapeType()
        {
            return "Triangle";
        }

    }
    class Driver
    {
        static void createShape()
        {
            Rectangle r1 = new Rectangle(10,20);
            Rectangle r2 = new Rectangle(5,15);
            Rectangle r3 = new Rectangle(10,30);
            shape.Add(r1);
            shape.Add(r2);
            shape.Add(r3);
        }
        static void getArea()
        {
            for(int i=0;i<shape.Count;i++)
            {
                Shape s = (Shape)shape[i];
                Console.WriteLine(i + " : The Shape is " + s.getShapeType() + " and its area is " + s.getArea());
            }
        }
        static ArrayList shape = new ArrayList();
        static void Main(string[] args)
        {
            int option = 0;
            int check_index = 0;
            int change_width = 0;
            int change_height = 0;
            createShape();
            while(option!=3)
            {
                Console.WriteLine("1. Change the parameters ");
                Console.WriteLine("2. Show the shape and area ");
                Console.WriteLine("3. Exit ");
                Console.WriteLine("Enter your option : ");
                option = int.Parse(Console.ReadLine());
                if(option == 1)
                {
                    Console.Clear();
                    getArea();
                    Console.WriteLine("Pick the value : ");
                    check_index = int.Parse(Console.ReadLine());
                    Shape p = (Shape)shape[check_index];
                    Console.WriteLine("Enter your new height : ");
                    change_height = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your new width : ");
                    change_width = int.Parse(Console.ReadLine());
                    p.getWidth(change_width);
                    p.getHeight(change_height);   
                }
                if(option == 2)
                {
                    Console.Clear();
                    getArea();
                    Console.ReadLine();
                    Console.Clear();
                }

            }
        }
    }
}
