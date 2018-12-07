namespace FinalBrowser
{
    partial class ConsumptionForm
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
            this.dataGridViewCon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCon
            // 
            this.dataGridViewCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCon.Location = new System.Drawing.Point(98, 125);
            this.dataGridViewCon.Name = "dataGridViewCon";
            this.dataGridViewCon.Size = new System.Drawing.Size(234, 246);
            this.dataGridViewCon.TabIndex = 4;
            // 
            // ConsumptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 499);
            this.Controls.Add(this.dataGridViewCon);
            this.Name = "ConsumptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consumption Type";
            this.Load += new System.EventHandler(this.ConsumptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCon;

    }
}