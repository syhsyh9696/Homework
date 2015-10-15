using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            //string temp;

            //Console.WriteLine("please put in operator, enter 'q' to exit the program.");
            Console.WriteLine("Please input the expression,enter 'q' to exit the program");
            char opr = Convert.ToChar(Console.Read());

            //下面的两行的作用是跳过，按enter键盘后产生的回车和换行两个字符。
            Console.Read();
            Console.Read();

            if (opr != '+' && opr != '-' && opr != '*' && opr != '/')
            {
                Console.WriteLine("You have enter a fault operator ");
                //Console.WriteLine("exit");
                return;
            }

            int tc = 0; //做的题目数
            int rc = 0;//正确的题目数
            int wc = 0;//错误的题目数


            while (opr != 'q')
            {
                /*
                Console.WriteLine("please put num1");
                temp = Console.ReadLine();       

                a = int.Parse(temp);
                Console.WriteLine("please put num2");
                temp = Console.ReadLine();
                b = int.Parse(temp);

                Console.Write("{0} {1} {2} = ", a, opr, b);
                //{}的意思是表示第几项第几项，可以用来格式化输入输出。
                //Write和WriteLine的区别是 Write输出之后不换行，Writeline输出之后换行

                //接收输入的答案
                temp = Console.ReadLine();
                int ans = int.Parse(temp);
                */
                if (opr != '+' && opr != '-' && opr != '*' && opr != '/')
                {
                    Console.WriteLine("You have enter a fault operator ");
                    //Console.WriteLine("exit");
                    return;
                }
                string temp;


                Console.WriteLine("Please enter the expression");
                Console.WriteLine("For example: '1+2=3'");
                temp = Console.ReadLine();

                //拆分string
                char[] delimiterChars = {'+', '=', '*', '/', '-' };
                string[] words = temp.Split(delimiterChars);

                a = int.Parse(words[0]);
                b = int.Parse(words[1]);
                int ans = int.Parse(words[2]);




                //实际结果
                int rst = 0;
                if (opr == '+') rst = a + b;
                if (opr == '-') rst = a - b;
                if (opr == '*') rst = a * b;
                if (opr == '/') rst = a / b;

                //判断正误
                if (ans == rst)
                {
                    Console.WriteLine("you are right!");
                    rc++;
                }
                else
                {
                    Console.WriteLine("Sorry, you are wrong!");
                    wc++;
                }

                tc++;

                Console.WriteLine("please put in operator");
                opr = Convert.ToChar(Console.Read());
                Console.Read();
                Console.Read();
            }
            Console.WriteLine("you have done {0} problems. right:{1}, wrong:{2}", tc, rc, wc);
        }
    }
}

