using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class StatisticForm : Form
    {
        public StatisticForm(int points = 0)
        {
            InitializeComponent();
            pointsLabel.Text = points.ToString();
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            var settingForm = new SettingForm();
            this.Hide();
            settingForm.Show();
        }
    }
}
