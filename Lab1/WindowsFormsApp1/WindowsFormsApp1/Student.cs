using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Student:Persoana
    {
        private byte an;
        private byte[] note = new byte[5];

        public byte AnStudiu
        {
            get { return an;  }
        }
        
        public string NumeStudent
        {
            get { return nume; }
        }

        public Student(byte an, byte[] note, string nume, byte varsta) : base(nume, varsta)
        {
            this.an = an;
            this.note = note;
        }

        public float Medie()
        {
            float m = 0;
            foreach(byte n in note)
            {
                m = m + n;
            }
            return m / 5;
        }

        public string AfisareStudent()
        {
            return nume + "," + varsta + "ani, anul: " + an + ",media: " + Medie();
        }
    }
}
