namespace Project
{
    partial class AddOrUpdateCar
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAddData = new System.Windows.Forms.Label();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.tbxLicensePlate = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.lblEngine = new System.Windows.Forms.Label();
            this.tbxEngine = new System.Windows.Forms.TextBox();
            this.lblProductionYear = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbxTransmission = new System.Windows.Forms.ComboBox();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.rbtnDiesel = new System.Windows.Forms.RadioButton();
            this.rbtnGasoline = new System.Windows.Forms.RadioButton();
            this.rbtnGas = new System.Windows.Forms.RadioButton();
            this.lblPricePerDay = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numUpDownPricePerDay = new System.Windows.Forms.NumericUpDown();
            this.numUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.lblDot = new System.Windows.Forms.Label();
            this.numUpDownPricePerDayAfterComa = new System.Windows.Forms.NumericUpDown();
            this.lblZloty = new System.Windows.Forms.Label();
            this.numUpDownMileage = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPricePerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPricePerDayAfterComa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.Location = new System.Drawing.Point(180, 302);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(161, 71);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Cancel";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAddData
            // 
            this.lblAddData.AutoSize = true;
            this.lblAddData.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddData.Location = new System.Drawing.Point(289, 18);
            this.lblAddData.Name = "lblAddData";
            this.lblAddData.Size = new System.Drawing.Size(131, 37);
            this.lblAddData.TabIndex = 1;
            this.lblAddData.Text = "Add Data";
            this.lblAddData.Click += new System.EventHandler(this.lblAddData_Click);
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLicensePlate.Location = new System.Drawing.Point(12, 86);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(162, 20);
            this.lblLicensePlate.TabIndex = 2;
            this.lblLicensePlate.Text = "License Plate Number:";
            // 
            // tbxLicensePlate
            // 
            this.tbxLicensePlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxLicensePlate.Location = new System.Drawing.Point(180, 83);
            this.tbxLicensePlate.MaxLength = 8;
            this.tbxLicensePlate.Name = "tbxLicensePlate";
            this.tbxLicensePlate.Size = new System.Drawing.Size(161, 23);
            this.tbxLicensePlate.TabIndex = 4;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.Location = new System.Drawing.Point(12, 117);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(54, 20);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Brand:";
            this.lblBrand.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxBrand
            // 
            this.tbxBrand.Location = new System.Drawing.Point(180, 114);
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(161, 23);
            this.tbxBrand.TabIndex = 6;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(12, 147);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(57, 20);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model:";
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(180, 144);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(161, 23);
            this.tbxModel.TabIndex = 8;
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEngine.Location = new System.Drawing.Point(12, 179);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(60, 20);
            this.lblEngine.TabIndex = 9;
            this.lblEngine.Text = "Engine:";
            // 
            // tbxEngine
            // 
            this.tbxEngine.Location = new System.Drawing.Point(180, 176);
            this.tbxEngine.Name = "tbxEngine";
            this.tbxEngine.Size = new System.Drawing.Size(161, 23);
            this.tbxEngine.TabIndex = 10;
            // 
            // lblProductionYear
            // 
            this.lblProductionYear.AutoSize = true;
            this.lblProductionYear.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductionYear.Location = new System.Drawing.Point(12, 210);
            this.lblProductionYear.Name = "lblProductionYear";
            this.lblProductionYear.Size = new System.Drawing.Size(124, 20);
            this.lblProductionYear.TabIndex = 11;
            this.lblProductionYear.Text = "Production Year:";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTransmission.Location = new System.Drawing.Point(12, 241);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(100, 20);
            this.lblTransmission.TabIndex = 13;
            this.lblTransmission.Text = "Transmission:";
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFuelType.Location = new System.Drawing.Point(371, 178);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(78, 20);
            this.lblFuelType.TabIndex = 15;
            this.lblFuelType.Text = "Fuel Type:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColor.Location = new System.Drawing.Point(369, 86);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(51, 20);
            this.lblColor.TabIndex = 19;
            this.lblColor.Text = "Color:";
            // 
            // cbxTransmission
            // 
            this.cbxTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTransmission.FormattingEnabled = true;
            this.cbxTransmission.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.cbxTransmission.Location = new System.Drawing.Point(180, 238);
            this.cbxTransmission.Name = "cbxTransmission";
            this.cbxTransmission.Size = new System.Drawing.Size(161, 23);
            this.cbxTransmission.TabIndex = 20;
            // 
            // tbxColor
            // 
            this.tbxColor.Location = new System.Drawing.Point(537, 83);
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(161, 23);
            this.tbxColor.TabIndex = 21;
            // 
            // rbtnDiesel
            // 
            this.rbtnDiesel.AutoSize = true;
            this.rbtnDiesel.Checked = true;
            this.rbtnDiesel.Location = new System.Drawing.Point(539, 176);
            this.rbtnDiesel.Name = "rbtnDiesel";
            this.rbtnDiesel.Size = new System.Drawing.Size(56, 19);
            this.rbtnDiesel.TabIndex = 23;
            this.rbtnDiesel.TabStop = true;
            this.rbtnDiesel.Text = "Diesel";
            this.rbtnDiesel.UseVisualStyleBackColor = true;
            this.rbtnDiesel.Click += new System.EventHandler(this.rbtnDiesel_Click);
            // 
            // rbtnGasoline
            // 
            this.rbtnGasoline.AutoSize = true;
            this.rbtnGasoline.Location = new System.Drawing.Point(539, 201);
            this.rbtnGasoline.Name = "rbtnGasoline";
            this.rbtnGasoline.Size = new System.Drawing.Size(70, 19);
            this.rbtnGasoline.TabIndex = 24;
            this.rbtnGasoline.Text = "Gasoline";
            this.rbtnGasoline.UseVisualStyleBackColor = true;
            // 
            // rbtnGas
            // 
            this.rbtnGas.AutoSize = true;
            this.rbtnGas.Location = new System.Drawing.Point(539, 226);
            this.rbtnGas.Name = "rbtnGas";
            this.rbtnGas.Size = new System.Drawing.Size(44, 19);
            this.rbtnGas.TabIndex = 25;
            this.rbtnGas.Text = "Gas";
            this.rbtnGas.UseVisualStyleBackColor = true;
            // 
            // lblPricePerDay
            // 
            this.lblPricePerDay.AutoSize = true;
            this.lblPricePerDay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPricePerDay.Location = new System.Drawing.Point(369, 117);
            this.lblPricePerDay.Name = "lblPricePerDay";
            this.lblPricePerDay.Size = new System.Drawing.Size(104, 20);
            this.lblPricePerDay.TabIndex = 26;
            this.lblPricePerDay.Text = "Price Per Day:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMileage.Location = new System.Drawing.Point(369, 147);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(68, 20);
            this.lblMileage.TabIndex = 31;
            this.lblMileage.Text = "Mileage:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.Location = new System.Drawing.Point(371, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 71);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numUpDownPricePerDay
            // 
            this.numUpDownPricePerDay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numUpDownPricePerDay.Location = new System.Drawing.Point(537, 117);
            this.numUpDownPricePerDay.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDownPricePerDay.Name = "numUpDownPricePerDay";
            this.numUpDownPricePerDay.Size = new System.Drawing.Size(58, 23);
            this.numUpDownPricePerDay.TabIndex = 34;
            this.numUpDownPricePerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownPricePerDay.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numUpDownYear
            // 
            this.numUpDownYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numUpDownYear.Location = new System.Drawing.Point(180, 208);
            this.numUpDownYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numUpDownYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numUpDownYear.Name = "numUpDownYear";
            this.numUpDownYear.Size = new System.Drawing.Size(161, 23);
            this.numUpDownYear.TabIndex = 35;
            this.numUpDownYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lblDot
            // 
            this.lblDot.AutoSize = true;
            this.lblDot.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDot.Location = new System.Drawing.Point(599, 120);
            this.lblDot.Name = "lblDot";
            this.lblDot.Size = new System.Drawing.Size(13, 20);
            this.lblDot.TabIndex = 36;
            this.lblDot.Text = ".";
            // 
            // numUpDownPricePerDayAfterComa
            // 
            this.numUpDownPricePerDayAfterComa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numUpDownPricePerDayAfterComa.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownPricePerDayAfterComa.Location = new System.Drawing.Point(615, 117);
            this.numUpDownPricePerDayAfterComa.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numUpDownPricePerDayAfterComa.Name = "numUpDownPricePerDayAfterComa";
            this.numUpDownPricePerDayAfterComa.Size = new System.Drawing.Size(58, 23);
            this.numUpDownPricePerDayAfterComa.TabIndex = 34;
            this.numUpDownPricePerDayAfterComa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownPricePerDayAfterComa.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblZloty
            // 
            this.lblZloty.AutoSize = true;
            this.lblZloty.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblZloty.Location = new System.Drawing.Point(678, 120);
            this.lblZloty.Name = "lblZloty";
            this.lblZloty.Size = new System.Drawing.Size(20, 20);
            this.lblZloty.TabIndex = 37;
            this.lblZloty.Text = "zł";
            // 
            // numUpDownMileage
            // 
            this.numUpDownMileage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numUpDownMileage.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownMileage.Location = new System.Drawing.Point(537, 149);
            this.numUpDownMileage.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numUpDownMileage.Name = "numUpDownMileage";
            this.numUpDownMileage.Size = new System.Drawing.Size(161, 23);
            this.numUpDownMileage.TabIndex = 38;
            this.numUpDownMileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddOrUpdateCar
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 397);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPricePerDay);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.rbtnGas);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.rbtnDiesel);
            this.Controls.Add(this.rbtnGasoline);
            this.Controls.Add(this.numUpDownPricePerDay);
            this.Controls.Add(this.lblZloty);
            this.Controls.Add(this.numUpDownPricePerDayAfterComa);
            this.Controls.Add(this.lblDot);
            this.Controls.Add(this.tbxColor);
            this.Controls.Add(this.numUpDownMileage);
            this.Controls.Add(this.lblAddData);
            this.Controls.Add(this.numUpDownYear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxTransmission);
            this.Controls.Add(this.lblTransmission);
            this.Controls.Add(this.lblProductionYear);
            this.Controls.Add(this.tbxEngine);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.tbxBrand);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.tbxLicensePlate);
            this.Controls.Add(this.lblLicensePlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddOrUpdateCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCar";
            this.Load += new System.EventHandler(this.AddUpdateCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPricePerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPricePerDayAfterComa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMileage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAddData;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox tbxLicensePlate;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox tbxBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.TextBox tbxEngine;
        private System.Windows.Forms.Label lblProductionYear;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbxTransmission;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.RadioButton rbtnDiesel;
        private System.Windows.Forms.RadioButton rbtnGasoline;
        private System.Windows.Forms.RadioButton rbtnGas;
        private System.Windows.Forms.Label lblPricePerDay;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownPricePerDay;
        private System.Windows.Forms.NumericUpDown numUpDownYear;
        private System.Windows.Forms.NumericUpDown numUpDownPricePerDay;
        private System.Windows.Forms.Label lblDot;
        private System.Windows.Forms.NumericUpDown numUpDownPricePerDayAfterComa;
        private System.Windows.Forms.Label lblZloty;
        private System.Windows.Forms.NumericUpDown numUpDownMileage;
        private System.Windows.Forms.TextBox tbxColor;
    }
}