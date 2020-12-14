namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.numVarsta = new System.Windows.Forms.NumericUpDown();
            this.cmbAn = new System.Windows.Forms.ComboBox();
            this.cmbNota1 = new System.Windows.Forms.ComboBox();
            this.cmbNota2 = new System.Windows.Forms.ComboBox();
            this.cmbNota3 = new System.Windows.Forms.ComboBox();
            this.cmbNota4 = new System.Windows.Forms.ComboBox();
            this.cmbNota5 = new System.Windows.Forms.ComboBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbAnAfisare = new System.Windows.Forms.ComboBox();
            this.txtNumeCautare = new System.Windows.Forms.TextBox();
            this.btnCautaNume = new System.Windows.Forms.Button();
            this.btnAfisareAn = new System.Windows.Forms.Button();
            this.btnOrdonareMedie = new System.Windows.Forms.Button();
            this.btnOrdonareNume = new System.Windows.Forms.Button();
            this.listStudenti = new System.Windows.Forms.ListBox();
            this.btnSterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numVarsta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Varsta:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "An:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Note:";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(83, 39);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(171, 27);
            this.txtNume.TabIndex = 5;
            // 
            // numVarsta
            // 
            this.numVarsta.Location = new System.Drawing.Point(83, 87);
            this.numVarsta.Name = "numVarsta";
            this.numVarsta.Size = new System.Drawing.Size(62, 27);
            this.numVarsta.TabIndex = 6;
            this.numVarsta.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // cmbAn
            // 
            this.cmbAn.FormattingEnabled = true;
            this.cmbAn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbAn.Location = new System.Drawing.Point(83, 130);
            this.cmbAn.Name = "cmbAn";
            this.cmbAn.Size = new System.Drawing.Size(151, 28);
            this.cmbAn.TabIndex = 7;
            // 
            // cmbNota1
            // 
            this.cmbNota1.FormattingEnabled = true;
            this.cmbNota1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNota1.Location = new System.Drawing.Point(83, 179);
            this.cmbNota1.Name = "cmbNota1";
            this.cmbNota1.Size = new System.Drawing.Size(50, 28);
            this.cmbNota1.TabIndex = 8;
            // 
            // cmbNota2
            // 
            this.cmbNota2.FormattingEnabled = true;
            this.cmbNota2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNota2.Location = new System.Drawing.Point(139, 179);
            this.cmbNota2.Name = "cmbNota2";
            this.cmbNota2.Size = new System.Drawing.Size(50, 28);
            this.cmbNota2.TabIndex = 8;
            // 
            // cmbNota3
            // 
            this.cmbNota3.FormattingEnabled = true;
            this.cmbNota3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNota3.Location = new System.Drawing.Point(195, 179);
            this.cmbNota3.Name = "cmbNota3";
            this.cmbNota3.Size = new System.Drawing.Size(50, 28);
            this.cmbNota3.TabIndex = 8;
            // 
            // cmbNota4
            // 
            this.cmbNota4.FormattingEnabled = true;
            this.cmbNota4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNota4.Location = new System.Drawing.Point(251, 179);
            this.cmbNota4.Name = "cmbNota4";
            this.cmbNota4.Size = new System.Drawing.Size(50, 28);
            this.cmbNota4.TabIndex = 8;
            // 
            // cmbNota5
            // 
            this.cmbNota5.FormattingEnabled = true;
            this.cmbNota5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNota5.Location = new System.Drawing.Point(307, 179);
            this.cmbNota5.Name = "cmbNota5";
            this.cmbNota5.Size = new System.Drawing.Size(50, 28);
            this.cmbNota5.TabIndex = 8;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(83, 226);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(162, 42);
            this.btnAdauga.TabIndex = 9;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbAnAfisare);
            this.groupBox2.Controls.Add(this.txtNumeCautare);
            this.groupBox2.Controls.Add(this.btnCautaNume);
            this.groupBox2.Controls.Add(this.btnAfisareAn);
            this.groupBox2.Controls.Add(this.btnOrdonareMedie);
            this.groupBox2.Controls.Add(this.btnOrdonareNume);
            this.groupBox2.Location = new System.Drawing.Point(394, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 166);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Afisare";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmbAnAfisare
            // 
            this.cmbAnAfisare.FormattingEnabled = true;
            this.cmbAnAfisare.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbAnAfisare.Location = new System.Drawing.Point(197, 98);
            this.cmbAnAfisare.Name = "cmbAnAfisare";
            this.cmbAnAfisare.Size = new System.Drawing.Size(78, 28);
            this.cmbAnAfisare.TabIndex = 5;
            // 
            // txtNumeCautare
            // 
            this.txtNumeCautare.Location = new System.Drawing.Point(143, 135);
            this.txtNumeCautare.Name = "txtNumeCautare";
            this.txtNumeCautare.Size = new System.Drawing.Size(125, 27);
            this.txtNumeCautare.TabIndex = 4;
            // 
            // btnCautaNume
            // 
            this.btnCautaNume.Location = new System.Drawing.Point(7, 134);
            this.btnCautaNume.Name = "btnCautaNume";
            this.btnCautaNume.Size = new System.Drawing.Size(130, 29);
            this.btnCautaNume.TabIndex = 3;
            this.btnCautaNume.Text = "Cautare nume:";
            this.btnCautaNume.UseVisualStyleBackColor = true;
            this.btnCautaNume.Click += new System.EventHandler(this.btnCautaNume_Click);
            // 
            // btnAfisareAn
            // 
            this.btnAfisareAn.Location = new System.Drawing.Point(7, 98);
            this.btnAfisareAn.Name = "btnAfisareAn";
            this.btnAfisareAn.Size = new System.Drawing.Size(184, 29);
            this.btnAfisareAn.TabIndex = 2;
            this.btnAfisareAn.Text = "Afisare stud. din anul:";
            this.btnAfisareAn.UseVisualStyleBackColor = true;
            this.btnAfisareAn.Click += new System.EventHandler(this.btnAfisareAn_Click);
            // 
            // btnOrdonareMedie
            // 
            this.btnOrdonareMedie.Location = new System.Drawing.Point(7, 62);
            this.btnOrdonareMedie.Name = "btnOrdonareMedie";
            this.btnOrdonareMedie.Size = new System.Drawing.Size(184, 29);
            this.btnOrdonareMedie.TabIndex = 1;
            this.btnOrdonareMedie.Text = "Ordonare dupa medie";
            this.btnOrdonareMedie.UseVisualStyleBackColor = true;
            this.btnOrdonareMedie.Click += new System.EventHandler(this.btnOrdonareMedie_Click);
            // 
            // btnOrdonareNume
            // 
            this.btnOrdonareNume.Location = new System.Drawing.Point(7, 27);
            this.btnOrdonareNume.Name = "btnOrdonareNume";
            this.btnOrdonareNume.Size = new System.Drawing.Size(184, 29);
            this.btnOrdonareNume.TabIndex = 0;
            this.btnOrdonareNume.Text = "Ordonare dupa nume";
            this.btnOrdonareNume.UseVisualStyleBackColor = true;
            this.btnOrdonareNume.Click += new System.EventHandler(this.btnOrdonareNume_Click);
            // 
            // listStudenti
            // 
            this.listStudenti.FormattingEnabled = true;
            this.listStudenti.ItemHeight = 20;
            this.listStudenti.Location = new System.Drawing.Point(401, 198);
            this.listStudenti.Name = "listStudenti";
            this.listStudenti.Size = new System.Drawing.Size(373, 204);
            this.listStudenti.TabIndex = 11;
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(401, 408);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(94, 29);
            this.btnSterge.TabIndex = 12;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.listStudenti);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.cmbNota5);
            this.Controls.Add(this.cmbNota4);
            this.Controls.Add(this.cmbNota3);
            this.Controls.Add(this.cmbNota2);
            this.Controls.Add(this.cmbNota1);
            this.Controls.Add(this.cmbAn);
            this.Controls.Add(this.numVarsta);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numVarsta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.NumericUpDown numVarsta;
        private System.Windows.Forms.ComboBox cmbAn;
        private System.Windows.Forms.ComboBox cmbNota1;
        private System.Windows.Forms.ComboBox cmbNota2;
        private System.Windows.Forms.ComboBox cmbNota3;
        private System.Windows.Forms.ComboBox cmbNota4;
        private System.Windows.Forms.ComboBox cmbNota6;
        private System.Windows.Forms.ComboBox cmbNota5;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOrdonareMedie;
        private System.Windows.Forms.Button btnOrdonareNume;
        private System.Windows.Forms.ComboBox cmbAnAfisare;
        private System.Windows.Forms.TextBox txtNumeCautare;
        private System.Windows.Forms.Button btnCautaNume;
        private System.Windows.Forms.Button btnAfisareAn;
        private System.Windows.Forms.ListBox listStudenti;
        private System.Windows.Forms.Button btnSterge;
    }
}

