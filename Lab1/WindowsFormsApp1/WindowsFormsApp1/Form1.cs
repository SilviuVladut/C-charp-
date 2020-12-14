using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Student> lista = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AfisareLista()
        {
            listStudenti.Items.Clear();
            foreach(Student s in lista)
            {
                listStudenti.Items.Add(s.AfisareStudent());
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            byte[] n = new byte[5];
            try
            {
                n[0] = Convert.ToByte(cmbNota1.Text);
                n[1] = Convert.ToByte(cmbNota2.Text);
                n[2] = Convert.ToByte(cmbNota3.Text);
                n[3] = Convert.ToByte(cmbNota4.Text);
                n[4] = Convert.ToByte(cmbNota5.Text);

                Student s = new Student(Convert.ToByte(cmbAn.Text), n, txtNume.Text, Convert.ToByte(numVarsta.Value));
                lista.Add(s);
                AfisareLista();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnOrdonareNume_Click(object sender, EventArgs e)
        {
            ComparaNume comp = new ComparaNume();
            lista.Sort(comp);
            AfisareLista();
        }

        private void btnCautaNume_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = txtNumeCautare.Text;
                listStudenti.Items.Clear();
                foreach(Student s in lista)
                {
                    if (s.NumeStudent == nume)
                        listStudenti.Items.Add(s.AfisareStudent());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOrdonareMedie_Click(object sender, EventArgs e)
        {
            ComparaMedie com = new ComparaMedie();
            lista.Sort(com);
            AfisareLista();
        }

        private void btnAfisareAn_Click(object sender, EventArgs e)
        {
            try
            {
                string an = cmbAnAfisare.Text;
                listStudenti.Items.Clear();
                foreach(Student s in lista)
                {
                    if((s.AnStudiu).ToString().CompareTo(an)==0)
                    {
                        listStudenti.Items.Add(s.AfisareStudent());
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            int var = listStudenti.SelectedIndex;
            listStudenti.Items.Remove(listStudenti.SelectedItem);
            lista.RemoveAt(var);
        }
    }
}
