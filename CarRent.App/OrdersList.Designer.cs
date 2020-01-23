namespace car_fleet
{
    partial class OrdersList
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
            this.lvOrderList = new System.Windows.Forms.ListView();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvOrderList
            // 
            this.lvOrderList.HideSelection = false;
            this.lvOrderList.Location = new System.Drawing.Point(23, 10);
            this.lvOrderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvOrderList.Name = "lvOrderList";
            this.lvOrderList.Size = new System.Drawing.Size(1114, 375);
            this.lvOrderList.TabIndex = 0;
            this.lvOrderList.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(84)))));
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddOrder.Location = new System.Drawing.Point(876, 401);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(260, 68);
            this.btnAddOrder.TabIndex = 1;
            this.btnAddOrder.Text = "ADD ORDER";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnRepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepair.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRepair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRepair.Location = new System.Drawing.Point(591, 401);
            this.btnRepair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(260, 68);
            this.btnRepair.TabIndex = 2;
            this.btnRepair.Text = "REPAIR REPORT";
            this.btnRepair.UseVisualStyleBackColor = false;
            this.btnRepair.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnFinishOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinishOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFinishOrder.Location = new System.Drawing.Point(285, 401);
            this.btnFinishOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(232, 68);
            this.btnFinishOrder.TabIndex = 3;
            this.btnFinishOrder.Text = "FINISH ORDER";
            this.btnFinishOrder.UseVisualStyleBackColor = false;
            this.btnFinishOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Location = new System.Drawing.Point(23, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(232, 68);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // OrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 494);
            this.Controls.Add(this.btnFinishOrder);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lvOrderList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrdersList";
            this.Text = "OrdesList";
            this.Load += new System.EventHandler(this.OrdesList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvOrderList;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
    }
}