namespace CarRent.App
{
    partial class RepairReport
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
            this.numUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.numUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.lblRepairReport = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbxDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCost)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDownTime
            // 
            this.numUpDownTime.Location = new System.Drawing.Point(105, 186);
            this.numUpDownTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownTime.Name = "numUpDownTime";
            this.numUpDownTime.Size = new System.Drawing.Size(200, 23);
            this.numUpDownTime.TabIndex = 9;
            this.numUpDownTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpDownCost
            // 
            this.numUpDownCost.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDownCost.Location = new System.Drawing.Point(105, 157);
            this.numUpDownCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDownCost.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDownCost.Name = "numUpDownCost";
            this.numUpDownCost.Size = new System.Drawing.Size(200, 23);
            this.numUpDownCost.TabIndex = 8;
            this.numUpDownCost.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblRepairReport
            // 
            this.lblRepairReport.AutoSize = true;
            this.lblRepairReport.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRepairReport.Location = new System.Drawing.Point(71, 9);
            this.lblRepairReport.Name = "lblRepairReport";
            this.lblRepairReport.Size = new System.Drawing.Size(184, 37);
            this.lblRepairReport.TabIndex = 0;
            this.lblRepairReport.Text = "Repair Report";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCost.Location = new System.Drawing.Point(12, 157);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(38, 20);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Cost";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(12, 189);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 20);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time(Days)";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Location = new System.Drawing.Point(36, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 52);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.Location = new System.Drawing.Point(159, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 52);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(12, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 20);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // rtbxDescription
            // 
            this.rtbxDescription.Location = new System.Drawing.Point(105, 71);
            this.rtbxDescription.Name = "rtbxDescription";
            this.rtbxDescription.Size = new System.Drawing.Size(200, 80);
            this.rtbxDescription.TabIndex = 13;
            this.rtbxDescription.Text = "";
            // 
            // RepairReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 315);
            this.Controls.Add(this.lblRepairReport);
            this.Controls.Add(this.rtbxDescription);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.numUpDownTime);
            this.Controls.Add(this.numUpDownCost);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDescription);
            this.Name = "RepairReport";
            this.Text = "RepairReport";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDownTime;
        private System.Windows.Forms.NumericUpDown numUpDownCost;
        private System.Windows.Forms.Label lblRepairReport;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbxDescription;
    }
}