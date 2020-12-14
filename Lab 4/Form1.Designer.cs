
namespace Lab_4
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
            this.pacientiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientiDataSet = new Lab_4.PacientiDataSet();
            this.flowLayoutPanelRadiografii = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxRadiografie = new System.Windows.Forms.PictureBox();
            this.richTextBoxDescriere = new System.Windows.Forms.RichTextBox();
            this.buttonSalvare = new System.Windows.Forms.Button();
            this.buttonAdaugaRadiografie = new System.Windows.Forms.Button();
            this.textBoxCautare = new System.Windows.Forms.TextBox();
            this.labelCautare = new System.Windows.Forms.Label();
            this.buttonAdaugaPacient = new System.Windows.Forms.Button();
            this.radiografiiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEraseDatabase = new System.Windows.Forms.Button();
            this.pacientiTableAdapter = new Lab_4.PacientiDataSetTableAdapters.PacientiTableAdapter();
            this.tableAdapterManager = new Lab_4.PacientiDataSetTableAdapters.TableAdapterManager();
            this.radiografiiTableAdapter = new Lab_4.PacientiDataSetTableAdapters.RadiografiiTableAdapter();
            this.radiografiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pacientiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRadiografie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pacientiDataGridView
            // 
            this.pacientiDataGridView.AutoGenerateColumns = false;
            this.pacientiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pacientiDataGridView.DataSource = this.pacientiBindingSource;
            this.pacientiDataGridView.Location = new System.Drawing.Point(12, 38);
            this.pacientiDataGridView.Name = "pacientiDataGridView";
            this.pacientiDataGridView.ReadOnly = true;
            this.pacientiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pacientiDataGridView.Size = new System.Drawing.Size(425, 493);
            this.pacientiDataGridView.TabIndex = 1;
            this.pacientiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientiDataGridView_CellContentClick);
            this.pacientiDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pacientiDataGridView_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CNP";
            this.dataGridViewTextBoxColumn1.HeaderText = "CNP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // pacientiBindingSource
            // 
            this.pacientiBindingSource.DataMember = "Pacienti";
            this.pacientiBindingSource.DataSource = this.pacientiDataSet;
            this.pacientiBindingSource.CurrentChanged += new System.EventHandler(this.pacientiBindingSource_CurrentChanged);
            this.pacientiBindingSource.PositionChanged += new System.EventHandler(this.pacientiBindingSource_PositionChanged);
            // 
            // pacientiDataSet
            // 
            this.pacientiDataSet.DataSetName = "PacientiDataSet";
            this.pacientiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowLayoutPanelRadiografii
            // 
            this.flowLayoutPanelRadiografii.Location = new System.Drawing.Point(443, 12);
            this.flowLayoutPanelRadiografii.Name = "flowLayoutPanelRadiografii";
            this.flowLayoutPanelRadiografii.Size = new System.Drawing.Size(171, 548);
            this.flowLayoutPanelRadiografii.TabIndex = 2;
            this.flowLayoutPanelRadiografii.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelRadiografii_Paint);
            // 
            // pictureBoxRadiografie
            // 
            this.pictureBoxRadiografie.Location = new System.Drawing.Point(620, 12);
            this.pictureBoxRadiografie.Name = "pictureBoxRadiografie";
            this.pictureBoxRadiografie.Size = new System.Drawing.Size(507, 343);
            this.pictureBoxRadiografie.TabIndex = 0;
            this.pictureBoxRadiografie.TabStop = false;
            // 
            // richTextBoxDescriere
            // 
            this.richTextBoxDescriere.Location = new System.Drawing.Point(620, 361);
            this.richTextBoxDescriere.Name = "richTextBoxDescriere";
            this.richTextBoxDescriere.ReadOnly = true;
            this.richTextBoxDescriere.Size = new System.Drawing.Size(507, 199);
            this.richTextBoxDescriere.TabIndex = 3;
            this.richTextBoxDescriere.Text = "";
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.Location = new System.Drawing.Point(12, 537);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(119, 23);
            this.buttonSalvare.TabIndex = 4;
            this.buttonSalvare.Text = "Salveaza modificari";
            this.buttonSalvare.UseVisualStyleBackColor = true;
            this.buttonSalvare.Click += new System.EventHandler(this.buttonSalvare_Click);
            // 
            // buttonAdaugaRadiografie
            // 
            this.buttonAdaugaRadiografie.Location = new System.Drawing.Point(318, 537);
            this.buttonAdaugaRadiografie.Name = "buttonAdaugaRadiografie";
            this.buttonAdaugaRadiografie.Size = new System.Drawing.Size(119, 23);
            this.buttonAdaugaRadiografie.TabIndex = 5;
            this.buttonAdaugaRadiografie.Text = "Adauga radiografie";
            this.buttonAdaugaRadiografie.UseVisualStyleBackColor = true;
            this.buttonAdaugaRadiografie.Click += new System.EventHandler(this.buttonAdaugaRadiografie_Click);
            // 
            // textBoxCautare
            // 
            this.textBoxCautare.Location = new System.Drawing.Point(121, 12);
            this.textBoxCautare.Name = "textBoxCautare";
            this.textBoxCautare.Size = new System.Drawing.Size(317, 20);
            this.textBoxCautare.TabIndex = 6;
            this.textBoxCautare.TextChanged += new System.EventHandler(this.textBoxCautare_TextChanged);
            // 
            // labelCautare
            // 
            this.labelCautare.AutoSize = true;
            this.labelCautare.Location = new System.Drawing.Point(12, 15);
            this.labelCautare.Name = "labelCautare";
            this.labelCautare.Size = new System.Drawing.Size(103, 13);
            this.labelCautare.TabIndex = 7;
            this.labelCautare.Text = "Cautare dupa nume:";
            this.labelCautare.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAdaugaPacient
            // 
            this.buttonAdaugaPacient.Location = new System.Drawing.Point(193, 537);
            this.buttonAdaugaPacient.Name = "buttonAdaugaPacient";
            this.buttonAdaugaPacient.Size = new System.Drawing.Size(119, 23);
            this.buttonAdaugaPacient.TabIndex = 8;
            this.buttonAdaugaPacient.Text = "Adauga pacient";
            this.buttonAdaugaPacient.UseVisualStyleBackColor = true;
            this.buttonAdaugaPacient.Click += new System.EventHandler(this.buttonAdaugaPacient_Click);
            // 
            // radiografiiBindingSource1
            // 
            this.radiografiiBindingSource1.DataMember = "FK__Radiografii__CNP__267ABA7A";
            this.radiografiiBindingSource1.DataSource = this.pacientiBindingSource;
            // 
            // buttonEraseDatabase
            // 
            this.buttonEraseDatabase.Location = new System.Drawing.Point(158, 537);
            this.buttonEraseDatabase.Name = "buttonEraseDatabase";
            this.buttonEraseDatabase.Size = new System.Drawing.Size(29, 23);
            this.buttonEraseDatabase.TabIndex = 9;
            this.buttonEraseDatabase.Text = "X";
            this.buttonEraseDatabase.UseVisualStyleBackColor = true;
            this.buttonEraseDatabase.Click += new System.EventHandler(this.buttonEraseDatabase_Click);
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PacientiTableAdapter = this.pacientiTableAdapter;
            this.tableAdapterManager.RadiografiiTableAdapter = this.radiografiiTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lab_4.PacientiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // radiografiiTableAdapter
            // 
            this.radiografiiTableAdapter.ClearBeforeFill = true;
            // 
            // radiografiiBindingSource
            // 
            this.radiografiiBindingSource.DataMember = "Radiografii";
            this.radiografiiBindingSource.DataSource = this.pacientiDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 572);
            this.Controls.Add(this.buttonEraseDatabase);
            this.Controls.Add(this.buttonAdaugaPacient);
            this.Controls.Add(this.labelCautare);
            this.Controls.Add(this.textBoxCautare);
            this.Controls.Add(this.buttonAdaugaRadiografie);
            this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.richTextBoxDescriere);
            this.Controls.Add(this.pictureBoxRadiografie);
            this.Controls.Add(this.flowLayoutPanelRadiografii);
            this.Controls.Add(this.pacientiDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRadiografie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PacientiDataSet pacientiDataSet;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private PacientiDataSetTableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private PacientiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PacientiDataSetTableAdapters.RadiografiiTableAdapter radiografiiTableAdapter;
        private System.Windows.Forms.DataGridView pacientiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource radiografiiBindingSource;
        private System.Windows.Forms.BindingSource radiografiiBindingSource1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRadiografii;
        private System.Windows.Forms.PictureBox pictureBoxRadiografie;
        private System.Windows.Forms.RichTextBox richTextBoxDescriere;
        private System.Windows.Forms.Button buttonSalvare;
        private System.Windows.Forms.Button buttonAdaugaRadiografie;
        private System.Windows.Forms.TextBox textBoxCautare;
        private System.Windows.Forms.Label labelCautare;
        private System.Windows.Forms.Button buttonAdaugaPacient;
        private System.Windows.Forms.Button buttonEraseDatabase;
    }
}

