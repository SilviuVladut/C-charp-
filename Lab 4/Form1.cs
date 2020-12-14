using Microsoft.Win32;
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

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refreshDataBase();
            refreshFlowLayoutPanelRadiografii();
        }

        private void refreshDataBase()
        {
            tableAdapterManager.UpdateAll(pacientiDataSet);
            radiografiiTableAdapter.Fill(pacientiDataSet.Radiografii);
            pacientiTableAdapter.Fill(pacientiDataSet.Pacienti);
            refreshFlowLayoutPanelRadiografii();
        }

        private void refreshFlowLayoutPanelRadiografii()
        {
            flowLayoutPanelRadiografii.Controls.Clear();

            if (pacientiDataGridView.SelectedRows.Count > 0 && pacientiDataGridView.SelectedRows[0].Cells[0].Value != null)
            {
                PictureBox pic;

                foreach (DataRowView drv in radiografiiBindingSource.List)
                {
                    string img = (string)drv["Imagine"];
                    string cnp = (string)drv["CNP"];

                    if (File.Exists(img) && (cnp.Equals(pacientiDataGridView.SelectedRows[0].Cells[0].Value.ToString())))
                    {
                        pic = new PictureBox();
                        pic.SetBounds(0, 0, 170, 170);
                        pic.BackColor = Color.Black;
                        pic.SizeMode = PictureBoxSizeMode.Zoom;
                        pic.Image = Bitmap.FromFile(img);
                        pic.Tag = "Data: " + ((DateTime)drv["Data"]).ToString() + "\n";
                        pic.Tag += "Diagnostic: " + ((string)drv["Diagnostic"]) + "\n";
                        pic.Tag += "Comentarii: " + ((string)drv["Comentarii"]) + "\n";
                        flowLayoutPanelRadiografii.Controls.Add(pic);
                        pic.Click += new System.EventHandler(pic_Click);
                    }
                }
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pic in flowLayoutPanelRadiografii.Controls)
            {
                if (((PictureBox)sender).Image == pic.Image)
                    pic.BorderStyle = BorderStyle.Fixed3D;
                else
                    pic.BorderStyle = BorderStyle.None;
            }

            pictureBoxRadiografie.Image = ((PictureBox)sender).Image;
            pictureBoxRadiografie.SizeMode = PictureBoxSizeMode.Zoom;
            richTextBoxDescriere.Clear();
            richTextBoxDescriere.Text = (string)((PictureBox)sender).Tag;
        }

        private void pacientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pacientiDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pacientiDataSet.Radiografii' table. You can move, or remove it, as needed.
            this.radiografiiTableAdapter.Fill(this.pacientiDataSet.Radiografii);
            // TODO: This line of code loads data into the 'pacientiDataSet.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.pacientiDataSet.Pacienti);

        }

        private void pacientiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pacientiBindingSource_PositionChanged(object sender, EventArgs e)
        {

        }

        private void pacientiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdaugaRadiografie_Click(object sender, EventArgs e)
        {
            if (pacientiDataGridView.SelectedRows.Count > 0 && pacientiDataGridView.SelectedRows[0].Cells[0].Value != null)
            {
                Form2 f = new Form2(pacientiDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                if (f.ShowDialog() == DialogResult.OK)
                {
                    radiografiiTableAdapter.Insert(f.CNP, f.Imagine, f.Data, f.Diagnostic, f.Comentarii);
                    tableAdapterManager.UpdateAll(pacientiDataSet);
                    radiografiiTableAdapter.Fill(pacientiDataSet.Radiografii);
                    pacientiTableAdapter.Fill(pacientiDataSet.Pacienti);
                    refreshFlowLayoutPanelRadiografii();
                }
            }
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientiBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(pacientiDataSet);
            radiografiiTableAdapter.Fill(pacientiDataSet.Radiografii);
            pacientiTableAdapter.Fill(pacientiDataSet.Pacienti);
            refreshFlowLayoutPanelRadiografii();
        }
            

        private void textBoxCautare_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCautare.TextLength == 0)
                pacientiBindingSource.RemoveFilter();
            else
            {
                pacientiBindingSource.Filter = "Nume like '" + textBoxCautare.Text + "%'";

            }
        }

        private void buttonAdaugaPacient_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();

            if (f.ShowDialog() == DialogResult.OK)
            {
                pacientiTableAdapter.Insert(f.CNP, f.Nume, f.Adresa);
                tableAdapterManager.UpdateAll(pacientiDataSet);
                pacientiTableAdapter.Fill(pacientiDataSet.Pacienti);
                refreshFlowLayoutPanelRadiografii();
            }
        }

        private void buttonEraseDatabase_Click(object sender, EventArgs e)
        {
            foreach (DataRowView drv in radiografiiBindingSource.List)
            {
                drv.Delete();
            }
            foreach (DataRowView p in pacientiBindingSource.List)
            {
                p.Delete();
            }
            pictureBoxRadiografie.Image = null;
            richTextBoxDescriere.Clear();
            refreshDataBase();
            refreshFlowLayoutPanelRadiografii();
        }

        private void flowLayoutPanelRadiografii_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pacientiDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            refreshFlowLayoutPanelRadiografii();
        }
    }
}
