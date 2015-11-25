using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12 {
    class Student {
        public Student(string No, string Name, string Class, string Score) {
            No = _no;
            Name = _name;
            Class = _class;
            Score = _score;
        } //end constructor

        public string No {
            set { _no = value; }
            get { return _no; }
        }
        public string Name {
            set { _name = value; }
            get { return _name; }
        }
        public string Class {
            set { _class = value; }
            get { return _class; }
        }
        public string Score {
            set { _score = value; }
            get { return _score; }
        }

        //data 
        private string _no;
        private string _name;
        private string _class;
        private string _score;

    }//end Student class

}
