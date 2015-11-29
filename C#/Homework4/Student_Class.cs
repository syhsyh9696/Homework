using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12 {
    class Student                        //Student类
    {
        private int _no;
        private string _name;
        private string _class;
        private double _score;

        public int No {
            get { return _no; }
            set { _no = value; }
        }

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public string Class {
            get { return _class; }
            set { _class = value; }
        }

        public double Score {
            get { return _score; }
            set { _score = value; }
        }
        public Student(int no, string na, string cl, double sc) //constructor
        {
            _no = no;
            _name = na;
            _class = cl;
            _score = sc;
        }

    }
}
