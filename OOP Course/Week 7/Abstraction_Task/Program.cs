using System;
using System.Collections;
namespace Abstraction_Task
{
    abstract class course
    {
        public virtual string setGrade()
        {
            return "Undefined";
        }
        public virtual string setName()
        {
            return "Undefined";
        }
        public abstract string course_pass();

    }
    class absoluteGradedCourse : course
    {
        string real_course_name;
        int real_course_marks;
        string real_course_grade;
        public absoluteGradedCourse(string course_name, int course_marks, string course_grade)
        {
            this.real_course_name = course_name;
            this.real_course_marks = course_marks;
            this.real_course_grade = course_grade;
        }
        public void getName(string course_name)
        {
            this.real_course_name = course_name;
        }
        public override string setName()
        {
            return this.real_course_name;
        }
        public void getGrade(string course_grade)
        {
            this.real_course_grade = course_grade;
        }
        public override string setGrade()
        {
            return this.real_course_grade;
        }
        public void getMarks(int course_marks)
        {
            this.real_course_marks = course_marks;
        }
        public int setMarks()
        {
            return this.real_course_marks;
        }
        public override string course_pass()
        {
            if(real_course_grade == "F")
            {
               return "Failed";
            }
            else
            {
                return "Passed";
            }
        }
        
    }
    class GradedCourse : course
    {
        string real_course_name;
        int real_course_marks;
        string real_course_grade;
        
        public GradedCourse(string course_name, int course_marks,string course_grade)
        {
            this.real_course_name = course_name;
            this.real_course_marks = course_marks;
            this.real_course_grade = course_grade;
        }
        public void getName(string course_name)
        {
            this.real_course_name = course_name;
        }
        public override string setName()
        {
            return this.real_course_name;
        }
        public void getGrade(string course_grade)
        {
            this.real_course_grade = course_grade;
        }
        public override string setGrade()
        {
            return this.real_course_grade;
        }
        public override string course_pass()
        {
            if(real_course_grade == "2" || real_course_grade == "0")
            {
               return "Failed";
            }
            else 
            {
                return "Passed";
            }
            
        }
    }
    class Driver
    {
        static ArrayList data = new ArrayList();
        static void Main(string[] args)
        {
            string course_name;
            int course_marks;
            string course_grade;
            int counter = 0;
            Console.WriteLine("Enter course name : ");
            course_name = Console.ReadLine();
            Console.WriteLine("Enter course marks : ");
            course_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your course grade : ");
            course_grade = Console.ReadLine();   
            absoluteGradedCourse s1 = new absoluteGradedCourse(course_name,course_marks,course_grade);
            Console.WriteLine("Enter course name : ");
            course_name = Console.ReadLine();
            Console.WriteLine("Enter course marks : ");
            course_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your course grade : ");
            course_grade = Console.ReadLine();   
            absoluteGradedCourse s2 = new absoluteGradedCourse(course_name,course_marks,course_grade);
            Console.WriteLine("Enter course name : ");
            course_name = Console.ReadLine();
            Console.WriteLine("Enter your course grade : ");
            course_grade = Console.ReadLine();   
            GradedCourse d1 = new GradedCourse(course_name,course_marks,course_grade);
            Console.WriteLine("Enter course name : ");
            course_name = Console.ReadLine();
            Console.WriteLine("Enter your course grade : ");
            course_grade = Console.ReadLine();   
            GradedCourse d2 = new GradedCourse(course_name,course_marks,course_grade); 
            data.Add(s1);
            data.Add(s2);
            data.Add(d1);
            data.Add(d2);    
            for (int x = 0; x < data.Count; x++)
            {
                course a = (course)data[x];
                Console.WriteLine(x + 1 + ". THE COURSE OF " + a.setName() + " IS  " + a.course_pass() + "BY " + a.setGrade() + " GRADE ");
                if(a.course_pass() == "Passed")
                {
                    counter++;
                }  
            }
            if(counter == 3)
            {
                Console.WriteLine("Student is passed ");
            } 
            else
            {
                Console.WriteLine("Student is failed ");
            }   
        }
    }
}
