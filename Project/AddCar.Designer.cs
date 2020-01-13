namespace Project
{
    partial class AddCar
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
            this.tbLicensePlateFirstThree = new System.Windows.Forms.TextBox();
            this.tbLicensePlateRest = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lblEngine = new System.Windows.Forms.Label();
            this.tbEngine = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.lblCaretaker = new System.Windows.Forms.Label();
            this.cbxCaretaker = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbxTransmission = new System.Windows.Forms.ComboBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.btnDate = new System.Windows.Forms.Button();
            this.rbtnDiesel = new System.Windows.Forms.RadioButton();
            this.rbtnGasoline = new System.Windows.Forms.RadioButton();
            this.rbtnGas = new System.Windows.Forms.RadioButton();
            this.lblPricePerDay = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxIsDamaged = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblMileage = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(180, 336);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(161, 71);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAddData
            // 
            this.lblAddData.AutoSize = true;
            this.lblAddData.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddData.Location = new System.Drawing.Point(289, 9);
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
            // tbLicensePlateFirstThree
            // 
            this.tbLicensePlateFirstThree.Location = new System.Drawing.Point(180, 83);
            this.tbLicensePlateFirstThree.Name = "tbLicensePlateFirstThree";
            this.tbLicensePlateFirstThree.Size = new System.Drawing.Size(35, 23);
            this.tbLicensePlateFirstThree.TabIndex = 3;
            // 
            // tbLicensePlateRest
            // 
            this.tbLicensePlateRest.Location = new System.Drawing.Point(221, 83);
            this.tbLicensePlateRest.Name = "tbLicensePlateRest";
            this.tbLicensePlateRest.Size = new System.Drawing.Size(120, 23);
            this.tbLicensePlateRest.TabIndex = 4;
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
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(180, 114);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(161, 23);
            this.tbBrand.TabIndex = 6;
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
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(180, 144);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(161, 23);
            this.tbModel.TabIndex = 8;
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
            // tbEngine
            // 
            this.tbEngine.Location = new System.Drawing.Point(180, 176);
            this.tbEngine.Name = "tbEngine";
            this.tbEngine.Size = new System.Drawing.Size(161, 23);
            this.tbEngine.TabIndex = 10;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(12, 210);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(44, 20);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "Year:";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(180, 207);
            this.tbYear.Name = "tbYear";
            this.tbYear.ReadOnly = true;
            this.tbYear.Size = new System.Drawing.Size(103, 23);
            this.tbYear.TabIndex = 12;
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
            this.lblFuelType.Location = new System.Drawing.Point(371, 210);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(78, 20);
            this.lblFuelType.TabIndex = 15;
            this.lblFuelType.Text = "Fuel Type:";
            // 
            // lblCaretaker
            // 
            this.lblCaretaker.AutoSize = true;
            this.lblCaretaker.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaretaker.Location = new System.Drawing.Point(369, 86);
            this.lblCaretaker.Name = "lblCaretaker";
            this.lblCaretaker.Size = new System.Drawing.Size(80, 20);
            this.lblCaretaker.TabIndex = 17;
            this.lblCaretaker.Text = "Caretaker:";
            // 
            // cbxCaretaker
            // 
            this.cbxCaretaker.FormattingEnabled = true;
            this.cbxCaretaker.Location = new System.Drawing.Point(537, 83);
            this.cbxCaretaker.Name = "cbxCaretaker";
            this.cbxCaretaker.Size = new System.Drawing.Size(161, 23);
            this.cbxCaretaker.TabIndex = 18;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColor.Location = new System.Drawing.Point(369, 118);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(51, 20);
            this.lblColor.TabIndex = 19;
            this.lblColor.Text = "Color:";
            // 
            // cbxTransmission
            // 
            this.cbxTransmission.FormattingEnabled = true;
            this.cbxTransmission.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.cbxTransmission.Location = new System.Drawing.Point(180, 238);
            this.cbxTransmission.Name = "cbxTransmission";
            this.cbxTransmission.Size = new System.Drawing.Size(161, 23);
            this.cbxTransmission.TabIndex = 20;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(537, 115);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(161, 23);
            this.tbColor.TabIndex = 21;
            // 
            // btnDate
            // 
            this.btnDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDate.Location = new System.Drawing.Point(289, 207);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(52, 23);
            this.btnDate.TabIndex = 22;
            this.btnDate.Text = "Date";
            this.btnDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDate.UseVisualStyleBackColor = true;
            // 
            // rbtnDiesel
            // 
            this.rbtnDiesel.AutoSize = true;
            this.rbtnDiesel.Location = new System.Drawing.Point(539, 208);
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
            this.rbtnGasoline.Location = new System.Drawing.Point(539, 233);
            this.rbtnGasoline.Name = "rbtnGasoline";
            this.rbtnGasoline.Size = new System.Drawing.Size(70, 19);
            this.rbtnGasoline.TabIndex = 24;
            this.rbtnGasoline.TabStop = true;
            this.rbtnGasoline.Text = "Gasoline";
            this.rbtnGasoline.UseVisualStyleBackColor = true;
            // 
            // rbtnGas
            // 
            this.rbtnGas.AutoSize = true;
            this.rbtnGas.Location = new System.Drawing.Point(539, 258);
            this.rbtnGas.Name = "rbtnGas";
            this.rbtnGas.Size = new System.Drawing.Size(44, 19);
            this.rbtnGas.TabIndex = 25;
            this.rbtnGas.TabStop = true;
            this.rbtnGas.Text = "Gas";
            this.rbtnGas.UseVisualStyleBackColor = true;
            // 
            // lblPricePerDay
            // 
            this.lblPricePerDay.AutoSize = true;
            this.lblPricePerDay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPricePerDay.Location = new System.Drawing.Point(369, 149);
            this.lblPricePerDay.Name = "lblPricePerDay";
            this.lblPricePerDay.Size = new System.Drawing.Size(104, 20);
            this.lblPricePerDay.TabIndex = 26;
            this.lblPricePerDay.Text = "Price Per Day:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(537, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 23);
            this.textBox1.TabIndex = 27;
            // 
            // cbxIsDamaged
            // 
            this.cbxIsDamaged.AutoSize = true;
            this.cbxIsDamaged.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxIsDamaged.Location = new System.Drawing.Point(396, 288);
            this.cbxIsDamaged.Name = "cbxIsDamaged";
            this.cbxIsDamaged.Size = new System.Drawing.Size(115, 24);
            this.cbxIsDamaged.TabIndex = 29;
            this.cbxIsDamaged.Text = "Is Damaged?";
            this.cbxIsDamaged.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(221, 288);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 24);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Is Away?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMileage.Location = new System.Drawing.Point(369, 179);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(68, 20);
            this.lblMileage.TabIndex = 31;
            this.lblMileage.Text = "Mileage:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(537, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 23);
            this.textBox2.TabIndex = 32;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(375, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 71);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 441);
            this.Controls.Add(this.cbxIsDamaged);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAddData);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbxCaretaker);
            this.Controls.Add(this.rbtnGasoline);
            this.Controls.Add(this.rbtnDiesel);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.rbtnGas);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPricePerDay);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCaretaker);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.cbxTransmission);
            this.Controls.Add(this.lblTransmission);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.tbEngine);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.tbLicensePlateRest);
            this.Controls.Add(this.tbLicensePlateFirstThree);
            this.Controls.Add(this.lblLicensePlate);
            this.Name = "AddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAddData;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox tbLicensePlateFirstThree;
        private System.Windows.Forms.TextBox tbLicensePlateRest;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.TextBox tbEngine;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label lblCaretaker;
        private System.Windows.Forms.ComboBox cbxCaretaker;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbxTransmission;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.RadioButton rbtnDiesel;
        private System.Windows.Forms.RadioButton rbtnGasoline;
        private System.Windows.Forms.RadioButton rbtnGas;
        private System.Windows.Forms.Label lblPricePerDay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbxIsDamaged;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAdd;
    }
}