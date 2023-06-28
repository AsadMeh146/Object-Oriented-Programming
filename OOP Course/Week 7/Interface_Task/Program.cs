using System;

namespace Interface_Task
{
    interface GeometricObject
    {
      double getPerimeter();
      double getArea();
    }
    class Circle : GeometricObject
    {
        protected double radius = 0;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double getPerimeter()
        {
            return  2 * 3.14 * this.radius;
        }
        public double getArea()
        {
            return  2 * 3.14 * this.radius * this.radius; 
        }
        public void toString()
        {  
            Console.WriteLine("The area of cirle is  "+ getArea() + " and perimeter is "+ getPerimeter());
        }
    }
    interface Resizeable
      {
        void resize(int percent);
      }
    class ResizeableCircle : Circle,Resizeable
    {
        public ResizeableCircle(double radius):base(radius)
        {
            this.radius = radius;
        }
        public void resize(int percent)
        {
            this.radius *= percent / 100.0;
            Console.WriteLine("Resize : "+this.radius);
        }
        public void toString_1()
        {
            Console.WriteLine("The Resizeable circle has radius : "+this.radius);
        }
    }
      
      
    class Driver
    {
        static void Main(string[] args)
        {
            Circle s1 = new Circle(5);
            s1.getArea();
            s1.getPerimeter();
            s1.toString();     
            ResizeableCircle a1 = new ResizeableCircle(10);
            a1.resize(5);            
            a1.toString_1();
            
        }
    }
}
