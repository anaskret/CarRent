namespace CarRent.App
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCarList = new System.Windows.Forms.Button();
            this.btnWorkerList = new System.Windows.Forms.Button();
            this.btnClientList = new System.Windows.Forms.Button();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnExit);
            this.panel.Controls.Add(this.btnLogOut);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1015, 29);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.Location = new System.Drawing.Point(845, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 29);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(933, 0);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(82, 29);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCarList
            // 
            this.btnCarList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarList.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCarList.Image = ((System.Drawing.Image)(resources.GetObject("btnCarList.Image")));
            this.btnCarList.Location = new System.Drawing.Point(10, 40);
            this.btnCarList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCarList.Name = "btnCarList";
            this.btnCarList.Size = new System.Drawing.Size(462, 208);
            this.btnCarList.TabIndex = 1;
            this.btnCarList.Text = "Car List";
            this.btnCarList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarList.UseVisualStyleBackColor = true;
            this.btnCarList.Click += new System.EventHandler(this.btnCarList_Click);
            // 
            // btnWorkerList
            // 
            this.btnWorkerList.BackColor = System.Drawing.Color.White;
            this.btnWorkerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkerList.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWorkerList.ForeColor = System.Drawing.Color.Black;
            this.btnWorkerList.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkerList.Image")));
            this.btnWorkerList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWorkerList.Location = new System.Drawing.Point(519, 40);
            this.btnWorkerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWorkerList.Name = "btnWorkerList";
            this.btnWorkerList.Size = new System.Drawing.Size(467, 208);
            this.btnWorkerList.TabIndex = 2;
            this.btnWorkerList.Text = "Worker List";
            this.btnWorkerList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkerList.UseVisualStyleBackColor = false;
            this.btnWorkerList.Click += new System.EventHandler(this.btnWorkerList_Click);
            // 
            // btnClientList
            // 
            this.btnClientList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientList.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClientList.Image = ((System.Drawing.Image)(resources.GetObject("btnClientList.Image")));
            this.btnClientList.Location = new System.Drawing.Point(519, 274);
            this.btnClientList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientList.Name = "btnClientList";
            this.btnClientList.Size = new System.Drawing.Size(467, 206);
            this.btnClientList.TabIndex = 3;
            this.btnClientList.Text = "Client List";
            this.btnClientList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientList.UseVisualStyleBackColor = true;
            this.btnClientList.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOrderList
            // 
            this.btnOrderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderList.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrderList.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderList.Image")));
            this.btnOrderList.Location = new System.Drawing.Point(10, 274);
            this.btnOrderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(462, 206);
            this.btnOrderList.TabIndex = 4;
            this.btnOrderList.Text = "Order List";
            this.btnOrderList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderList.UseVisualStyleBackColor = true;
            this.btnOrderList.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 496);
            this.Controls.Add(this.btnClientList);
            this.Controls.Add(this.btnOrderList);
            this.Controls.Add(this.btnWorkerList);
            this.Controls.Add(this.btnCarList);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCarList;
        private System.Windows.Forms.Button btnWorkerList;
        private System.Windows.Forms.Button btnClientList;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnExit;
    }
}