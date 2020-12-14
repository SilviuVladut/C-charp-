using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form3 : Form
    {
        private string _CNP, _Nume, _Adresa;

        public Form3()
        {
            InitializeComponent();
        }

        public string CNP { set => _CNP = value; get => _CNP; }
        public string Nume { set => _Nume = value; get => _Nume; }
        public string Adresa { set => _Adresa = value; get => _Adresa; }

        private void labelAdresa_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (validFields())
            {
                CNP = textBox1.Text;
                Nume = textBox2.Text;
                Adresa = textBox3.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool validFields()
        {
            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0)
                return true;
            return false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
