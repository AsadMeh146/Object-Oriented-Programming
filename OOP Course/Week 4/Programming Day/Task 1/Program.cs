using System;

namespace Task_1
{
    class person
    {
        protected string student_1_name = "";
        protected string student_2_name = "";
        protected string teacher_name = "";
        public person()
        {

        }
        public person(string stu_1,string stu_2,string teach)
        {
          this.student_1_name = stu_1;
          this.student_2_name = stu_2;
          this.teacher_name = teach;
        }
    }
    class student: person
    {
        public student(string stu_1,string stu_2)
        {
          this.student_1_name = stu_1;
          this.student_2_name = stu_2;
        }
        public void get_Student(string stu_1,string stu_2)
        {
          this.student_1_name = stu_1;
          this.student_2_name = stu_2;
        }
        public void set_Student()
        {
            Console.WriteLine(this.student_1_name+" is studying");
            Console.WriteLine(this.student_2_name+" is studying");
        }

    }
    class teacher: person
    {
        public teacher(string teach)
        {
            this.teacher_name = teach;
        }
        public void get_teacher(string teach)
        {
            this.teacher_name = teach;
        }
        public void set_teacher()
        {
            Console.WriteLine(this.teacher_name+" is teaching");
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           string stu_1;
           string stu_2;
           string teach;
           Console.WriteLine("Enter student name : ");
           stu_1 = Console.ReadLine();
           Console.WriteLine("Enter student name : ");
           stu_2 = Console.ReadLine();
           Console.WriteLine("Enter teacher name : ");
           teach = Console.ReadLine();
           person a1 = new person(stu_1,stu_2,teach);
           student s1 = new student(stu_1,stu_2);
           teacher c1 = new teacher(teach);
           s1.get_Student(stu_1,stu_2);
           s1.set_Student();
           c1.get_teacher(teach);
           c1.set_teacher();
           

        }
    }
}
