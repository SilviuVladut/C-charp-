using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VladutSilviu_Test_07
{

    public partial class Form1 : Form
    {
        private List<Angajat> lista = new List<Angajat>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text;
            string CNP = txtCNP.Text;
            int zileLucrate = int.Parse(txtZileLucrate.Text);
            int salariuZi = int.Parse(txtSalariuZi.Text);
            Departament depart = (Departament)Enum.Parse(typeof(Departament), comboBox1.Text);

            if (comboBox1.Text.CompareTo("HR") == 0)
            {
                Angajat ang = new Angajat(nume, CNP, salariuZi, zileLucrate, depart);
                lista.Add(ang);

                treeView1.Nodes["Node0"].Nodes.Add(ang.GetNume());
            }
            if (comboBox1.Text.CompareTo("IT") == 0)
            {
                Angajat ang = new Angajat(nume, CNP, salariuZi, zileLucrate, depart);
                lista.Add(ang);

                treeView1.Nodes["Node1"].Nodes.Add(ang.GetNume());
            }
            if (comboBox1.Text.CompareTo("Contabilitate") == 0)
            {
                Angajat ang = new Angajat(nume, CNP, salariuZi, zileLucrate, depart);
                lista.Add(ang);

                treeView1.Nodes["Node2"].Nodes.Add(ang.GetNume());
            }
            if (comboBox1.Text.CompareTo("Intretinere") == 0)
            {
                Angajat ang = new Angajat(nume, CNP, salariuZi, zileLucrate, depart);
                lista.Add(ang);

                treeView1.Nodes["Node3"].Nodes.Add(ang.GetNume());
            }




        }

        private void btnCautaNume_Click(object sender, EventArgs e)
        {
            bool check = false;

            foreach (Angajat ang in lista.ToList())
            {
                if (ang.GetNume().CompareTo(txtNumeCautat.Text) == 0)
                {
                    check = true;
                    txtNume.Text = ang.GetNume();
                    txtCNP.Text = ang.getCNP();
                    txtZileLucrate.Text = ang.Zilelucr().ToString();
                    txtSalariuZi.Text = ang.SalZi().ToString();
                    switch (ang.Getdep())
                    {
                        case (Departament)0:
                            comboBox1.SelectedIndex = 0;
                            break;
                        case (Departament)1:
                            comboBox1.SelectedIndex = 1;
                            break;
                        case (Departament)2:
                            comboBox1.SelectedIndex = 2;
                            break;
                        case (Departament)3:
                            comboBox1.SelectedIndex = 3;
                            break;
                    }
                }

            }
            if (check == false)
                MessageBox.Show("Nu am gasit rezultate!");
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {

            treeView1.Nodes.Remove(treeView1.SelectedNode);
            lista.RemoveAt(treeView1.SelectedNode.Index);
        }
        private void txtCNP_Validating(object sender, CancelEventArgs e)
        {
            validCNP(txtCNP.Text);
        }
        public bool validCNP(string CNP)
        {
            bool status = true;
            if (CNP.Length != 13)
            {
                errorProvider1.SetError(txtCNP, "Eroare");
                return false;
               
            }
            

            return status;
        }



        public enum Departament
        {
            HR,
            IT,
            Contabilitate,
            Intretinere
        }
        public class Angajat
        {
            private string nume, CNP;
            private int salariuZi, zileLucrate;
            private Departament depart;

            public Angajat(string nume, string CNP, int salariuZi, int zileLucrate, Departament depart)
            {
                this.nume = nume;
                this.CNP = CNP;
                this.salariuZi = salariuZi;
                this.zileLucrate = zileLucrate;
                this.depart = depart;
            }

            public string GetNume()
            {
                return nume;
            }

            public string getCNP()
            {
                return CNP;
            }
            public int SalZi()
            {
                return salariuZi;
            }
            public int Zilelucr()
            {
                return zileLucrate;
            }
            public Departament Getdep()
            {
                return depart;
            }
        }

        private void btnAdauga_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
