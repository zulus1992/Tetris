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
    public partial class SettingForm : Form
    {
        public static int DEFAULT_WIDTH = 15;
        public static int DEFAULT_HEIGHT = 20;

        public SettingForm()
        {
            InitializeComponent();
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            var width = Int32.Parse(widthTextBox.Text);
            var height = Int32.Parse(heightTextBox.Text);
            if (width < 15 || width > 50)
                width = DEFAULT_WIDTH;
            if (height < 15 || height > 50)
                height = DEFAULT_HEIGHT;

            var gameForm = new GameForm(width, height);
            this.Hide();
            gameForm.Show();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
