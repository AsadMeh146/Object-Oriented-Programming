using System;

namespace Student_Record
{
    class student
    {
        public string sname = "";
        public string srollno = "";
        public float sgpa = 0;
        public string shostalide = "";
        public string sdepart = "";

        static void addstudent(student s)
        {
           Console.WriteLine("Enter student name : ");
           s.sname = Console.ReadLine();
           Console.WriteLine("Enter student roll no : ");
           s.srollno = Console.ReadLine();
           Console.WriteLine("Enter student gpa : ");
           s.sgpa = float.Parse(Console.ReadLine());
           Console.WriteLine("Is student hostalide : ");
           s.shostalide = Console.ReadLine();
           Console.WriteLine("Enter student department name : ");
           s.sdepart = Console.ReadLine();  
        }
        static void viewstudents(student s)
        {
          Console.WriteLine(s.sname+"\t"+s.srollno+"\t"+s.sgpa+"\t"+s.shostalide+"\t"+s.sdepart); 
        }
        static void showthetop(student s1,student s2,student s3)
        {
            if(s1.sgpa>s2.sgpa && s1.sgpa>s3.sgpa)
            {
                Console.WriteLine(s1.sname+" has the highest marks ");
            }
            else if(s2.sgpa>s1.sgpa && s2.sgpa>s3.sgpa)
            {
                Console.WriteLine(s2.sname+" has the highest marks ");
            }
            else if(s3.sgpa>s2.sgpa && s3.sgpa>s1.sgpa)
            {
                Console.WriteLine(s3.sname+" has the highest marks ");
            }
        }
        static void Main(string[] args)
        {
            student s1 = new student();
            student s2 = new student();
            student s3 = new student();
            int option = 0;
            while(option!=4)
            {
                Console.WriteLine("Enter students information ");
                Console.WriteLine("Display students information ");
                Console.WriteLine("Show the top student ");
                Console.WriteLine("Exit ");
                Console.WriteLine("Enter your option : ");
                option = int.Parse(Console.ReadLine());
                if(option==1)
                {
                    addstudent(s1);
                    addstudent(s2);
                    addstudent(s3);
                    Console.ReadLine();
                    Console.Clear();
                }
                if(option==2)
                {
                    Console.WriteLine("Student name"+"\t"+"Student roll no"+"\t"+"Student gpa"+"\t"+"Student Hostelide"+"\t"+"Student Department");
                    viewstudents(s1);
                    viewstudents(s2);
                    viewstudents(s3);
                    Console.ReadLine();
                    Console.Clear();
                }
                if(option==3)
                {
                    showthetop(s1,s2,s3);
                    Console.Clear();
                }
            }
        }
    }
}
