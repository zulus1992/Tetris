namespace Tetris
{
    partial class SettingForm
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
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(17, 34);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(125, 27);
            this.widthTextBox.TabIndex = 0;
            this.widthTextBox.Text = "15";
            this.widthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(168, 33);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(125, 27);
            this.heightTextBox.TabIndex = 1;
            this.heightTextBox.Text = "20";
            this.heightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(146, 37);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(16, 20);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "x";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(17, 11);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(67, 20);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Ширина";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(168, 10);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(59, 20);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Высота";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(17, 81);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(276, 29);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 114);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox widthTextBox;
        private TextBox heightTextBox;
        private Label xLabel;
        private Label widthLabel;
        private Label heightLabel;
        private Button startButton;
    }
}