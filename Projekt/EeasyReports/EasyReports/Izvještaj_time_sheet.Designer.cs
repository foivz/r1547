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
            this._1547_DBDataSet1 = new EasyReports._1547_DBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._1547_DBDataSet11 = new EasyReports._1547_DBDataSet1();
            this.timeSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeSheetTableAdapter = new EasyReports._1547_DBDataSet1TableAdapters.TimeSheetTableAdapter();
            this.sifraprojektaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.matbrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumivrijemeodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumivrijemedoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._1547_DBDataSet2 = new EasyReports._1547_DBDataSet2();
            this.timeSheetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timeSheetTableAdapter1 = new EasyReports._1547_DBDataSet2TableAdapters.TimeSheetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._1547_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1547_DBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1547_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // _1547_DBDataSet1
            // 
            this._1547_DBDataSet1.DataSetName = "_1547_DBDataSet";
            this._1547_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraprojektaDataGridViewImageColumn,
            this.matbrDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.datumivrijemeodDataGridViewTextBoxColumn,
            this.datumivrijemedoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.timeSheetBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(64, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // _1547_DBDataSet11
            // 
            this._1547_DBDataSet11.DataSetName = "_1547_DBDataSet1";
            this._1547_DBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeSheetBindingSource
            // 
            this.timeSheetBindingSource.DataMember = "TimeSheet";
            this.timeSheetBindingSource.DataSource = this._1547_DBDataSet11;
            // 
            // timeSheetTableAdapter
            // 
            this.timeSheetTableAdapter.ClearBeforeFill = true;
            // 
            // sifraprojektaDataGridViewImageColumn
            // 
            this.sifraprojektaDataGridViewImageColumn.DataPropertyName = "sifra_projekta";
            this.sifraprojektaDataGridViewImageColumn.HeaderText = "sifra_projekta";
            this.sifraprojektaDataGridViewImageColumn.Name = "sifraprojektaDataGridViewImageColumn";
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
            // _1547_DBDataSet2
            // 
            this._1547_DBDataSet2.DataSetName = "_1547_DBDataSet2";
            this._1547_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeSheetBindingSource1
            // 
            this.timeSheetBindingSource1.DataMember = "TimeSheet";
            this.timeSheetBindingSource1.DataSource = this._1547_DBDataSet2;
            // 
            // timeSheetTableAdapter1
            // 
            this.timeSheetTableAdapter1.ClearBeforeFill = true;
            // 
            // Izvještaj_time_sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Izvještaj_time_sheet";
            this.Text = "Izvještaj_time_sheet";
            this.Load += new System.EventHandler(this.Izvještaj_time_sheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this._1547_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1547_DBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1547_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _1547_DBDataSet _1547_DBDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _1547_DBDataSet1 _1547_DBDataSet11;
        private System.Windows.Forms.BindingSource timeSheetBindingSource;
        private _1547_DBDataSet1TableAdapters.TimeSheetTableAdapter timeSheetTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn sifraprojektaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matbrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumivrijemeodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumivrijemedoDataGridViewTextBoxColumn;
        private _1547_DBDataSet2 _1547_DBDataSet2;
        private System.Windows.Forms.BindingSource timeSheetBindingSource1;
        private _1547_DBDataSet2TableAdapters.TimeSheetTableAdapter timeSheetTableAdapter1;
    }
}