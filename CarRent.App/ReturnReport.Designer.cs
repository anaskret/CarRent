namespace CarRent.App
{
    partial class ReturnReport
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
            this.lblReturnReport = new System.Windows.Forms.Label();
            this.lblDrivenDistance = new System.Windows.Forms.Label();
            this.numUpDownDrivenDistance = new System.Windows.Forms.NumericUpDown();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.numUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.numUpDownDay = new System.Windows.Forms.NumericUpDown();
            this.checkbxIsDamaged = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDrivenDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReturnReport
            // 
            this.lblReturnReport.AutoSize = true;
            this.lblReturnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnReport.Location = new System.Drawing.Point(66, 9);
            this.lblReturnReport.Name = "lblReturnReport";
            this.lblReturnReport.Size = new System.Drawing.Size(189, 37);
            this.lblReturnReport.TabIndex = 0;
            this.lblReturnReport.Text = "Return Report";
            // 
            // lblDrivenDistance
            // 
            this.lblDrivenDistance.AutoSize = true;
            this.lblDrivenDistance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDrivenDistance.Location = new System.Drawing.Point(12, 71);
            this.lblDrivenDistance.Name = "lblDrivenDistance";
            this.lblDrivenDistance.Size = new System.Drawing.Size(117, 20);
            this.lblDrivenDistance.TabIndex = 1;
            this.lblDrivenDistance.Text = "Driven Distance";
            // 
            // numUpDownDrivenDistance
            // 
            this.numUpDownDrivenDistance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDownDrivenDistance.Location = new System.Drawing.Point(135, 73);
            this.numUpDownDrivenDistance.Name = "numUpDownDrivenDistance";
            this.numUpDownDrivenDistance.Size = new System.Drawing.Size(170, 23);
            this.numUpDownDrivenDistance.TabIndex = 2;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDate.Location = new System.Drawing.Point(12, 102);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(109, 20);
            this.lblReturnDate.TabIndex = 3;
            this.lblReturnDate.Text = "Date of Return";
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Day.Location = new System.Drawing.Point(85, 185);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(36, 20);
            this.Day.TabIndex = 4;
            this.Day.Text = "Day";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(82, 127);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 20);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonth.Location = new System.Drawing.Point(66, 156);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(55, 20);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Month";
            // 
            // numUpDownYear
            // 
            this.numUpDownYear.Location = new System.Drawing.Point(135, 129);
            this.numUpDownYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numUpDownYear.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.numUpDownYear.Name = "numUpDownYear";
            this.numUpDownYear.Size = new System.Drawing.Size(170, 23);
            this.numUpDownYear.TabIndex = 7;
            this.numUpDownYear.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // numUpDownMonth
            // 
            this.numUpDownMonth.Location = new System.Drawing.Point(135, 158);
            this.numUpDownMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUpDownMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownMonth.Name = "numUpDownMonth";
            this.numUpDownMonth.Size = new System.Drawing.Size(170, 23);
            this.numUpDownMonth.TabIndex = 8;
            this.numUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpDownDay
            // 
            this.numUpDownDay.Location = new System.Drawing.Point(135, 187);
            this.numUpDownDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numUpDownDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownDay.Name = "numUpDownDay";
            this.numUpDownDay.Size = new System.Drawing.Size(170, 23);
            this.numUpDownDay.TabIndex = 9;
            this.numUpDownDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkbxIsDamaged
            // 
            this.checkbxIsDamaged.AutoSize = true;
            this.checkbxIsDamaged.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkbxIsDamaged.Location = new System.Drawing.Point(135, 216);
            this.checkbxIsDamaged.Name = "checkbxIsDamaged";
            this.checkbxIsDamaged.Size = new System.Drawing.Size(108, 24);
            this.checkbxIsDamaged.TabIndex = 10;
            this.checkbxIsDamaged.Text = "Is Damaged";
            this.checkbxIsDamaged.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.Location = new System.Drawing.Point(159, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 52);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Location = new System.Drawing.Point(36, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 52);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ReturnReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 315);
            this.Controls.Add(this.numUpDownDrivenDistance);
            this.Controls.Add(this.numUpDownDay);
            this.Controls.Add(this.checkbxIsDamaged);
            this.Controls.Add(this.numUpDownMonth);
            this.Controls.Add(this.lblReturnReport);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.numUpDownYear);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDrivenDistance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReturnReport";
            this.Text = "ReturnReport";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDrivenDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReturnReport;
        private System.Windows.Forms.Label lblDrivenDistance;
        private System.Windows.Forms.NumericUpDown numUpDownDrivenDistance;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.NumericUpDown numUpDownYear;
        private System.Windows.Forms.NumericUpDown numUpDownMonth;
        private System.Windows.Forms.NumericUpDown numUpDownDay;
        private System.Windows.Forms.CheckBox checkbxIsDamaged;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}