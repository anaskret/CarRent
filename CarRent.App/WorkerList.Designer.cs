namespace car_fleet
{
    partial class WorkerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvWorkerList = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 32);
            this.panel1.TabIndex = 0;
            // 
            // lvWorkerList
            // 
            this.lvWorkerList.HideSelection = false;
            this.lvWorkerList.Location = new System.Drawing.Point(10, 37);
            this.lvWorkerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvWorkerList.Name = "lvWorkerList";
            this.lvWorkerList.Size = new System.Drawing.Size(1050, 278);
            this.lvWorkerList.TabIndex = 1;
            this.lvWorkerList.UseCompatibleStateImageBehavior = false;
            this.lvWorkerList.SelectedIndexChanged += new System.EventHandler(this.lvWorkerList_SelectedIndexChanged);
            this.lvWorkerList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvWorkerList_MouseDoubleClick);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(316, 352);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 107);
            this.button2.TabIndex = 2;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(554, 352);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 107);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Location = new System.Drawing.Point(116, 367);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 75);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // WorkerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 469);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lvWorkerList);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WorkerList";
            this.Text = "WorkerList";
            this.Load += new System.EventHandler(this.WorkerList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvWorkerList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnClose;
    }
}