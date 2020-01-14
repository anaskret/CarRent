namespace Project
{
    partial class UpdateCar
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
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.tbLicensePlateRest = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lblEngine = new System.Windows.Forms.Label();
            this.tbEngine = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTrasnsmission = new System.Windows.Forms.Label();
            this.combobxTransmission = new System.Windows.Forms.ComboBox();
            this.lblCaretaker = new System.Windows.Forms.Label();
            this.tbLicensePlateFirstThree = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPricePerDay = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.tbMileage = new System.Windows.Forms.TextBox();
            this.rbtnGas = new System.Windows.Forms.RadioButton();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.rbtnDiesel = new System.Windows.Forms.RadioButton();
            this.tbtnGasoline = new System.Windows.Forms.RadioButton();
            this.combobxCaretaker = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.numUpDownPricePerDay = new System.Windows.Forms.NumericUpDown();
            this.checkbxIsDamaged = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lblUpdateCar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPricePerDay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLicensePlate.Location = new System.Drawing.Point(10, 74);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(162, 20);
            this.lblLicensePlate.TabIndex = 2;
            this.lblLicensePlate.Text = "License Plate Number:";
            this.lblLicensePlate.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbLicensePlateRest
            // 
            this.tbLicensePlateRest.Location = new System.Drawing.Point(219, 71);
            this.tbLicensePlateRest.MaxLength = 5;
            this.tbLicensePlateRest.Name = "tbLicensePlateRest";
            this.tbLicensePlateRest.Size = new System.Drawing.Size(120, 23);
            this.tbLicensePlateRest.TabIndex = 4;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.Location = new System.Drawing.Point(10, 105);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(54, 20);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Brand:";
            this.lblBrand.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(10, 135);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(57, 20);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model:";
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(178, 102);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(161, 23);
            this.tbBrand.TabIndex = 6;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(178, 132);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(161, 23);
            this.tbModel.TabIndex = 8;
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEngine.Location = new System.Drawing.Point(10, 167);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(60, 20);
            this.lblEngine.TabIndex = 9;
            this.lblEngine.Text = "Engine:";
            // 
            // tbEngine
            // 
            this.tbEngine.Location = new System.Drawing.Point(178, 164);
            this.tbEngine.Name = "tbEngine";
            this.tbEngine.Size = new System.Drawing.Size(161, 23);
            this.tbEngine.TabIndex = 10;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(10, 198);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(124, 20);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "Production Year:";
            // 
            // lblTrasnsmission
            // 
            this.lblTrasnsmission.AutoSize = true;
            this.lblTrasnsmission.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrasnsmission.Location = new System.Drawing.Point(10, 229);
            this.lblTrasnsmission.Name = "lblTrasnsmission";
            this.lblTrasnsmission.Size = new System.Drawing.Size(100, 20);
            this.lblTrasnsmission.TabIndex = 13;
            this.lblTrasnsmission.Text = "Transmission:";
            // 
            // combobxTransmission
            // 
            this.combobxTransmission.FormattingEnabled = true;
            this.combobxTransmission.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.combobxTransmission.Location = new System.Drawing.Point(178, 226);
            this.combobxTransmission.Name = "combobxTransmission";
            this.combobxTransmission.Size = new System.Drawing.Size(161, 23);
            this.combobxTransmission.TabIndex = 20;
            // 
            // lblCaretaker
            // 
            this.lblCaretaker.AutoSize = true;
            this.lblCaretaker.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaretaker.Location = new System.Drawing.Point(367, 74);
            this.lblCaretaker.Name = "lblCaretaker";
            this.lblCaretaker.Size = new System.Drawing.Size(80, 20);
            this.lblCaretaker.TabIndex = 17;
            this.lblCaretaker.Text = "Caretaker:";
            // 
            // tbLicensePlateFirstThree
            // 
            this.tbLicensePlateFirstThree.Location = new System.Drawing.Point(178, 71);
            this.tbLicensePlateFirstThree.MaxLength = 3;
            this.tbLicensePlateFirstThree.Name = "tbLicensePlateFirstThree";
            this.tbLicensePlateFirstThree.Size = new System.Drawing.Size(35, 23);
            this.tbLicensePlateFirstThree.TabIndex = 3;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColor.Location = new System.Drawing.Point(367, 106);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(51, 20);
            this.lblColor.TabIndex = 19;
            this.lblColor.Text = "Color:";
            // 
            // lblPricePerDay
            // 
            this.lblPricePerDay.AutoSize = true;
            this.lblPricePerDay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPricePerDay.Location = new System.Drawing.Point(367, 137);
            this.lblPricePerDay.Name = "lblPricePerDay";
            this.lblPricePerDay.Size = new System.Drawing.Size(104, 20);
            this.lblPricePerDay.TabIndex = 26;
            this.lblPricePerDay.Text = "Price Per Day:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMileage.Location = new System.Drawing.Point(367, 167);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(68, 20);
            this.lblMileage.TabIndex = 31;
            this.lblMileage.Text = "Mileage:";
            // 
            // tbMileage
            // 
            this.tbMileage.Location = new System.Drawing.Point(535, 164);
            this.tbMileage.Name = "tbMileage";
            this.tbMileage.Size = new System.Drawing.Size(161, 23);
            this.tbMileage.TabIndex = 32;
            // 
            // rbtnGas
            // 
            this.rbtnGas.AutoSize = true;
            this.rbtnGas.Location = new System.Drawing.Point(537, 246);
            this.rbtnGas.Name = "rbtnGas";
            this.rbtnGas.Size = new System.Drawing.Size(44, 19);
            this.rbtnGas.TabIndex = 25;
            this.rbtnGas.TabStop = true;
            this.rbtnGas.Text = "Gas";
            this.rbtnGas.UseVisualStyleBackColor = true;
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFuelType.Location = new System.Drawing.Point(367, 198);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(78, 20);
            this.lblFuelType.TabIndex = 15;
            this.lblFuelType.Text = "Fuel Type:";
            // 
            // rbtnDiesel
            // 
            this.rbtnDiesel.AutoSize = true;
            this.rbtnDiesel.Location = new System.Drawing.Point(537, 196);
            this.rbtnDiesel.Name = "rbtnDiesel";
            this.rbtnDiesel.Size = new System.Drawing.Size(56, 19);
            this.rbtnDiesel.TabIndex = 23;
            this.rbtnDiesel.TabStop = true;
            this.rbtnDiesel.Text = "Diesel";
            this.rbtnDiesel.UseVisualStyleBackColor = true;
            this.rbtnDiesel.Click += new System.EventHandler(this.rbtnDiesel_Click);
            // 
            // tbtnGasoline
            // 
            this.tbtnGasoline.AutoSize = true;
            this.tbtnGasoline.Location = new System.Drawing.Point(537, 221);
            this.tbtnGasoline.Name = "tbtnGasoline";
            this.tbtnGasoline.Size = new System.Drawing.Size(70, 19);
            this.tbtnGasoline.TabIndex = 24;
            this.tbtnGasoline.TabStop = true;
            this.tbtnGasoline.Text = "Gasoline";
            this.tbtnGasoline.UseVisualStyleBackColor = true;
            // 
            // combobxCaretaker
            // 
            this.combobxCaretaker.FormattingEnabled = true;
            this.combobxCaretaker.Location = new System.Drawing.Point(535, 71);
            this.combobxCaretaker.Name = "combobxCaretaker";
            this.combobxCaretaker.Size = new System.Drawing.Size(161, 23);
            this.combobxCaretaker.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(369, 304);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 71);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(178, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 71);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // numUpDownYear
            // 
            this.numUpDownYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numUpDownYear.Location = new System.Drawing.Point(178, 196);
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
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(535, 103);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(161, 23);
            this.tbColor.TabIndex = 21;
            // 
            // numUpDownPricePerDay
            // 
            this.numUpDownPricePerDay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numUpDownPricePerDay.Location = new System.Drawing.Point(535, 135);
            this.numUpDownPricePerDay.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDownPricePerDay.Name = "numUpDownPricePerDay";
            this.numUpDownPricePerDay.Size = new System.Drawing.Size(161, 23);
            this.numUpDownPricePerDay.TabIndex = 34;
            this.numUpDownPricePerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownPricePerDay.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // checkbxIsDamaged
            // 
            this.checkbxIsDamaged.AutoSize = true;
            this.checkbxIsDamaged.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkbxIsDamaged.Location = new System.Drawing.Point(231, 265);
            this.checkbxIsDamaged.Name = "checkbxIsDamaged";
            this.checkbxIsDamaged.Size = new System.Drawing.Size(108, 24);
            this.checkbxIsDamaged.TabIndex = 36;
            this.checkbxIsDamaged.Text = "Is Damaged";
            this.checkbxIsDamaged.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(376, 265);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(79, 24);
            this.checkBox2.TabIndex = 37;
            this.checkBox2.Text = "Is Away";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // lblUpdateCar
            // 
            this.lblUpdateCar.AutoSize = true;
            this.lblUpdateCar.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateCar.Location = new System.Drawing.Point(281, 12);
            this.lblUpdateCar.Name = "lblUpdateCar";
            this.lblUpdateCar.Size = new System.Drawing.Size(154, 37);
            this.lblUpdateCar.TabIndex = 38;
            this.lblUpdateCar.Text = "Update Car";
            // 
            // UpdateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 397);
            this.Controls.Add(this.lblUpdateCar);
            this.Controls.Add(this.numUpDownPricePerDay);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.numUpDownYear);
            this.Controls.Add(this.combobxCaretaker);
            this.Controls.Add(this.tbtnGasoline);
            this.Controls.Add(this.rbtnDiesel);
            this.Controls.Add(this.rbtnGas);
            this.Controls.Add(this.tbMileage);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblPricePerDay);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.tbLicensePlateFirstThree);
            this.Controls.Add(this.lblCaretaker);
            this.Controls.Add(this.combobxTransmission);
            this.Controls.Add(this.lblTrasnsmission);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.tbEngine);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.tbLicensePlateRest);
            this.Controls.Add(this.lblLicensePlate);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkbxIsDamaged);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Name = "UpdateCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCar";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPricePerDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox tbLicensePlateRest;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.TextBox tbEngine;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTrasnsmission;
        private System.Windows.Forms.ComboBox combobxTransmission;
        private System.Windows.Forms.Label lblCaretaker;
        private System.Windows.Forms.TextBox tbLicensePlateFirstThree;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPricePerDay;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.TextBox tbMileage;
        private System.Windows.Forms.RadioButton rbtnGas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbtnDiesel;
        private System.Windows.Forms.RadioButton tbtnGasoline;
        private System.Windows.Forms.ComboBox combobxCaretaker;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numUpDownYear;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.NumericUpDown numUpDownPricePerDay;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.CheckBox checkbxIsDamaged;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label lblUpdateCar;
    }
}