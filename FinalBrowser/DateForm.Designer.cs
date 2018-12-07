namespace FinalBrowser
{
    partial class DateForm
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
            this.dataGridViewDate = new System.Windows.Forms.DataGridView();
            this.iTRI611_DataWarehouse_2017DataSet = new FinalBrowser.ITRI611_DataWarehouse_2017DataSet();
            this.iTRI611DataWarehouse2017DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.date_DimTableAdapter = new FinalBrowser.ITRI611_DataWarehouse_2017DataSetTableAdapters.Date_DimTableAdapter();
            this.dateidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayofweekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayofmonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofmonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTRI611_DataWarehouse_2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTRI611DataWarehouse2017DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDate
            // 
            this.dataGridViewDate.AutoGenerateColumns = false;
            this.dataGridViewDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateidDataGridViewTextBoxColumn,
            this.dayofweekDataGridViewTextBoxColumn,
            this.dayofmonthDataGridViewTextBoxColumn,
            this.nameofmonthDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.dataGridViewDate.DataSource = this.dateDimBindingSource;
            this.dataGridViewDate.Location = new System.Drawing.Point(63, 88);
            this.dataGridViewDate.Name = "dataGridViewDate";
            this.dataGridViewDate.Size = new System.Drawing.Size(540, 230);
            this.dataGridViewDate.TabIndex = 0;
            // 
            // iTRI611_DataWarehouse_2017DataSet
            // 
            this.iTRI611_DataWarehouse_2017DataSet.DataSetName = "ITRI611_DataWarehouse_2017DataSet";
            this.iTRI611_DataWarehouse_2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTRI611DataWarehouse2017DataSetBindingSource
            // 
            this.iTRI611DataWarehouse2017DataSetBindingSource.DataSource = this.iTRI611_DataWarehouse_2017DataSet;
            this.iTRI611DataWarehouse2017DataSetBindingSource.Position = 0;
            // 
            // dateDimBindingSource
            // 
            this.dateDimBindingSource.DataMember = "Date_Dim";
            this.dateDimBindingSource.DataSource = this.iTRI611DataWarehouse2017DataSetBindingSource;
            // 
            // date_DimTableAdapter
            // 
            this.date_DimTableAdapter.ClearBeforeFill = true;
            // 
            // dateidDataGridViewTextBoxColumn
            // 
            this.dateidDataGridViewTextBoxColumn.DataPropertyName = "date_id";
            this.dateidDataGridViewTextBoxColumn.HeaderText = "date_id";
            this.dateidDataGridViewTextBoxColumn.Name = "dateidDataGridViewTextBoxColumn";
            this.dateidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dayofweekDataGridViewTextBoxColumn
            // 
            this.dayofweekDataGridViewTextBoxColumn.DataPropertyName = "day_of_week";
            this.dayofweekDataGridViewTextBoxColumn.HeaderText = "day_of_week";
            this.dayofweekDataGridViewTextBoxColumn.Name = "dayofweekDataGridViewTextBoxColumn";
            // 
            // dayofmonthDataGridViewTextBoxColumn
            // 
            this.dayofmonthDataGridViewTextBoxColumn.DataPropertyName = "day_of_month";
            this.dayofmonthDataGridViewTextBoxColumn.HeaderText = "day_of_month";
            this.dayofmonthDataGridViewTextBoxColumn.Name = "dayofmonthDataGridViewTextBoxColumn";
            // 
            // nameofmonthDataGridViewTextBoxColumn
            // 
            this.nameofmonthDataGridViewTextBoxColumn.DataPropertyName = "name_of_month";
            this.nameofmonthDataGridViewTextBoxColumn.HeaderText = "name_of_month";
            this.nameofmonthDataGridViewTextBoxColumn.Name = "nameofmonthDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 357);
            this.Controls.Add(this.dataGridViewDate);
            this.Name = "DateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DateForm";
            this.Load += new System.EventHandler(this.DateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTRI611_DataWarehouse_2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTRI611DataWarehouse2017DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDimBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDate;
        private System.Windows.Forms.BindingSource iTRI611DataWarehouse2017DataSetBindingSource;
        private ITRI611_DataWarehouse_2017DataSet iTRI611_DataWarehouse_2017DataSet;
        private System.Windows.Forms.BindingSource dateDimBindingSource;
        private ITRI611_DataWarehouse_2017DataSetTableAdapters.Date_DimTableAdapter date_DimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayofweekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayofmonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofmonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
    }
}