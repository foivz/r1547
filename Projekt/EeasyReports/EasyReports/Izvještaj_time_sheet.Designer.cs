namespace EasyReports
{
    partial class Izvještaj_time_sheet
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraprojektaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matbrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumivrijemeodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumivrijemedoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lokalnaKopijaPodataka = new EasyReports.LokalnaKopijaPodataka();
            this.timeSheetTableAdapter = new EasyReports.LokalnaKopijaPodatakaTableAdapters.TimeSheetTableAdapter();
            this.cmbProjekti = new System.Windows.Forms.ComboBox();
            this.projektiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektiTableAdapter = new EasyReports.LokalnaKopijaPodatakaTableAdapters.ProjektiTableAdapter();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.cmbOsobe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokalnaKopijaPodataka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sifraprojektaDataGridViewTextBoxColumn,
            this.matbrDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.datumivrijemeodDataGridViewTextBoxColumn,
            this.datumivrijemedoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.timeSheetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // sifraprojektaDataGridViewTextBoxColumn
            // 
            this.sifraprojektaDataGridViewTextBoxColumn.DataPropertyName = "sifra_projekta";
            this.sifraprojektaDataGridViewTextBoxColumn.HeaderText = "sifra_projekta";
            this.sifraprojektaDataGridViewTextBoxColumn.Name = "sifraprojektaDataGridViewTextBoxColumn";
            // 
            // matbrDataGridViewTextBoxColumn
            // 
            this.matbrDataGridViewTextBoxColumn.DataPropertyName = "mat_br";
            this.matbrDataGridViewTextBoxColumn.HeaderText = "mat_br";
            this.matbrDataGridViewTextBoxColumn.Name = "matbrDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // datumivrijemeodDataGridViewTextBoxColumn
            // 
            this.datumivrijemeodDataGridViewTextBoxColumn.DataPropertyName = "datum_i_vrijeme_od";
            this.datumivrijemeodDataGridViewTextBoxColumn.HeaderText = "datum_i_vrijeme_od";
            this.datumivrijemeodDataGridViewTextBoxColumn.Name = "datumivrijemeodDataGridViewTextBoxColumn";
            // 
            // datumivrijemedoDataGridViewTextBoxColumn
            // 
            this.datumivrijemedoDataGridViewTextBoxColumn.DataPropertyName = "datum_i_vrijeme_do";
            this.datumivrijemedoDataGridViewTextBoxColumn.HeaderText = "datum_i_vrijeme_do";
            this.datumivrijemedoDataGridViewTextBoxColumn.Name = "datumivrijemedoDataGridViewTextBoxColumn";
            // 
            // timeSheetBindingSource
            // 
            this.timeSheetBindingSource.DataMember = "TimeSheet";
            this.timeSheetBindingSource.DataSource = this.lokalnaKopijaPodataka;
            // 
            // lokalnaKopijaPodataka
            // 
            this.lokalnaKopijaPodataka.DataSetName = "LokalnaKopijaPodataka";
            this.lokalnaKopijaPodataka.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeSheetTableAdapter
            // 
            this.timeSheetTableAdapter.ClearBeforeFill = true;
            // 
            // cmbProjekti
            // 
            this.cmbProjekti.DataSource = this.projektiBindingSource;
            this.cmbProjekti.DisplayMember = "naziv_projekta";
            this.cmbProjekti.FormattingEnabled = true;
            this.cmbProjekti.Location = new System.Drawing.Point(12, 21);
            this.cmbProjekti.Name = "cmbProjekti";
            this.cmbProjekti.Size = new System.Drawing.Size(245, 21);
            this.cmbProjekti.TabIndex = 1;
            this.cmbProjekti.ValueMember = "sifra_projekta";
            // 
            // projektiBindingSource
            // 
            this.projektiBindingSource.DataMember = "Projekti";
            this.projektiBindingSource.DataSource = this.lokalnaKopijaPodataka;
            // 
            // projektiTableAdapter
            // 
            this.projektiTableAdapter.ClearBeforeFill = true;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(651, 21);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnOsvjezi.TabIndex = 2;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // cmbOsobe
            // 
            this.cmbOsobe.DataSource = this.projektiBindingSource;
            this.cmbOsobe.DisplayMember = "naziv_projekta";
            this.cmbOsobe.FormattingEnabled = true;
            this.cmbOsobe.Location = new System.Drawing.Point(366, 23);
            this.cmbOsobe.Name = "cmbOsobe";
            this.cmbOsobe.Size = new System.Drawing.Size(245, 21);
            this.cmbOsobe.TabIndex = 3;
            this.cmbOsobe.ValueMember = "sifra_projekta";
            // 
            // Izvještaj_time_sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 323);
            this.Controls.Add(this.cmbOsobe);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.cmbProjekti);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Izvještaj_time_sheet";
            this.Text = "Izvještaj_time_sheet";
            this.Load += new System.EventHandler(this.Izvještaj_time_sheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokalnaKopijaPodataka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private LokalnaKopijaPodataka lokalnaKopijaPodataka;
        private System.Windows.Forms.BindingSource timeSheetBindingSource;
        private LokalnaKopijaPodatakaTableAdapters.TimeSheetTableAdapter timeSheetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraprojektaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matbrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumivrijemeodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumivrijemedoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbProjekti;
        private System.Windows.Forms.BindingSource projektiBindingSource;
        private LokalnaKopijaPodatakaTableAdapters.ProjektiTableAdapter projektiTableAdapter;
        private LokalnaKopijaPodatakaTableAdapters.OsobeTableAdapter osobeTableAdapter;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.ComboBox cmbOsobe;
    }
}