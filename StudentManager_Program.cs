using System;
using System.Collections.Generic;

namespace StudentManager
{
    enum School
    {
        HsOne,
        HsTwo,
        HsThree
        
    }
    
    class Program
    {
        static  List<Student>students = new List<Student>();
        
        static void Main(string[] args)
        {
            PayRoll payRoll = new PayRoll();
            payRoll.PayAll();
            
            var adding = true;
            
            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");

                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");

                    newStudent.School = (School)Util.Console.AskInt("School Name: (type the corresponding number): \n 0: HS One \n 1: HS Two \n 2: HS Three \n");

                    newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                    newStudent.Address = Util.Console.Ask("Student Address: ");

                    newStudent.Phone = Util.Console.AskInt("Student Phone Number: ");

                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student Count: {0}", Student.Count);

                    Util.Console.Ask("Add another? y/n \n");

                    if (Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error adding student, Please try again.");
                }
                
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
            Exports();
        }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "birthday", "address", 123456);
            Console.WriteLine(importedStudent.Name);
        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case School.HsOne:
                        Console.WriteLine("Exporting to HS One");
                        break;
                    case School.HsTwo:
                        Console.WriteLine("Exporting to HS Two");
                        break;
                    case School.HsThree:
                        Console.WriteLine("Exporting to HS Three");
                        break;
                }
            }
        }
    }

    public class Member
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }
    
    class Student : Member
    {
        static public int Count { get; set; } = 0;
        
        
        public int Grade { get; set; }
        public string Birthday { get; set; }
        public School School { get; set; }
        

        public Student()
        {
            
        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }
}
