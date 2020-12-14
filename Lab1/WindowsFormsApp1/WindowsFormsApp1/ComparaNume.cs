using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WindowsFormsApp1
{
    class ComparaNume:IComparer<Student>
    {
        public int Compare(Student x, Student y) 
        {
            return string.Compare(x.NumeStudent, y.NumeStudent);
        }
    }
}
