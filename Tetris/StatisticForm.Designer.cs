namespace Tetris
{
    partial class StatisticForm
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.settingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(88, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(118, 40);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Игра окончена!\r\nВаш счет:";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(119, 58);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(0, 20);
            this.pointsLabel.TabIndex = 1;
            // 
            // settingButton
            // 
            this.settingButton.Location = new System.Drawing.Point(111, 99);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(94, 29);
            this.settingButton.TabIndex = 2;
            this.settingButton.Text = "Заново";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 130);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.infoLabel);
            this.Name = "StatisticForm";
            this.Text = "Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label infoLabel;
        private Label pointsLabel;
        private Button settingButton;
    }
}