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
            this.combobxTransmission = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMinYear = new System.Windows.Forms.Label();
            this.numUpDownMinYear = new System.Windows.Forms.NumericUpDown();
            this.lblMaxYear = new System.Windows.Forms.Label();
            this.numUpDownMaxYear = new System.Windows.Forms.NumericUpDown();
            this.lblPricePerDay = new System.Windows.Forms.Label();
            this.lblMinPrice = new System.Windows.Forms.Label();
            this.numUpDownMinPrice = new System.Windows.Forms.NumericUpDown();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.numUpDownMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblMinMileage = new System.Windows.Forms.Label();
            this.numUpDownMinMileage = new System.Windows.Forms.NumericUpDown();
            this.lblMaxMileage = new System.Windows.Forms.Label();
            this.numUpDownMaxMileage = new System.Windows.Forms.NumericUpDown();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.tbxEngine = new System.Windows.Forms.TextBox();
            this.lblEngine = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // lvCarList
            // 
            this.lvCarList.BackColor = System.Drawing.Color.White;
            this.lvCarList.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.Location = new System.Drawing.Point(1063, 688);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(209, 70);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Close";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.Location = new System.Drawing.Point(1063, 79);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(209, 70);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Selected Car";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.Location = new System.Drawing.Point(1063, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(209, 70);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add a New Car";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.BackColor = System.Drawing.Color.White;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilter.Location = new System.Drawing.Point(1063, 226);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(44, 20);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Fliter";
            // 
            // combobxTransmission
            // 
            this.combobxTransmission.BackColor = System.Drawing.SystemColors.Control;
            this.combobxTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxTransmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combobxTransmission.FormattingEnabled = true;
            this.combobxTransmission.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.combobxTransmission.Location = new System.Drawing.Point(1160, 356);
            this.combobxTransmission.Name = "combobxTransmission";
            this.combobxTransmission.Size = new System.Drawing.Size(112, 23);
            this.combobxTransmission.TabIndex = 9;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.White;
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
            this.lblMinYear.BackColor = System.Drawing.Color.White;
            this.lblMinYear.Location = new System.Drawing.Point(1070, 413);
            this.lblMinYear.Name = "lblMinYear";
            this.lblMinYear.Size = new System.Drawing.Size(28, 15);
            this.lblMinYear.TabIndex = 11;
            this.lblMinYear.Text = "Min";
            // 
            // numUpDownMinYear
            // 
            this.numUpDownMinYear.BackColor = System.Drawing.Color.White;
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
            this.lblMaxYear.BackColor = System.Drawing.Color.White;
            this.lblMaxYear.Location = new System.Drawing.Point(1166, 413);
            this.lblMaxYear.Name = "lblMaxYear";
            this.lblMaxYear.Size = new System.Drawing.Size(30, 15);
            this.lblMaxYear.TabIndex = 13;
            this.lblMaxYear.Text = "Max";
            // 
            // numUpDownMaxYear
            // 
            this.numUpDownMaxYear.BackColor = System.Drawing.Color.White;
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
            this.lblPricePerDay.BackColor = System.Drawing.Color.White;
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
            this.lblMinPrice.BackColor = System.Drawing.Color.White;
            this.lblMinPrice.Location = new System.Drawing.Point(1070, 459);
            this.lblMinPrice.Name = "lblMinPrice";
            this.lblMinPrice.Size = new System.Drawing.Size(28, 15);
            this.lblMinPrice.TabIndex = 16;
            this.lblMinPrice.Text = "Min";
            // 
            // numUpDownMinPrice
            // 
            this.numUpDownMinPrice.BackColor = System.Drawing.Color.White;
            this.numUpDownMinPrice.Location = new System.Drawing.Point(1104, 457);
            this.numUpDownMinPrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDownMinPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownMinPrice.Name = "numUpDownMinPrice";
            this.numUpDownMinPrice.Size = new System.Drawing.Size(56, 23);
            this.numUpDownMinPrice.TabIndex = 17;
            this.numUpDownMinPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownMinPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.BackColor = System.Drawing.Color.White;
            this.lblMaxPrice.Location = new System.Drawing.Point(1166, 459);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(30, 15);
            this.lblMaxPrice.TabIndex = 18;
            this.lblMaxPrice.Text = "Max";
            // 
            // numUpDownMaxPrice
            // 
            this.numUpDownMaxPrice.BackColor = System.Drawing.Color.White;
            this.numUpDownMaxPrice.Location = new System.Drawing.Point(1202, 457);
            this.numUpDownMaxPrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDownMaxPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownMaxPrice.Name = "numUpDownMaxPrice";
            this.numUpDownMaxPrice.Size = new System.Drawing.Size(70, 23);
            this.numUpDownMaxPrice.TabIndex = 19;
            this.numUpDownMaxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownMaxPrice.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.BackColor = System.Drawing.Color.White;
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
            this.lblMinMileage.BackColor = System.Drawing.Color.White;
            this.lblMinMileage.Location = new System.Drawing.Point(1063, 505);
            this.lblMinMileage.Name = "lblMinMileage";
            this.lblMinMileage.Size = new System.Drawing.Size(28, 15);
            this.lblMinMileage.TabIndex = 21;
            this.lblMinMileage.Text = "Min";
            // 
            // numUpDownMinMileage
            // 
            this.numUpDownMinMileage.BackColor = System.Drawing.Color.White;
            this.numUpDownMinMileage.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownMinMileage.Location = new System.Drawing.Point(1100, 503);
            this.numUpDownMinMileage.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numUpDownMinMileage.Name = "numUpDownMinMileage";
            this.numUpDownMinMileage.Size = new System.Drawing.Size(60, 23);
            this.numUpDownMinMileage.TabIndex = 22;
            this.numUpDownMinMileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaxMileage
            // 
            this.lblMaxMileage.AutoSize = true;
            this.lblMaxMileage.BackColor = System.Drawing.Color.White;
            this.lblMaxMileage.Location = new System.Drawing.Point(1166, 505);
            this.lblMaxMileage.Name = "lblMaxMileage";
            this.lblMaxMileage.Size = new System.Drawing.Size(30, 15);
            this.lblMaxMileage.TabIndex = 23;
            this.lblMaxMileage.Text = "Max";
            // 
            // numUpDownMaxMileage
            // 
            this.numUpDownMaxMileage.BackColor = System.Drawing.Color.White;
            this.numUpDownMaxMileage.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownMaxMileage.Location = new System.Drawing.Point(1202, 503);
            this.numUpDownMaxMileage.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numUpDownMaxMileage.Name = "numUpDownMaxMileage";
            this.numUpDownMaxMileage.Size = new System.Drawing.Size(70, 23);
            this.numUpDownMaxMileage.TabIndex = 24;
            this.numUpDownMaxMileage.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilter.Location = new System.Drawing.Point(1063, 536);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(209, 70);
            this.btnFilter.TabIndex = 25;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresh.Location = new System.Drawing.Point(1063, 612);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(209, 70);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete1.Location = new System.Drawing.Point(1063, 153);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(209, 70);
            this.btnDelete1.TabIndex = 27;
            this.btnDelete1.Text = "Delete Selected Car";
            this.btnDelete1.UseVisualStyleBackColor = false;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.White;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.Location = new System.Drawing.Point(1063, 252);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(45, 19);
            this.lblBrand.TabIndex = 28;
            this.lblBrand.Text = "Brand";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.White;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(1063, 279);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(49, 19);
            this.lblModel.TabIndex = 29;
            this.lblModel.Text = "Model";
            // 
            // tbxBrand
            // 
            this.tbxBrand.BackColor = System.Drawing.Color.White;
            this.tbxBrand.Location = new System.Drawing.Point(1160, 251);
            this.tbxBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(112, 23);
            this.tbxBrand.TabIndex = 30;
            // 
            // tbxModel
            // 
            this.tbxModel.BackColor = System.Drawing.Color.White;
            this.tbxModel.Location = new System.Drawing.Point(1160, 278);
            this.tbxModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(112, 23);
            this.tbxModel.TabIndex = 31;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.White;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColor.Location = new System.Drawing.Point(1063, 306);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(43, 19);
            this.lblColor.TabIndex = 32;
            this.lblColor.Text = "Color";
            // 
            // tbxColor
            // 
            this.tbxColor.BackColor = System.Drawing.Color.White;
            this.tbxColor.Location = new System.Drawing.Point(1160, 305);
            this.tbxColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(112, 23);
            this.tbxColor.TabIndex = 33;
            // 
            // tbxEngine
            // 
            this.tbxEngine.BackColor = System.Drawing.Color.White;
            this.tbxEngine.Location = new System.Drawing.Point(1160, 330);
            this.tbxEngine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEngine.Name = "tbxEngine";
            this.tbxEngine.Size = new System.Drawing.Size(112, 23);
            this.tbxEngine.TabIndex = 34;
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.BackColor = System.Drawing.Color.White;
            this.lblEngine.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEngine.Location = new System.Drawing.Point(1063, 332);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(51, 19);
            this.lblEngine.TabIndex = 35;
            this.lblEngine.Text = "Engine";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.BackColor = System.Drawing.Color.White;
            this.lblTransmission.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTransmission.Location = new System.Drawing.Point(1063, 356);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(90, 19);
            this.lblTransmission.TabIndex = 36;
            this.lblTransmission.Text = "Transmission";
            // 
            // CarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.lblTransmission);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.tbxEngine);
            this.Controls.Add(this.tbxColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.tbxBrand);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.combobxTransmission);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMinYear);
            this.Controls.Add(this.numUpDownMinYear);
            this.Controls.Add(this.numUpDownMaxYear);
            this.Controls.Add(this.lblPricePerDay);
            this.Controls.Add(this.numUpDownMinPrice);
            this.Controls.Add(this.lblMinPrice);
            this.Controls.Add(this.numUpDownMaxPrice);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.numUpDownMinMileage);
            this.Controls.Add(this.lblMaxYear);
            this.Controls.Add(this.lblMaxPrice);
            this.Controls.Add(this.lblMaxMileage);
            this.Controls.Add(this.lblMinMileage);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numUpDownMaxMileage);
            this.Controls.Add(this.lvCarList);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CarList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarList";
            this.Load += new System.EventHandler(this.CarList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxMileage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCarList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox combobxTransmission;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMinYear;
        private System.Windows.Forms.NumericUpDown numUpDownMinYear;
        private System.Windows.Forms.Label lblMaxYear;
        private System.Windows.Forms.NumericUpDown numUpDownMaxYear;
        private System.Windows.Forms.Label lblPricePerDay;
        private System.Windows.Forms.Label lblMinPrice;
        private System.Windows.Forms.NumericUpDown numUpDownMinPrice;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.NumericUpDown numUpDownMaxPrice;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblMinMileage;
        private System.Windows.Forms.NumericUpDown numUpDownMinMileage;
        private System.Windows.Forms.Label lblMaxMileage;
        private System.Windows.Forms.NumericUpDown numUpDownMaxMileage;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbxBrand;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.TextBox tbxEngine;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.Label lblTransmission;
    }
}