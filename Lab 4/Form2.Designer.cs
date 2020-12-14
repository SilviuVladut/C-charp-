
namespace Lab_4
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonOpenFileDialog = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelCNP = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelImagine = new System.Windows.Forms.Label();
            this.labelDiagnostic = new System.Windows.Forms.Label();
            this.labelComentarii = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 2;
            // 
            // buttonOpenFileDialog
            // 
            this.buttonOpenFileDialog.Location = new System.Drawing.Point(287, 96);
            this.buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            this.buttonOpenFileDialog.Size = new System.Drawing.Size(26, 20);
            this.buttonOpenFileDialog.TabIndex = 3;
            this.buttonOpenFileDialog.Text = "...";
            this.buttonOpenFileDialog.UseVisualStyleBackColor = true;
            this.buttonOpenFileDialog.Click += new System.EventHandler(this.buttonOpenFileDialog_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 4;
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.Location = new System.Drawing.Point(78, 47);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(29, 13);
            this.labelCNP.TabIndex = 8;
            this.labelCNP.Text = "CNP";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(77, 76);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 9;
            this.labelData.Text = "Data";
            // 
            // labelImagine
            // 
            this.labelImagine.AutoSize = true;
            this.labelImagine.Location = new System.Drawing.Point(63, 100);
            this.labelImagine.Name = "labelImagine";
            this.labelImagine.Size = new System.Drawing.Size(44, 13);
            this.labelImagine.TabIndex = 10;
            this.labelImagine.Text = "Imagine";
            this.labelImagine.Click += new System.EventHandler(this.labelImagine_Click);
            // 
            // labelDiagnostic
            // 
            this.labelDiagnostic.AutoSize = true;
            this.labelDiagnostic.Location = new System.Drawing.Point(50, 125);
            this.labelDiagnostic.Name = "labelDiagnostic";
            this.labelDiagnostic.Size = new System.Drawing.Size(57, 13);
            this.labelDiagnostic.TabIndex = 11;
            this.labelDiagnostic.Text = "Diagnostic";
            // 
            // labelComentarii
            // 
            this.labelComentarii.AutoSize = true;
            this.labelComentarii.Location = new System.Drawing.Point(50, 151);
            this.labelComentarii.Name = "labelComentarii";
            this.labelComentarii.Size = new System.Drawing.Size(56, 13);
            this.labelComentarii.TabIndex = 12;
            this.labelComentarii.Text = "Comentarii";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(66, 346);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.TabStop = false;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(238, 346);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 151);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 173);
            this.textBox4.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 396);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelComentarii);
            this.Controls.Add(this.labelDiagnostic);
            this.Controls.Add(this.labelImagine);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelCNP);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonOpenFileDialog);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Radiografie noua";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonOpenFileDialog;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelImagine;
        private System.Windows.Forms.Label labelDiagnostic;
        private System.Windows.Forms.Label labelComentarii;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBox4;
    }
}