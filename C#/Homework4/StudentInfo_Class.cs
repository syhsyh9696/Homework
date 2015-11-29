using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12 {
         internal class StudentInfo  {
            private Student[] _list;
            private int _maxcapacity;
            private int _length;

            public int Maxcapacity               
            {
                get { return _maxcapacity; }
            }
            public int Currentlength             
            {
                get { return _length; }
            }
            public int Restlength             
            {
                get { return _maxcapacity - _length; }
            }
            public StudentInfo(int maxcapacity)
            {
                this._maxcapacity = maxcapacity;
                _list = new Student[maxcapacity];
            }
            public Student this[int index]
            {
                get {
                    if (index < _length) {
                        return _list[index];
                    }
                    throw new IndexOutOfRangeException();
                }
                set {
                    if (index < _length) {
                        _list[index] = value;
                    }
                    throw new IndexOutOfRangeException();
                }
            }
            public bool AddInfo(Student s)
            {
                if (Restlength == 0) {
                    return false;
                }
                _list[_length] = s;
                _length++;
                return true;
            }
            public bool DeleteInfo(Student s)
            {
                int index = 0;
                while (index < _length) {
                    if (_list[index] == s) { break; }
                    index++;
                }
                if (index == _length) { return false; }
                while ((index + 1) < _length) {
                    _list[index] = _list[index + 1];
                    index++;
                }
                _list[index] = null;
                _length--;
                return true;
            }
        }
    }
