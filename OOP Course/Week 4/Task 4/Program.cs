using System;

namespace Task_4
{
    class Circle
    {
        protected double radius = 1.0;
        protected string color = "Red";
        protected double area = 0.0;
        public Circle()
        {

        }
        public Circle(string col , double rad)
        {
           this.color = col;
           this.radius = rad;
        }
        public void getColor(string col)
        {
            this.color = col;
        }
        public void setColor()
        {
            Console.WriteLine("The color of circle is : "+this.color);
        }
        public void getRadius(double rad)
        {
            this.radius = rad;
        }
        public void setRadius()
        {
            Console.WriteLine("The radius of circle is : "+this.radius);
        }
        public void toString()
        {
            Console.WriteLine("The color of circle is "+this.color.ToString()+" and radius is : "+this.radius.ToString());
        }
        public void Area()
        {
            this.area = 3.14 * (this.radius * this.radius);
            Console.WriteLine("Area of circle is : "+this.area);
        }
        public double Area_1()
        {
            return this.area;
        } 
    }
    class Cylinder: Circle
    {
        double heigth = 0.0;
        double volume = 1.0;
        public Cylinder()
        {

        }
        public Cylinder(double hei,double rad)
        {
            this.radius = rad;
            this.heigth = hei; 
        }
        public void getHeight(double hei)
        {
            this.heigth = hei;
        }
        public void setHeight()
        {
            Console.WriteLine("Your height of cylinder : "+this.heigth);
        }
        public void Volume()
        {
           volume = 3.14 * (this.radius * this.radius * this.heigth);
           Console.WriteLine("Volume of cylinder is : "+volume);
        }
    }
    class driver
    {
      static void Main(string[] args)
        {
           string col;
           double rad;
           double hei;
           Console.WriteLine("Enter the color of circle : ");
           col = Console.ReadLine();
           Console.WriteLine("Enter the radius of circle : ");
           rad = double.Parse(Console.ReadLine());
           Circle s1 = new Circle(col,rad);
           Console.WriteLine("Enter the height of cylinder : ");
           hei = double.Parse(Console.ReadLine());
           Cylinder c1 = new Cylinder(hei,rad);
           s1.getColor(col);
           s1.setColor();
           s1.getRadius(rad);
           s1.setRadius();
           c1.getHeight(hei);
           c1.setHeight();
           s1.toString();
           s1.Area();
           c1.Volume();         
        }
    }
    }    
