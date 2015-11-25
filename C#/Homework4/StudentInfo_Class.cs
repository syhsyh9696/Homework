using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12 {
    class StudentInfo_Class {
        public StudentInfo_Class(int x) {
            _length = x;
            _maxcapacity = x;
            _list = new Student[x]; //?Q
        }

        public int  Maxcapacity {
            get { return _maxcapacity; }
        }
        public int Currentlength {
            get { return _length; }
        }
        public int Restlength {
            get { return (_maxcapacity - _length); }
        }

        public Student this[string StudentId] {
            get {
                for(int i = 0; i<_maxcapacity; ++i) {
                    if (_list[i].No == StudentId)
                        return _list[i];
                }
                return null;
            }

            set {
                for(int i = 0; i<_maxcapacity; ++i) {
                    if (_list[i].No == StudentId) {
                        string Tempname;
                        string Tempclass;
                        string Tempscore;

                        Console.WriteLine("Please enter the name of the student: ");
                        Tempname = Console.ReadLine();
                        _list[i].Name = Tempname;

                        Console.WriteLine("Please enter the class of the student: ");
                        Tempclass = Console.ReadLine();
                        _list[i].Class = Tempclass;

                        Console.WriteLine("Please enter the score of the student: ");
                        Tempscore = Console.ReadLine();
                        _list[i].Score = Tempscore;
                    }
                }
            }
        } //end Index function
        
        public Boolean AddInfo() {
            if (_maxcapacity == _length)
                return false;
            else
                return true;
        }

        public Boolean DeleteInfo(string StudentNo) {
            for(int i = 0; i < _maxcapacity; ++i) {
                if (_list[i].No == StudentNo)
                    return true;
            }
            return false;

        }

        private Student[] _list; //?Q
        private int _maxcapacity;
        private int _length;
    }
}
