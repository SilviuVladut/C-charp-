using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form2 : Form
    {
        private string _CNP, _Imagine, _Diagnostic, _Comentarii;
        private DateTime _Data;

        public Form2(string _CNP)
        {
            InitializeComponent();
            CNP = _CNP;
            textBox1.Text = _CNP;
        }

        public string CNP { set => _CNP = value; get => _CNP; }
        public string Imagine { set => _Imagine = value;  get => _Imagine; }
        public string Diagnostic { set => _Diagnostic = value; get => _Diagnostic; }
        public string Comentarii { set => _Comentarii = value; get => _Comentarii; }
        public DateTime Data { set => _Data = value; get => _Data; }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void labelImagine_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Filter = "*.jpg|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Imagine = dlg.FileName;
                textBox2.Text = Imagine;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (validFields())
            {
                CNP = textBox1.Text;
                Data = dateTimePicker1.Value;
                Imagine = textBox2.Text;
                Diagnostic = textBox3.Text;
                Comentarii = textBox4.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool validFields()
        {
            if (textBox3.TextLength > 0 && textBox4.TextLength > 0)
                return true;
            return false; ;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
