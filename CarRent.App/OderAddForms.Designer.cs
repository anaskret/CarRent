namespace CarRent.App
{
    partial class OderAddForms
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
            this.lbcar = new System.Windows.Forms.Label();
            this.cbCars = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudRentalTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbWorkers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentalTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(214, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD ORDER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbcar
            // 
            this.lbcar.AutoSize = true;
            this.lbcar.Location = new System.Drawing.Point(29, 58);
            this.lbcar.Name = "lbcar";
            this.lbcar.Size = new System.Drawing.Size(71, 15);
            this.lbcar.TabIndex = 1;
            this.lbcar.Text = "Choose Car:";
            // 
            // cbCars
            // 
            this.cbCars.FormattingEnabled = true;
            this.cbCars.Location = new System.Drawing.Point(29, 82);
            this.cbCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCars.Name = "cbCars";
            this.cbCars.Size = new System.Drawing.Size(133, 23);
            this.cbCars.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rental Time";
            // 
            // nudRentalTime
            // 
            this.nudRentalTime.Location = new System.Drawing.Point(29, 140);
            this.nudRentalTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudRentalTime.Name = "nudRentalTime";
            this.nudRentalTime.Size = new System.Drawing.Size(131, 23);
            this.nudRentalTime.TabIndex = 4;
            this.nudRentalTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "DeliveryPlace";
            // 
            // tbPlace
            // 
            this.tbPlace.Location = new System.Drawing.Point(29, 196);
            this.tbPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(132, 23);
            this.tbPlace.TabIndex = 6;
            // 
            // dtpOrder
            // 
            this.dtpOrder.Location = new System.Drawing.Point(29, 250);
            this.dtpOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(245, 23);
            this.dtpOrder.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "OrderStart";
            // 
            // cbWorkers
            // 
            this.cbWorkers.FormattingEnabled = true;
            this.cbWorkers.Location = new System.Drawing.Point(29, 322);
            this.cbWorkers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbWorkers.Name = "cbWorkers";
            this.cbWorkers.Size = new System.Drawing.Size(133, 23);
            this.cbWorkers.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Worker:";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnAddOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddOrder.Location = new System.Drawing.Point(76, 399);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(379, 110);
            this.btnAddOrder.TabIndex = 11;
            this.btnAddOrder.Text = "ADD ORDER";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // cbClients
            // 
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(327, 322);
            this.cbClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(133, 23);
            this.cbClients.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Klient";
            // 
            // OderAddForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 543);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbWorkers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpOrder);
            this.Controls.Add(this.tbPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudRentalTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCars);
            this.Controls.Add(this.lbcar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OderAddForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OderAddForms";
            this.Load += new System.EventHandler(this.OderAddForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRentalTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbcar;
        private System.Windows.Forms.ComboBox cbCars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudRentalTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbWorkers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Label label6;
    }
}