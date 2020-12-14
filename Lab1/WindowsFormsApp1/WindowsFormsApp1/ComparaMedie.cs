using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.CodeAnalysis;

namespace WindowsFormsApp1
{
    class ComparaMedie : IComparer<Student>
    {
        public int Compare(Student x,Student y)
        {
            if (x.Medie() < y.Medie())
            {
                return 1;
            }
            else if (x.Medie() == y.Medie())
            {
                return 0;
            }
            else return -1;
        }
    }
}
