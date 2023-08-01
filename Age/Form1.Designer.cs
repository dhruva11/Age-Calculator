namespace AgeCalculatorApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblBirthDate = new Label();
            dtPickerBirthDate = new DateTimePicker();
            btnCalculateAge = new Button();
            lblAgeResult = new Label();
            rdoPicker = new RadioButton();
            rdoManual = new RadioButton();
            txtManualBirthDate = new TextBox();
            SuspendLayout();
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(12, 34);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(150, 20);
            lblBirthDate.TabIndex = 0;
            lblBirthDate.Text = "Select your birthdate:";
            // 
            // dtPickerBirthDate
            // 
            dtPickerBirthDate.Format = DateTimePickerFormat.Short;
            dtPickerBirthDate.Location = new Point(171, 28);
            dtPickerBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtPickerBirthDate.Name = "dtPickerBirthDate";
            dtPickerBirthDate.Size = new Size(145, 27);
            dtPickerBirthDate.TabIndex = 1;
            dtPickerBirthDate.Visible = false;
            // 
            // btnCalculateAge
            // 
            btnCalculateAge.Location = new Point(32, 157);
            btnCalculateAge.Margin = new Padding(3, 4, 3, 4);
            btnCalculateAge.Name = "btnCalculateAge";
            btnCalculateAge.Size = new Size(241, 42);
            btnCalculateAge.TabIndex = 2;
            btnCalculateAge.Text = "Calculate Age";
            btnCalculateAge.UseVisualStyleBackColor = true;
            btnCalculateAge.Click += btnCalculateAge_Click;
            // 
            // lblAgeResult
            // 
            lblAgeResult.AutoSize = true;
            lblAgeResult.Location = new Point(12, 220);
            lblAgeResult.Margin = new Padding(3, 12, 3, 0);
            lblAgeResult.Name = "lblAgeResult";
            lblAgeResult.Size = new Size(0, 20);
            lblAgeResult.TabIndex = 3;
            // 
            // rdoPicker
            // 
            rdoPicker.AutoSize = true;
            rdoPicker.Checked = true;
            rdoPicker.Location = new Point(15, 74);
            rdoPicker.Margin = new Padding(3, 4, 3, 4);
            rdoPicker.Name = "rdoPicker";
            rdoPicker.Size = new Size(133, 24);
            rdoPicker.TabIndex = 5;
            rdoPicker.TabStop = true;
            rdoPicker.Text = "Use Date Picker";
            rdoPicker.UseVisualStyleBackColor = true;
            rdoPicker.CheckedChanged += rdoPicker_CheckedChanged;
            // 
            // rdoManual
            // 
            rdoManual.AutoSize = true;
            rdoManual.Location = new Point(15, 110);
            rdoManual.Margin = new Padding(3, 4, 3, 4);
            rdoManual.Name = "rdoManual";
            rdoManual.Size = new Size(131, 24);
            rdoManual.TabIndex = 6;
            rdoManual.TabStop = true;
            rdoManual.Text = "Enter Manually:";
            rdoManual.UseVisualStyleBackColor = true;
            rdoManual.CheckedChanged += rdoManual_CheckedChanged;
            // 
            // txtManualBirthDate
            // 
            txtManualBirthDate.Location = new Point(171, 30);
            txtManualBirthDate.Margin = new Padding(3, 4, 3, 4);
            txtManualBirthDate.Name = "txtManualBirthDate";
            txtManualBirthDate.Size = new Size(145, 27);
            txtManualBirthDate.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 269);
            Controls.Add(rdoManual);
            Controls.Add(rdoPicker);
            Controls.Add(lblAgeResult);
            Controls.Add(btnCalculateAge);
            Controls.Add(txtManualBirthDate);
            Controls.Add(dtPickerBirthDate);
            Controls.Add(lblBirthDate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Age Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBirthDate;
        private DateTimePicker dtPickerBirthDate;
        private Button btnCalculateAge;
        private Label lblAgeResult;
        private RadioButton rdoPicker;
        private RadioButton rdoManual;
        private TextBox txtManualBirthDate;
    }
}
