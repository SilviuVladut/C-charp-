using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Persoana
    {
        protected string nume;
        protected byte varsta;

        public Persoana(string nume, byte varsta)
        {
            this.nume = nume;
            this.varsta = varsta;
        }
    }
}
