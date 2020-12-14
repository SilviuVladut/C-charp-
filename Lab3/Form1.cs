using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_3
{
    

    public partial class LPF : Form
    {
        private JucatorForm form2;
        private EchipaForm form3;
        private FormLogin login;
        List<Echipa> listaEchipe;

        public LPF()
        {
            login = new FormLogin();
            login.ShowDialog(this);
            if (login.DialogResult != DialogResult.OK)
                this.Close();
            else
            {
                listaEchipe = new List<Echipa>();
                InitializeComponent();
                InitializeDirectory();
                ReadFiles();
            }
        }

        public void InitializeDirectory()
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\LPF"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\LPF");
            }
        }

        public void ReadFiles()
        {
            string subdir;
            string cnp;
            string[] date_jucator;
            Echipa e;
            Jucator j;
           
            foreach (string dir in Directory.EnumerateDirectories(Path.Combine(Directory.GetCurrentDirectory(), "LPF")))
            {
                e = AdaugaEchipa(new DirectoryInfo(dir).Name);
                subdir = Path.Combine(Directory.GetCurrentDirectory() + "\\", dir).ToString();

                foreach (string file in Directory.EnumerateFiles(subdir, "*.lpf"))
                {
                    cnp = Path.GetFileNameWithoutExtension(subdir + "\\" + file);
                    if (validCNP(cnp) && (existaJucatorul(cnp, e) == null))
                    {
                        date_jucator = System.IO.File.ReadAllLines(Path.Combine(subdir + "\\", file));

                        if (date_jucator.Length >= 2)
                        {
                            j = new Jucator(date_jucator[0], cnp, (Post)Enum.Parse(typeof(Post), date_jucator[1]));
                            ((Echipa)listaEchipe.ElementAt(comboBox1.SelectedIndex)).listaJucatori.Add(j);
                            adaugaButon(j);
                        }
                    }
                }
                refreshButtons();
            }
        }

        public void refreshButtons()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Echipa e = listaEchipe.ElementAt(comboBox1.SelectedIndex);
                flowLayoutPanel1.Controls.Clear();

                foreach (Jucator j in e.listaJucatori)
                {
                    adaugaButon(j);
                }
            }
        }

        public Jucator existaJucatorul(string cnp, Echipa e)
        {
            foreach (Jucator j in e.listaJucatori)
            {
                if (j.getCNP() == cnp)
                    return j;
            }
            return null;
        }

        public Echipa AdaugaEchipa(string nume)
        {
            Echipa e = existaEchipa(nume);
            if (e == null)
            {
                e = new Echipa(nume);
                listaEchipe.Add(e);
                comboBox1.Items.Add(e.nume);
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;

                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory() + "\\LPF\\", nume));
                
            }

            return e;
        }

        public Echipa existaEchipa(string nume)
        {
            if (listaEchipe.Count > 0)
                foreach (Echipa e in listaEchipe)
                {
                    if (nume == e.nume)
                        return e;
                }

            return null;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form3 = new EchipaForm();
            form3.ShowDialog(this);
            if (form3.DialogResult == DialogResult.OK)
            {
                AdaugaEchipa(form3.nume_echipa);

                form3.Dispose();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string datetime = "15.11.1999";
            int zi = int.Parse(datetime.Substring(0, 2));
            int luna = int.Parse(datetime.Substring(3, 2));
            int an = int.Parse(datetime.Substring(6, 4));
            DateTime my_date = new DateTime(an, luna, zi);

            if (listaEchipe.Count > 0)
            {
                string nume, cnp;
                Post post;

                form2 = new JucatorForm();       
                form2.ShowDialog(this);     

                if (form2.DialogResult == DialogResult.OK)
                {
                    nume = form2.getNume();
                    cnp = form2.getCNP();
                    post = form2.getPost();

                    Jucator jucator = new Jucator(nume, cnp, post);
                    ((Echipa)listaEchipe.ElementAt(comboBox1.SelectedIndex)).listaJucatori.Add(jucator);
                    refreshButtons();

                    string nume_echipa = ((Echipa)listaEchipe.ElementAt(comboBox1.SelectedIndex)).nume;
                    AdaugaEchipa(nume_echipa);

                    string file = Directory.GetCurrentDirectory() + "\\LPF\\" + nume_echipa + "\\" + cnp + ".lpf";

                    if (!File.Exists(file))
                    {
                        var fileStream = File.Create(file);
                        fileStream.Close();
                        string[] date = new string[2];
                        date[0] = nume;
                        date[1] = post.ToString();
                        System.IO.File.WriteAllLines(file, date);
                    }
                }

                form2.Dispose();           

                // Cristi e boss 2020
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adaugaButon(Jucator jucator)
        {
            Button btn = new Button();
            btn.Text = jucator.getNume();
            btn.Width = 200;
            btn.Tag = jucator;
            this.flowLayoutPanel1.Controls.Add(btn);
            btn.Click += Btn_Click;
            this.flowLayoutPanel1.Refresh();
        }

        void Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = ((Jucator)((Button)sender).Tag).getNume();
            this.textBox2.Text = ((Jucator)((Button)sender).Tag).getPost();
            this.textBox3.Text = ((Jucator)((Button)sender).Tag).getCNP();
            this.textBox4.Text = ((Jucator)((Button)sender).Tag).getDataNasterii();
            this.textBox5.Text = ((Jucator)((Button)sender).Tag).getVarsta();
        }

        public class Jucator
        {
            private string nume, CNP;
            private DateTime dataNasterii;
            private int varsta;
            private Post post;

            public Jucator(string nume, string CNP, Post post)
            {
                this.nume = nume;
                this.CNP = CNP;
                this.post = post;
                this.dataNasterii = convertCNPtoDateTime(CNP);

                DateTime now = DateTime.Today;
                this.varsta = now.Year - dataNasterii.Year;
                if (dataNasterii > now.AddYears(-varsta))
                    this.varsta--;
            }

            public string getNume()
            {
                return this.nume;
            }

            public string getCNP()
            {
                return this.CNP;
            }

            public string getDataNasterii()
            {
                return this.dataNasterii.ToString("d");
            }

            public string getVarsta()
            {
                return this.varsta.ToString() + " ani";
            }

            public string getPost()
            {
                return post.ToString();
            }

            public DateTime convertCNPtoDateTime(string CNP)
            {
                int an;
                if ("12".Contains(CNP[0]))
                    an = 1900;
                else
                    an = 2000;

                an += int.Parse(CNP.Substring(1, 2));

                int luna = int.Parse(CNP.Substring(3, 2));

                int zi = int.Parse(CNP.Substring(5, 2));

                return new DateTime(an, luna, zi);
            }
        }

        public static bool validCNP(string CNP)
        {
            if (CNP.Length != 13)
                return false;

            if (!"1256".Contains(CNP[0]))
                return false;

            int an;
            if ("12".Contains(CNP[0]))
                an = 1900;
            else
                an = 2000;

            an += int.Parse(CNP.Substring(1, 2));

            int luna = int.Parse(CNP.Substring(3, 2));
            if (luna > 12 || luna < 1)
                return false;

            int zi = int.Parse(CNP.Substring(5, 2));

            int max = DateTime.DaysInMonth(an, luna);

            if (zi > max || zi < 1)
                return false;

            return true;
        }

        public class Echipa
        {
            public string nume;
            public List<Jucator> listaJucatori;

            public Echipa(string nume)
            {
                this.nume = nume;
                listaJucatori = new List<Jucator>();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshButtons();
        }

        private void LPF_Load(object sender, EventArgs e)
        {

        }
    }

    public enum Post
    {
        Portar,
        Fundas,
        Mijlocas,
        Atacant
    }

    
}

        
    

