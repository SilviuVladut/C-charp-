namespace VladutSilviu_Test_07
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("HR");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("IT");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Contabilitate");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Intretinere");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtZileLucrate = new System.Windows.Forms.TextBox();
            this.txtSalariuZi = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCautaNume = new System.Windows.Forms.Button();
            this.txtNumeCautat = new System.Windows.Forms.TextBox();
            this.btnSterge = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zile lucrate/luna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departament";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salariu/zi";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(133, 52);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(168, 22);
            this.txtNume.TabIndex = 5;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(133, 80);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(168, 22);
            this.txtCNP.TabIndex = 6;
            this.txtCNP.Validating += new System.ComponentModel.CancelEventHandler(this.txtCNP_Validating);
            // 
            // txtZileLucrate
            // 
            this.txtZileLucrate.Location = new System.Drawing.Point(133, 115);
            this.txtZileLucrate.Name = "txtZileLucrate";
            this.txtZileLucrate.Size = new System.Drawing.Size(168, 22);
            this.txtZileLucrate.TabIndex = 7;
            // 
            // txtSalariuZi
            // 
            this.txtSalariuZi.Location = new System.Drawing.Point(133, 172);
            this.txtSalariuZi.Name = "txtSalariuZi";
            this.txtSalariuZi.Size = new System.Drawing.Size(168, 22);
            this.txtSalariuZi.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HR",
            "IT",
            "Contabilitate",
            "Intretinere"});
            this.comboBox1.Location = new System.Drawing.Point(133, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(133, 218);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(104, 28);
            this.btnAdauga.TabIndex = 10;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            this.btnAdauga.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnAdauga_KeyUp);
            // 
            // btnCautaNume
            // 
            this.btnCautaNume.Location = new System.Drawing.Point(21, 280);
            this.btnCautaNume.Name = "btnCautaNume";
            this.btnCautaNume.Size = new System.Drawing.Size(116, 28);
            this.btnCautaNume.TabIndex = 11;
            this.btnCautaNume.Text = "Cauta nume:";
            this.btnCautaNume.UseVisualStyleBackColor = true;
            this.btnCautaNume.Click += new System.EventHandler(this.btnCautaNume_Click);
            // 
            // txtNumeCautat
            // 
            this.txtNumeCautat.Location = new System.Drawing.Point(143, 283);
            this.txtNumeCautat.Name = "txtNumeCautat";
            this.txtNumeCautat.Size = new System.Drawing.Size(142, 22);
            this.txtNumeCautat.TabIndex = 12;
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(98, 314);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(116, 28);
            this.btnSterge.TabIndex = 13;
            this.btnSterge.Text = "Sterge ";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(330, 38);
            this.treeView1.Name = "treeView1";
            treeNode5.Name = "Node0";
            treeNode5.Text = "HR";
            treeNode6.Name = "Node1";
            treeNode6.Text = "IT";
            treeNode7.Name = "Node2";
            treeNode7.Text = "Contabilitate";
            treeNode8.Name = "Node3";
            treeNode8.Text = "Intretinere";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(433, 376);
            this.treeView1.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.txtNumeCautat);
            this.Controls.Add(this.btnCautaNume);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSalariuZi);
            this.Controls.Add(this.txtZileLucrate);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtZileLucrate;
        private System.Windows.Forms.TextBox txtSalariuZi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCautaNume;
        private System.Windows.Forms.TextBox txtNumeCautat;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

