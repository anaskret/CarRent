namespace car_fleet
{
    partial class WorkerAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Worker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(183, 108);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(183, 27);
            this.tbFirstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "First Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(183, 156);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(183, 27);
            this.tbLastName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(183, 199);
            this.tbPhone.Mask = "000-000-0000";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(183, 27);
            this.tbPhone.TabIndex = 4;
            this.tbPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbPhone_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Salary";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(183, 248);
            this.tbSalary.Mask = "0000.00";
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(183, 27);
            this.tbSalary.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 120);
            this.button1.TabIndex = 11;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WorkerAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "WorkerAddForm";
            this.Text = "WorkerAddForm";
            this.Load += new System.EventHandler(this.WorkerAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tbPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tbSalary;
        private System.Windows.Forms.Button button1;
    }
}