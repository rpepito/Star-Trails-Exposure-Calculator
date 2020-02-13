namespace Star_trails_Calculator
{
    partial class Form1
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
            this.FocalLengthTextBox = new System.Windows.Forms.TextBox();
            this.FocalLengthLabel = new System.Windows.Forms.Label();
            this.CropSensorLabel = new System.Windows.Forms.Label();
            this.UseCropSensor_State = new System.Windows.Forms.ComboBox();
            this.CropFactorLabel = new System.Windows.Forms.Label();
            this.CropFactor = new System.Windows.Forms.ComboBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintStateLabel = new System.Windows.Forms.Label();
            this.PrintState = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FocalLengthTextBox
            // 
            this.FocalLengthTextBox.Location = new System.Drawing.Point(194, 47);
            this.FocalLengthTextBox.MaxLength = 3;
            this.FocalLengthTextBox.Name = "FocalLengthTextBox";
            this.FocalLengthTextBox.Size = new System.Drawing.Size(70, 20);
            this.FocalLengthTextBox.TabIndex = 0;
            this.FocalLengthTextBox.TextChanged += new System.EventHandler(this.FocalLengthTextBox_TextChanged);
            this.FocalLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FocalLengthTextBox_KeyPress);
            // 
            // FocalLengthLabel
            // 
            this.FocalLengthLabel.AutoSize = true;
            this.FocalLengthLabel.Location = new System.Drawing.Point(85, 54);
            this.FocalLengthLabel.Name = "FocalLengthLabel";
            this.FocalLengthLabel.Size = new System.Drawing.Size(69, 13);
            this.FocalLengthLabel.TabIndex = 1;
            this.FocalLengthLabel.Text = "Focal Length";
            this.FocalLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CropSensorLabel
            // 
            this.CropSensorLabel.AutoSize = true;
            this.CropSensorLabel.Location = new System.Drawing.Point(85, 93);
            this.CropSensorLabel.Name = "CropSensorLabel";
            this.CropSensorLabel.Size = new System.Drawing.Size(71, 13);
            this.CropSensorLabel.TabIndex = 2;
            this.CropSensorLabel.Text = "Crop Sensor?";
            this.CropSensorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UseCropSensor_State
            // 
            this.UseCropSensor_State.FormattingEnabled = true;
            this.UseCropSensor_State.Items.AddRange(new object[] {
            "True",
            "False"});
            this.UseCropSensor_State.Location = new System.Drawing.Point(194, 85);
            this.UseCropSensor_State.MaxDropDownItems = 2;
            this.UseCropSensor_State.Name = "UseCropSensor_State";
            this.UseCropSensor_State.Size = new System.Drawing.Size(70, 21);
            this.UseCropSensor_State.TabIndex = 3;
            this.UseCropSensor_State.SelectedIndexChanged += new System.EventHandler(this.UseCropSensor_State_SelectedIndexChanged);
            // 
            // CropFactorLabel
            // 
            this.CropFactorLabel.AutoSize = true;
            this.CropFactorLabel.Location = new System.Drawing.Point(85, 133);
            this.CropFactorLabel.Name = "CropFactorLabel";
            this.CropFactorLabel.Size = new System.Drawing.Size(62, 13);
            this.CropFactorLabel.TabIndex = 4;
            this.CropFactorLabel.Text = "Crop Factor";
            this.CropFactorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CropFactor
            // 
            this.CropFactor.FormattingEnabled = true;
            this.CropFactor.Items.AddRange(new object[] {
            "1.5",
            "1.6",
            "2.0",
            "2.7"});
            this.CropFactor.Location = new System.Drawing.Point(194, 125);
            this.CropFactor.Name = "CropFactor";
            this.CropFactor.Size = new System.Drawing.Size(70, 21);
            this.CropFactor.TabIndex = 5;
            this.CropFactor.SelectedIndexChanged += new System.EventHandler(this.CropFactor_SelectedIndexChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CalculateButton.Location = new System.Drawing.Point(88, 208);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(176, 30);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // PrintStateLabel
            // 
            this.PrintStateLabel.AutoSize = true;
            this.PrintStateLabel.Location = new System.Drawing.Point(88, 173);
            this.PrintStateLabel.Name = "PrintStateLabel";
            this.PrintStateLabel.Size = new System.Drawing.Size(48, 13);
            this.PrintStateLabel.TabIndex = 7;
            this.PrintStateLabel.Text = "Printing?";
            // 
            // PrintState
            // 
            this.PrintState.FormattingEnabled = true;
            this.PrintState.Items.AddRange(new object[] {
            "True",
            "False"});
            this.PrintState.Location = new System.Drawing.Point(194, 165);
            this.PrintState.Name = "PrintState";
            this.PrintState.Size = new System.Drawing.Size(70, 21);
            this.PrintState.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.PrintState);
            this.Controls.Add(this.PrintStateLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.CropFactor);
            this.Controls.Add(this.CropFactorLabel);
            this.Controls.Add(this.UseCropSensor_State);
            this.Controls.Add(this.CropSensorLabel);
            this.Controls.Add(this.FocalLengthLabel);
            this.Controls.Add(this.FocalLengthTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Star Exposure Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FocalLengthTextBox;
        private System.Windows.Forms.Label FocalLengthLabel;
        private System.Windows.Forms.Label CropSensorLabel;
        private System.Windows.Forms.ComboBox UseCropSensor_State;
        private System.Windows.Forms.Label CropFactorLabel;
        private System.Windows.Forms.ComboBox CropFactor;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label PrintStateLabel;
        private System.Windows.Forms.ComboBox PrintState;
    }
}

