using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class EchipaForm : Form
    {
        public string nume_echipa;

        public EchipaForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length != 0)
            {
                nume_echipa = textBox1.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
