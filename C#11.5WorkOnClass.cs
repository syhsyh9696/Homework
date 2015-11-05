using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class student
    {
        public student(string _no, string _name, string _class, float _score) //constructor
        {
            No = _no;
            Name = _name;
            Class = _class;
            Score = _score;
        } //end constructor

        public void input(  )
        {
            float i; // Template store the score
            Console.WriteLine("Please enter the score of the student {0},No.{1}", Name, No);
            i = float.Parse(Console.ReadLine());
            Score = i;
            Console.WriteLine("Done!");
        }

        public void output()
        {
             // Console.WriteLine("No.\t Name\t Class\t Score\t ");
            Console.WriteLine("{0,-9}{1,-9}{2,-9}{3,-9}", No, Name, Class, Score);
        }

        private string No; //number of the student 
        private string Name; // name of the student
        private string Class;
        private float Score; //student score
    }
    
    class Program
    {
        static void Main()
        {
            student stu1 = new student("1", "John", "1", 60);
            student stu2 = new student("2", "Johnson", "2", 70);
            student stu3 = new student("3", "Mark", "2", 80);

            stu1.input();
            Console.WriteLine("\nNo.\t Name\t Class\t Score\t  ");
            stu1.output();
            stu2.output();
            stu3.output();
        }
    }
}
