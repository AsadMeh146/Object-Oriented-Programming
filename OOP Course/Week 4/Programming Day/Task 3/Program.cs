using System;

namespace Task_3
{
    class Shape
    {
       protected string real_color = "";
       protected bool isFilled = true;
       protected string fill = ""; 
      public Shape(string color , bool isFill)
      {
         this.real_color = color;
         this.isFilled = isFill;
      }
      public void getColor(string color)
      {
            this.real_color = color;
      }
      public void setColor()
      {
            Console.WriteLine("The color of shape is : "+real_color);
      }
      public void isShapeFill(bool isFill)
      {
             this.isFilled = isFill;
      }
      public void isShapeFillCheck()
      {
          if(this.isFilled == true)
          {
              this.fill = "Filled";
              Console.WriteLine("The shape is : "+this.fill);
          }
          else
          {
              this.fill = "Not Filled";
              Console.WriteLine("The shape is : "+this.fill);
          }
      }
      public void toString()
      {
          Console.WriteLine("A shape of color "+this.real_color+" is "+this.fill);
      }
    }
    class Circle: Shape
    {
        double radius = 1.0;
        public Circle(double rad)
        {
          this.radius = rad;
        }
        public void getRadius(double rad)
        {
            this.radius = rad;
        }
        public void setRadius()
        {
            Console.WriteLine("The radius of circle : "+this.radius);
        }
        public void getArea()
        {
            double area = 3.14 * (this.radius * this.radius);
            Console.WriteLine("Area of circle is : "+area);
        }
        public void getPerimeter()
        {
            double perimeter = 2 * 3.14 * this.radius;
        }

    }
    class Rectangle: Shape
    {
        double length = 1.0;
        double width = 1.0;
        public Rectangle(double len,double wid)
        {
            this.length = len;
            this.width = wid;
        }
        public void getLength(double len)
        {
            this.length = len;
        }
        public void getWidth(double wid)
        {
            this.width = wid;
        }
        public void setLength()
        {
            Console.WriteLine("The length of rectangle is : "+this.length);
        }
        public void setWidth()
        {
            Console.WriteLine("The width of rectangle is : "+this.width);
        }
        public void getArea_1()
        {
              double area_1 = this.length * this.width;
              Console.WriteLine("The area of rectangle is : "+area_1);
        }
        public void getPerimeter_1()
        {
             double perimeter_1 = 2 * (this.length + this.width);
             Console.WriteLine("The perimeter of rectangle is : "+perimeter_1);

        }

    }
    class driver
    {
        static void Main(string[] args)
        {
            string color ;
            bool isFill = true;
            double rad,len,wid;
            Console.WriteLine("Enter color ");
            color = Console.ReadLine();
            Console.WriteLine("Is filled or not : (Ans in true / false)");
            isFill = bool.Parse(Console.ReadLine());
            Shape s = new Shape(color,isFill);
            Console.WriteLine("Enter the radius of circle : ");
            rad = double.Parse(Console.ReadLine());
            Circle a = new Circle(rad);
            Console.WriteLine("Enter the length of rectangle : ");
            len = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of rectangle : ");
            wid = double.Parse(Console.ReadLine());
            Rectangle p  = new Rectangle(len,wid);
            s.getColor(color);
            s.setColor();
            s.isShapeFill(isFill);
            s.isShapeFillCheck();
            s.toString();
            a.getRadius(rad);
            a.setRadius();
            p.getLength(len);
            p.setLength();
            p.getWidth(wid);
            p.setWidth(); 
            a.getArea();
            a.getPerimeter();
            p.getArea_1();
            p.getPerimeter_1();
        }
    }
}
