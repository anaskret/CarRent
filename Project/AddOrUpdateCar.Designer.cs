﻿namespace Project
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
            this.tbLicensePlate = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lblEngine = new System.Windows.Forms.Label();
            this.tbEngine = new System.Windows.Forms.TextBox();
            this.lblProductionYear = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.lblCaretaker = new System.Windows.Forms.Label();
            this.cbxCaretaker = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbxTransmission = new System.Windows.Forms.ComboBox();
            this.tbColor = new System.Windows.Forms.TextBox();
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
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(206, 403);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(184, 95);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Cancel";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAddData
            // 
            this.lblAddData.AutoSize = true;
            this.lblAddData.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddData.Location = new System.Drawing.Point(330, 24);
            this.lblAddData.Name = "lblAddData";
            this.lblAddData.Size = new System.Drawing.Size(164, 46);
            this.lblAddData.TabIndex = 1;
            this.lblAddData.Text = "Add Data";
            this.lblAddData.Click += new System.EventHandler(this.lblAddData_Click);
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLicensePlate.Location = new System.Drawing.Point(14, 115);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(204, 25);
            this.lblLicensePlate.TabIndex = 2;
            this.lblLicensePlate.Text = "License Plate Number:";
            // 
            // tbLicensePlate
            // 
            this.tbLicensePlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbLicensePlate.Location = new System.Drawing.Point(206, 111);
            this.tbLicensePlate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLicensePlate.MaxLength = 8;
            this.tbLicensePlate.Name = "tbLicensePlate";
            this.tbLicensePlate.Size = new System.Drawing.Size(183, 27);
            this.tbLicensePlate.TabIndex = 4;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.Location = new System.Drawing.Point(14, 156);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(67, 25);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Brand:";
            this.lblBrand.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(206, 152);
            this.tbBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(183, 27);
            this.tbBrand.TabIndex = 6;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(14, 196);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(72, 25);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model:";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(206, 192);
            this.tbModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(183, 27);
            this.tbModel.TabIndex = 8;
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEngine.Location = new System.Drawing.Point(14, 239);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(75, 25);
            this.lblEngine.TabIndex = 9;
            this.lblEngine.Text = "Engine:";
            // 
            // tbEngine
            // 
            this.tbEngine.Location = new System.Drawing.Point(206, 235);
            this.tbEngine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEngine.Name = "tbEngine";
            this.tbEngine.Size = new System.Drawing.Size(183, 27);
            this.tbEngine.TabIndex = 10;
            // 
            // lblProductionYear
            // 
            this.lblProductionYear.AutoSize = true;
            this.lblProductionYear.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductionYear.Location = new System.Drawing.Point(14, 280);
            this.lblProductionYear.Name = "lblProductionYear";
            this.lblProductionYear.Size = new System.Drawing.Size(153, 25);
            this.lblProductionYear.TabIndex = 11;
            this.lblProductionYear.Text = "Production Year:";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTransmission.Location = new System.Drawing.Point(14, 321);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(126, 25);
            this.lblTransmission.TabIndex = 13;
            this.lblTransmission.Text = "Transmission:";
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFuelType.Location = new System.Drawing.Point(424, 280);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(98, 25);
            this.lblFuelType.TabIndex = 15;
            this.lblFuelType.Text = "Fuel Type:";
            // 
            // lblCaretaker
            // 
            this.lblCaretaker.AutoSize = true;
            this.lblCaretaker.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaretaker.Location = new System.Drawing.Point(422, 115);
            this.lblCaretaker.Name = "lblCaretaker";
            this.lblCaretaker.Size = new System.Drawing.Size(101, 25);
            this.lblCaretaker.TabIndex = 17;
            this.lblCaretaker.Text = "Caretaker:";
            // 
            // cbxCaretaker
            // 
            this.cbxCaretaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCaretaker.FormattingEnabled = true;
            this.cbxCaretaker.Location = new System.Drawing.Point(614, 111);
            this.cbxCaretaker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCaretaker.Name = "cbxCaretaker";
            this.cbxCaretaker.Size = new System.Drawing.Size(183, 28);
            this.cbxCaretaker.TabIndex = 18;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColor.Location = new System.Drawing.Point(422, 157);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(64, 25);
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
            this.cbxTransmission.Location = new System.Drawing.Point(206, 317);
            this.cbxTransmission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxTransmission.Name = "cbxTransmission";
            this.cbxTransmission.Size = new System.Drawing.Size(183, 28);
            this.cbxTransmission.TabIndex = 20;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(614, 153);
            this.tbColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(183, 27);
            this.tbColor.TabIndex = 21;
            // 
            // rbtnDiesel
            // 
            this.rbtnDiesel.AutoSize = true;
            this.rbtnDiesel.Location = new System.Drawing.Point(616, 277);
            this.rbtnDiesel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnDiesel.Name = "rbtnDiesel";
            this.rbtnDiesel.Size = new System.Drawing.Size(71, 24);
            this.rbtnDiesel.TabIndex = 23;
            this.rbtnDiesel.TabStop = true;
            this.rbtnDiesel.Text = "Diesel";
            this.rbtnDiesel.UseVisualStyleBackColor = true;
            this.rbtnDiesel.Click += new System.EventHandler(this.rbtnDiesel_Click);
            // 
            // rbtnGasoline
            // 
            this.rbtnGasoline.AutoSize = true;
            this.rbtnGasoline.Location = new System.Drawing.Point(616, 311);
            this.rbtnGasoline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnGasoline.Name = "rbtnGasoline";
            this.rbtnGasoline.Size = new System.Drawing.Size(87, 24);
            this.rbtnGasoline.TabIndex = 24;
            this.rbtnGasoline.TabStop = true;
            this.rbtnGasoline.Text = "Gasoline";
            this.rbtnGasoline.UseVisualStyleBackColor = true;
            // 
            // rbtnGas
            // 
            this.rbtnGas.AutoSize = true;
            this.rbtnGas.Location = new System.Drawing.Point(616, 344);
            this.rbtnGas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnGas.Name = "rbtnGas";
            this.rbtnGas.Size = new System.Drawing.Size(54, 24);
            this.rbtnGas.TabIndex = 25;
            this.rbtnGas.TabStop = true;
            this.rbtnGas.Text = "Gas";
            this.rbtnGas.UseVisualStyleBackColor = true;
            // 
            // lblPricePerDay
            // 
            this.lblPricePerDay.AutoSize = true;
            this.lblPricePerDay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPricePerDay.Location = new System.Drawing.Point(422, 199);
            this.lblPricePerDay.Name = "lblPricePerDay";
            this.lblPricePerDay.Size = new System.Drawing.Size(130, 25);
            this.lblPricePerDay.TabIndex = 26;
            this.lblPricePerDay.Text = "Price Per Day:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMileage.Location = new System.Drawing.Point(422, 239);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(86, 25);
            this.lblMileage.TabIndex = 31;
            this.lblMileage.Text = "Mileage:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(424, 403);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 95);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numUpDownPricePerDay
            // 
            this.numUpDownPricePerDay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numUpDownPricePerDay.Location = new System.Drawing.Point(614, 199);
            this.numUpDownPricePerDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numUpDownPricePerDay.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDownPricePerDay.Name = "numUpDownPricePerDay";
            this.numUpDownPricePerDay.Size = new System.Drawing.Size(66, 27);
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
            this.numUpDownYear.Location = new System.Drawing.Point(206, 277);
            this.numUpDownYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numUpDownYear.Size = new System.Drawing.Size(184, 27);
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
            this.lblDot.Location = new System.Drawing.Point(685, 203);
            this.lblDot.Name = "lblDot";
            this.lblDot.Size = new System.Drawing.Size(17, 25);
            this.lblDot.TabIndex = 36;
            this.lblDot.Text = ".";
            // 
            // numUpDownPricePerDayAfterComa
            // 
            this.numUpDownPricePerDayAfterComa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numUpDownPricePerDayAfterComa.Location = new System.Drawing.Point(703, 199);
            this.numUpDownPricePerDayAfterComa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numUpDownPricePerDayAfterComa.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numUpDownPricePerDayAfterComa.Name = "numUpDownPricePerDayAfterComa";
            this.numUpDownPricePerDayAfterComa.Size = new System.Drawing.Size(66, 27);
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
            this.lblZloty.Location = new System.Drawing.Point(775, 203);
            this.lblZloty.Name = "lblZloty";
            this.lblZloty.Size = new System.Drawing.Size(27, 25);
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
            this.numUpDownMileage.Location = new System.Drawing.Point(614, 241);
            this.numUpDownMileage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numUpDownMileage.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numUpDownMileage.Name = "numUpDownMileage";
            this.numUpDownMileage.Size = new System.Drawing.Size(184, 27);
            this.numUpDownMileage.TabIndex = 38;
            this.numUpDownMileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddOrUpdateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 529);
            this.Controls.Add(this.numUpDownMileage);
            this.Controls.Add(this.lblDot);
            this.Controls.Add(this.numUpDownPricePerDayAfterComa);
            this.Controls.Add(this.lblZloty);
            this.Controls.Add(this.numUpDownPricePerDay);
            this.Controls.Add(this.lblAddData);
            this.Controls.Add(this.numUpDownYear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxCaretaker);
            this.Controls.Add(this.rbtnGasoline);
            this.Controls.Add(this.rbtnDiesel);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.rbtnGas);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblPricePerDay);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCaretaker);
            this.Controls.Add(this.cbxTransmission);
            this.Controls.Add(this.lblTransmission);
            this.Controls.Add(this.lblProductionYear);
            this.Controls.Add(this.tbEngine);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.tbLicensePlate);
            this.Controls.Add(this.lblLicensePlate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddOrUpdateCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCar";
            this.Load += new System.EventHandler(this.AddUpdateCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPricePerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPricePerDayAfterComa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMileage)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAddData;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox tbLicensePlate;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.TextBox tbEngine;
        private System.Windows.Forms.Label lblProductionYear;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label lblCaretaker;
        private System.Windows.Forms.ComboBox cbxCaretaker;
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
    }
}