namespace Project
{
    partial class CarList
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
            this.lvCarList = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.combobxBrand = new System.Windows.Forms.ComboBox();
            this.combobxModel = new System.Windows.Forms.ComboBox();
            this.combobxColor = new System.Windows.Forms.ComboBox();
            this.combobxEngine = new System.Windows.Forms.ComboBox();
            this.combobxTransmission = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMinYear = new System.Windows.Forms.Label();
            this.numUpDownMinYear = new System.Windows.Forms.NumericUpDown();
            this.lblMaxYear = new System.Windows.Forms.Label();
            this.numUpDownMaxYear = new System.Windows.Forms.NumericUpDown();
            this.lblPricePerDay = new System.Windows.Forms.Label();
            this.lblMinPrice = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblMinMileage = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblMaxMileage = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // lvCarList
            // 
            this.lvCarList.HideSelection = false;
            this.lvCarList.Location = new System.Drawing.Point(2, 3);
            this.lvCarList.Name = "lvCarList";
            this.lvCarList.Size = new System.Drawing.Size(1055, 755);
            this.lvCarList.TabIndex = 0;
            this.lvCarList.UseCompatibleStateImageBehavior = false;
            this.lvCarList.DoubleClick += new System.EventHandler(this.lvCarList_DoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(1063, 688);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(209, 70);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Close";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(1063, 79);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(209, 70);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Selected Car";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(1063, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(209, 70);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add a New Car";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilter.Location = new System.Drawing.Point(1063, 226);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(44, 20);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Fliter";
            // 
            // combobxBrand
            // 
            this.combobxBrand.FormattingEnabled = true;
            this.combobxBrand.Location = new System.Drawing.Point(1063, 249);
            this.combobxBrand.Name = "combobxBrand";
            this.combobxBrand.Size = new System.Drawing.Size(209, 23);
            this.combobxBrand.TabIndex = 5;
            this.combobxBrand.Text = "Brand";
            // 
            // combobxModel
            // 
            this.combobxModel.FormattingEnabled = true;
            this.combobxModel.Location = new System.Drawing.Point(1063, 278);
            this.combobxModel.Name = "combobxModel";
            this.combobxModel.Size = new System.Drawing.Size(209, 23);
            this.combobxModel.TabIndex = 6;
            this.combobxModel.Text = "Model";
            // 
            // combobxColor
            // 
            this.combobxColor.FormattingEnabled = true;
            this.combobxColor.Location = new System.Drawing.Point(1063, 307);
            this.combobxColor.Name = "combobxColor";
            this.combobxColor.Size = new System.Drawing.Size(209, 23);
            this.combobxColor.TabIndex = 7;
            this.combobxColor.Text = "Color";
            // 
            // combobxEngine
            // 
            this.combobxEngine.FormattingEnabled = true;
            this.combobxEngine.Location = new System.Drawing.Point(1063, 336);
            this.combobxEngine.Name = "combobxEngine";
            this.combobxEngine.Size = new System.Drawing.Size(209, 23);
            this.combobxEngine.TabIndex = 8;
            this.combobxEngine.Text = "Engine";
            // 
            // combobxTransmission
            // 
            this.combobxTransmission.FormattingEnabled = true;
            this.combobxTransmission.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.combobxTransmission.Location = new System.Drawing.Point(1063, 365);
            this.combobxTransmission.Name = "combobxTransmission";
            this.combobxTransmission.Size = new System.Drawing.Size(209, 23);
            this.combobxTransmission.TabIndex = 9;
            this.combobxTransmission.Text = "Transmission";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(1063, 391);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(109, 17);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "Produciton Year:";
            // 
            // lblMinYear
            // 
            this.lblMinYear.AutoSize = true;
            this.lblMinYear.Location = new System.Drawing.Point(1070, 413);
            this.lblMinYear.Name = "lblMinYear";
            this.lblMinYear.Size = new System.Drawing.Size(28, 15);
            this.lblMinYear.TabIndex = 11;
            this.lblMinYear.Text = "Min";
            // 
            // numUpDownMinYear
            // 
            this.numUpDownMinYear.Location = new System.Drawing.Point(1104, 411);
            this.numUpDownMinYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numUpDownMinYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numUpDownMinYear.Name = "numUpDownMinYear";
            this.numUpDownMinYear.Size = new System.Drawing.Size(56, 23);
            this.numUpDownMinYear.TabIndex = 12;
            this.numUpDownMinYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownMinYear.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // lblMaxYear
            // 
            this.lblMaxYear.AutoSize = true;
            this.lblMaxYear.Location = new System.Drawing.Point(1166, 413);
            this.lblMaxYear.Name = "lblMaxYear";
            this.lblMaxYear.Size = new System.Drawing.Size(30, 15);
            this.lblMaxYear.TabIndex = 13;
            this.lblMaxYear.Text = "Max";
            // 
            // numUpDownMaxYear
            // 
            this.numUpDownMaxYear.Location = new System.Drawing.Point(1202, 411);
            this.numUpDownMaxYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numUpDownMaxYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numUpDownMaxYear.Name = "numUpDownMaxYear";
            this.numUpDownMaxYear.Size = new System.Drawing.Size(70, 23);
            this.numUpDownMaxYear.TabIndex = 14;
            this.numUpDownMaxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownMaxYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // lblPricePerDay
            // 
            this.lblPricePerDay.AutoSize = true;
            this.lblPricePerDay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPricePerDay.Location = new System.Drawing.Point(1063, 437);
            this.lblPricePerDay.Name = "lblPricePerDay";
            this.lblPricePerDay.Size = new System.Drawing.Size(91, 17);
            this.lblPricePerDay.TabIndex = 15;
            this.lblPricePerDay.Text = "Price Per Day:";
            // 
            // lblMinPrice
            // 
            this.lblMinPrice.AutoSize = true;
            this.lblMinPrice.Location = new System.Drawing.Point(1070, 459);
            this.lblMinPrice.Name = "lblMinPrice";
            this.lblMinPrice.Size = new System.Drawing.Size(28, 15);
            this.lblMinPrice.TabIndex = 16;
            this.lblMinPrice.Text = "Min";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(1104, 457);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(56, 23);
            this.numericUpDown3.TabIndex = 17;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Location = new System.Drawing.Point(1166, 459);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(30, 15);
            this.lblMaxPrice.TabIndex = 18;
            this.lblMaxPrice.Text = "Max";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1202, 457);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 23);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMileage.Location = new System.Drawing.Point(1063, 483);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(58, 17);
            this.lblMileage.TabIndex = 20;
            this.lblMileage.Text = "Mileage:";
            // 
            // lblMinMileage
            // 
            this.lblMinMileage.AutoSize = true;
            this.lblMinMileage.Location = new System.Drawing.Point(1063, 505);
            this.lblMinMileage.Name = "lblMinMileage";
            this.lblMinMileage.Size = new System.Drawing.Size(28, 15);
            this.lblMinMileage.TabIndex = 21;
            this.lblMinMileage.Text = "Min";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(1100, 503);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown2.TabIndex = 22;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaxMileage
            // 
            this.lblMaxMileage.AutoSize = true;
            this.lblMaxMileage.Location = new System.Drawing.Point(1166, 505);
            this.lblMaxMileage.Name = "lblMaxMileage";
            this.lblMaxMileage.Size = new System.Drawing.Size(30, 15);
            this.lblMaxMileage.TabIndex = 23;
            this.lblMaxMileage.Text = "Max";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Location = new System.Drawing.Point(1202, 503);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(70, 23);
            this.numericUpDown4.TabIndex = 24;
            this.numericUpDown4.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.Location = new System.Drawing.Point(1063, 536);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(209, 70);
            this.btnFilter.TabIndex = 25;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(1063, 612);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(209, 70);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete1.Location = new System.Drawing.Point(1063, 153);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(209, 70);
            this.btnDelete1.TabIndex = 27;
            this.btnDelete1.Text = "Delete Selected Car";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // CarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.combobxBrand);
            this.Controls.Add(this.combobxModel);
            this.Controls.Add(this.combobxColor);
            this.Controls.Add(this.combobxEngine);
            this.Controls.Add(this.combobxTransmission);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMinYear);
            this.Controls.Add(this.numUpDownMinYear);
            this.Controls.Add(this.numUpDownMaxYear);
            this.Controls.Add(this.lblPricePerDay);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.lblMinPrice);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.lblMaxYear);
            this.Controls.Add(this.lblMaxPrice);
            this.Controls.Add(this.lblMaxMileage);
            this.Controls.Add(this.lblMinMileage);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.lvCarList);
            this.Name = "CarList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarList";
            this.Load += new System.EventHandler(this.CarList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCarList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox combobxBrand;
        private System.Windows.Forms.ComboBox combobxModel;
        private System.Windows.Forms.ComboBox combobxColor;
        private System.Windows.Forms.ComboBox combobxEngine;
        private System.Windows.Forms.ComboBox combobxTransmission;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMinYear;
        private System.Windows.Forms.NumericUpDown numUpDownMinYear;
        private System.Windows.Forms.Label lblMaxYear;
        private System.Windows.Forms.NumericUpDown numUpDownMaxYear;
        private System.Windows.Forms.Label lblPricePerDay;
        private System.Windows.Forms.Label lblMinPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblMinMileage;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblMaxMileage;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete1;
    }
}