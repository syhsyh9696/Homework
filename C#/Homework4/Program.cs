using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program {
        static void Main(string[] args) {
            StudentInfo _s1=new StudentInfo(10);
            Student s1 = new Student(23, "Jack", "class1", 21);
            Student s2 = new Student(45, "John", "class1", 78);
            Student s3 = new Student(67, "Lucy", "class2", 98);
            _s1.AddInfo(s1);
            _s1.AddInfo(s2);
            _s1.AddInfo(s3);
            Console.WriteLine("添加三个学生信息后\n");
            Console.WriteLine("最大值为：{0}",_s1.Maxcapacity);
            Console.WriteLine("已存信息容量为：{0}",_s1.Currentlength);
            Console.WriteLine("剩余容量为：{0}",_s1.Restlength);
            for (int i = 0; i < _s1.Currentlength;i++ )
                Console.WriteLine("学生{0}的学号：{1}，姓名：{2}，班级：{3}，成绩：{4}",i+1, _s1[i].No, _s1[i].Name,_s1[i].Class,_s1[i].Score);
            Console.WriteLine("\n");
            Console.WriteLine("将John删除");
            _s1.DeleteInfo(s2);
            Console.WriteLine("最大值为：{0}", _s1.Maxcapacity);
            Console.WriteLine("已存信息容量为：{0}", _s1.Currentlength);
            Console.WriteLine("剩余容量为：{0}", _s1.Restlength);
            for (int i = 0; i < _s1.Currentlength; i++)
                Console.WriteLine("学生{0}的学号：{1}，姓名：{2}，班级：{3}，成绩：{4}", i + 1, _s1[i].No, _s1[i].Name, _s1[i].Class, _s1[i].Score);
        }
    }
}
