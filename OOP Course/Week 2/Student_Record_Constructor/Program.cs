using System;

namespace Student_Record_Constructor
{
    class Student
    {
        Student(string name,string rollno)
        { 
           sname = name;
           srollno = rollno;  
        }
        string sname = "";
        string srollno = "";
        float sgpa = 0;
        string shostalide = "";
        string sdepart = "";
        static Student addstudent()
        {
           string name,rollno;
           Console.WriteLine("Enter your name : ");
           name = Console.ReadLine();
           Console.WriteLine("Enter your roll no : ");
           rollno = Console.ReadLine();
           Student s = new Student(name,rollno);
           Console.WriteLine("Enter student gpa : ");
           s.sgpa = float.Parse(Console.ReadLine());
           Console.WriteLine("Is student hostalide : ");
           s.shostalide = Console.ReadLine();
           Console.WriteLine("Enter student department name : ");
           s.sdepart = Console.ReadLine();
           return s;  
        }
        static void viewstudents(Student [] s1,int i)
        {
           for(int j=0;j<i;j++)
           {
               Console.WriteLine(s1[j].sname+"\t"+s1[j].srollno+"\t"+s1[j].sgpa+"\t"+s1[j].shostalide+"\t"+s1[j].sdepart);
           }
        }
        static void showthetop(Student [] s1,int i )
        {
            float largest = s1[0].sgpa;
	        for (int idx=1;idx<i;idx++){
		    if(s1[idx].sgpa>largest){
			largest=s1[idx].sgpa;
		}
	    }
         Console.WriteLine("The top student numbers are : "+largest);  
        }
        static void Main(string[] args)
        {
               
            Student [] s1 = new Student[5];
            int i=0;
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
                    s1[i] = addstudent();
                    i++;
                    Console.ReadLine();
                    Console.Clear();
                }
                if(option==2)
                {
                    Console.WriteLine("Student name"+"\t"+"Student roll no"+"\t"+"Student gpa"+"\t"+"Student Hostelide"+"\t"+"Student Department");
                    viewstudents(s1,i);
                    Console.ReadLine();
                    Console.Clear();
                }
                if(option==3)
                {
                    showthetop(s1,i);
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }
    }
}
