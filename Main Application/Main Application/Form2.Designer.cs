namespace Main_Application
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varekodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beskrivelseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leverandorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundebehandlerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kommentarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundebestillingerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundebestillingerDataSet = new Main_Application.kundebestillingerDataSet();
            this.kundebestillingerTableAdapter = new Main_Application.kundebestillingerDataSetTableAdapters.kundebestillingerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundebestillingerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundebestillingerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.navnDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.varekodeDataGridViewTextBoxColumn,
            this.beskrivelseDataGridViewTextBoxColumn,
            this.leverandorDataGridViewTextBoxColumn,
            this.datoDataGridViewTextBoxColumn,
            this.kundebehandlerDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.kommentarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kundebestillingerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 504);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // navnDataGridViewTextBoxColumn
            // 
            this.navnDataGridViewTextBoxColumn.DataPropertyName = "navn";
            this.navnDataGridViewTextBoxColumn.HeaderText = "navn";
            this.navnDataGridViewTextBoxColumn.Name = "navnDataGridViewTextBoxColumn";
            this.navnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varekodeDataGridViewTextBoxColumn
            // 
            this.varekodeDataGridViewTextBoxColumn.DataPropertyName = "varekode";
            this.varekodeDataGridViewTextBoxColumn.HeaderText = "varekode";
            this.varekodeDataGridViewTextBoxColumn.Name = "varekodeDataGridViewTextBoxColumn";
            this.varekodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beskrivelseDataGridViewTextBoxColumn
            // 
            this.beskrivelseDataGridViewTextBoxColumn.DataPropertyName = "beskrivelse";
            this.beskrivelseDataGridViewTextBoxColumn.HeaderText = "beskrivelse";
            this.beskrivelseDataGridViewTextBoxColumn.Name = "beskrivelseDataGridViewTextBoxColumn";
            this.beskrivelseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leverandorDataGridViewTextBoxColumn
            // 
            this.leverandorDataGridViewTextBoxColumn.DataPropertyName = "leverandor";
            this.leverandorDataGridViewTextBoxColumn.HeaderText = "leverandor";
            this.leverandorDataGridViewTextBoxColumn.Name = "leverandorDataGridViewTextBoxColumn";
            this.leverandorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datoDataGridViewTextBoxColumn
            // 
            this.datoDataGridViewTextBoxColumn.DataPropertyName = "dato";
            this.datoDataGridViewTextBoxColumn.HeaderText = "dato";
            this.datoDataGridViewTextBoxColumn.Name = "datoDataGridViewTextBoxColumn";
            this.datoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kundebehandlerDataGridViewTextBoxColumn
            // 
            this.kundebehandlerDataGridViewTextBoxColumn.DataPropertyName = "kundebehandler";
            this.kundebehandlerDataGridViewTextBoxColumn.HeaderText = "kundebehandler";
            this.kundebehandlerDataGridViewTextBoxColumn.Name = "kundebehandlerDataGridViewTextBoxColumn";
            this.kundebehandlerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kommentarDataGridViewTextBoxColumn
            // 
            this.kommentarDataGridViewTextBoxColumn.DataPropertyName = "kommentar";
            this.kommentarDataGridViewTextBoxColumn.HeaderText = "kommentar";
            this.kommentarDataGridViewTextBoxColumn.Name = "kommentarDataGridViewTextBoxColumn";
            this.kommentarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kundebestillingerBindingSource
            // 
            this.kundebestillingerBindingSource.DataMember = "kundebestillinger";
            this.kundebestillingerBindingSource.DataSource = this.kundebestillingerDataSet;
            // 
            // kundebestillingerDataSet
            // 
            this.kundebestillingerDataSet.DataSetName = "kundebestillingerDataSet";
            this.kundebestillingerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kundebestillingerTableAdapter
            // 
            this.kundebestillingerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Oppdater";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valgt id: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Kundebestillinger - Visning";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundebestillingerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundebestillingerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kundebestillingerDataSet kundebestillingerDataSet;
        private System.Windows.Forms.BindingSource kundebestillingerBindingSource;
        private kundebestillingerDataSetTableAdapters.kundebestillingerTableAdapter kundebestillingerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn navnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varekodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beskrivelseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leverandorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundebehandlerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kommentarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}