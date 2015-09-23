namespace AdventureWorksClient
{
    partial class AW_LINQ
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
            this.dataGridViewQueryResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQueryResults
            // 
            this.dataGridViewQueryResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueryResults.Location = new System.Drawing.Point(34, 24);
            this.dataGridViewQueryResults.Name = "dataGridViewQueryResults";
            this.dataGridViewQueryResults.Size = new System.Drawing.Size(542, 299);
            this.dataGridViewQueryResults.TabIndex = 0;
            // 
            // AW_LINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 373);
            this.Controls.Add(this.dataGridViewQueryResults);
            this.Name = "AW_LINQ";
            this.Text = "AW_LINQ";
            this.Load += new System.EventHandler(this.AW_LINQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQueryResults;
    }
}