using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class JucatorForm : Form
    {
        private string nume, cnp;
        private Post post;
        ErrorProvider errorProvider1 = new ErrorProvider();
        ErrorProvider errorProvider2 = new ErrorProvider();
        ErrorProvider errorProvider3 = new ErrorProvider();

        public JucatorForm()
        {
            InitializeComponent();
        }

        public string getNume()
        {
            return nume;
        }

        public string getCNP()
        {
            return cnp;
        }

        public Post getPost()
        {
            return post;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validFields())
            {
                this.nume = textBox1.Text;
                this.post = (Post)Enum.Parse(typeof(Post), comboBox1.Text);
                this.cnp = textBox2.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifica datele introduse!", "Campurile nu sunt valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && ((Keys)e.KeyChar != Keys.Back))
                e.Handled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validFields()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();

            bool message = true;
            
            if (textBox1.Text.Replace(" ", "").Length < 1)
            {
                errorProvider1.SetError(this.textBox1, "Numele trebuie completat");
                message = false;
            }

            if (!LPF.validCNP(textBox2.Text))
            {
                errorProvider2.SetError(this.textBox2, "CNP-ul nu este valid");
                message = false;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                errorProvider3.SetError(this.comboBox1, "Alegeti o optiune");
                message = false;
            }

            return message;
        }

        private void JucatorForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }

    
}
