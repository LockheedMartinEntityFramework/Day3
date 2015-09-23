namespace TestClient
{
    partial class EFTestClient
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
            this.labelCustomerCount = new System.Windows.Forms.Label();
            this.labelCustomerCountValue = new System.Windows.Forms.Label();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCustomerCount
            // 
            this.labelCustomerCount.AutoSize = true;
            this.labelCustomerCount.Location = new System.Drawing.Point(85, 39);
            this.labelCustomerCount.Name = "labelCustomerCount";
            this.labelCustomerCount.Size = new System.Drawing.Size(78, 13);
            this.labelCustomerCount.TabIndex = 0;
            this.labelCustomerCount.Text = "# of Customers";
            // 
            // labelCustomerCountValue
            // 
            this.labelCustomerCountValue.AutoSize = true;
            this.labelCustomerCountValue.Location = new System.Drawing.Point(173, 39);
            this.labelCustomerCountValue.Name = "labelCustomerCountValue";
            this.labelCustomerCountValue.Size = new System.Drawing.Size(36, 13);
            this.labelCustomerCountValue.TabIndex = 1;
            this.labelCustomerCountValue.Text = "Empty";
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(107, 88);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(87, 23);
            this.buttonAddCustomer.TabIndex = 2;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // EFTestClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 161);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.labelCustomerCountValue);
            this.Controls.Add(this.labelCustomerCount);
            this.Name = "EFTestClient";
            this.Text = "Entity Framework Test Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerCount;
        private System.Windows.Forms.Label labelCustomerCountValue;
        private System.Windows.Forms.Button buttonAddCustomer;
    }
}

