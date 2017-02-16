namespace EasyReports
{
    partial class Izvještaj
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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._1547_DBDataSet = new EasyReports._1547_DBDataSet();
            this.planizvrsenjaprojektaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plan_izvrsenja_projektaTableAdapter = new EasyReports._1547_DBDataSetTableAdapters.Plan_izvrsenja_projektaTableAdapter();
            this.godinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjesecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraprojektaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjesbudzetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjesecpotrosenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1547_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planizvrsenjaprojektaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.godinaDataGridViewTextBoxColumn,
            this.mjesecDataGridViewTextBoxColumn,
            this.sifraprojektaDataGridViewTextBoxColumn,
            this.mjesbudzetDataGridViewTextBoxColumn,
            this.mjesecpotrosenoDataGridViewTextBoxColumn,
            this.statusprDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.planizvrsenjaprojektaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // _1547_DBDataSet
            // 
            this._1547_DBDataSet.DataSetName = "_1547_DBDataSet";
            this._1547_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planizvrsenjaprojektaBindingSource
            // 
            this.planizvrsenjaprojektaBindingSource.DataMember = "Plan_izvrsenja_projekta";
            this.planizvrsenjaprojektaBindingSource.DataSource = this._1547_DBDataSet;
            // 
            // plan_izvrsenja_projektaTableAdapter
            // 
            this.plan_izvrsenja_projektaTableAdapter.ClearBeforeFill = true;
            // 
            // godinaDataGridViewTextBoxColumn
            // 
            this.godinaDataGridViewTextBoxColumn.DataPropertyName = "godina";
            this.godinaDataGridViewTextBoxColumn.HeaderText = "godina";
            this.godinaDataGridViewTextBoxColumn.Name = "godinaDataGridViewTextBoxColumn";
            // 
            // mjesecDataGridViewTextBoxColumn
            // 
            this.mjesecDataGridViewTextBoxColumn.DataPropertyName = "mjesec";
            this.mjesecDataGridViewTextBoxColumn.HeaderText = "mjesec";
            this.mjesecDataGridViewTextBoxColumn.Name = "mjesecDataGridViewTextBoxColumn";
            // 
            // sifraprojektaDataGridViewTextBoxColumn
            // 
            this.sifraprojektaDataGridViewTextBoxColumn.DataPropertyName = "sifra_projekta";
            this.sifraprojektaDataGridViewTextBoxColumn.HeaderText = "sifra_projekta";
            this.sifraprojektaDataGridViewTextBoxColumn.Name = "sifraprojektaDataGridViewTextBoxColumn";
            // 
            // mjesbudzetDataGridViewTextBoxColumn
            // 
            this.mjesbudzetDataGridViewTextBoxColumn.DataPropertyName = "mjes_budzet";
            this.mjesbudzetDataGridViewTextBoxColumn.HeaderText = "mjes_budzet";
            this.mjesbudzetDataGridViewTextBoxColumn.Name = "mjesbudzetDataGridViewTextBoxColumn";
            // 
            // mjesecpotrosenoDataGridViewTextBoxColumn
            // 
            this.mjesecpotrosenoDataGridViewTextBoxColumn.DataPropertyName = "mjesec_potroseno";
            this.mjesecpotrosenoDataGridViewTextBoxColumn.HeaderText = "mjesec_potroseno";
            this.mjesecpotrosenoDataGridViewTextBoxColumn.Name = "mjesecpotrosenoDataGridViewTextBoxColumn";
            // 
            // statusprDataGridViewTextBoxColumn
            // 
            this.statusprDataGridViewTextBoxColumn.DataPropertyName = "status_pr";
            this.statusprDataGridViewTextBoxColumn.HeaderText = "status_pr";
            this.statusprDataGridViewTextBoxColumn.Name = "statusprDataGridViewTextBoxColumn";
            // 
            // Izvještaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Izvještaj";
            this.Text = "Izvještaj";
            this.Load += new System.EventHandler(this.Izvještaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1547_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planizvrsenjaprojektaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _1547_DBDataSet _1547_DBDataSet;
        private System.Windows.Forms.BindingSource planizvrsenjaprojektaBindingSource;
        private _1547_DBDataSetTableAdapters.Plan_izvrsenja_projektaTableAdapter plan_izvrsenja_projektaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjesecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraprojektaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjesbudzetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjesecpotrosenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusprDataGridViewTextBoxColumn;
    }
}