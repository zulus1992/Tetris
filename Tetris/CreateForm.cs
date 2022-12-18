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
    public partial class CreateForm : Form
    {
        private static int CELL_SIZE = 40;

        private List<Cordinate> cordinates;
        private Bitmap bitmap;
        private Graphics graphics;

        private PictureBox PictureBox { get; }

        public CreateForm()
        {

            PictureBox = new PictureBox { Dock = DockStyle.Fill, Parent = this };
            PictureBox.MouseClick += new MouseEventHandler((o, a) => PictureBox_Click(o, a));
            bitmap = new Bitmap(CELL_SIZE * 4, CELL_SIZE * 4);
            cordinates = new List<Cordinate>();
            InitializeComponent();
            graphics = Graphics.FromImage(bitmap);
            UpdField();
        }

        private void PictureBox_Click(object sender, MouseEventArgs arg)
        {
            Point coordinates = arg.Location;
            var x = coordinates.X / CELL_SIZE;
            var y = coordinates.Y / CELL_SIZE;
            var cordinate = new Cordinate() { X = x, Y = y };
            if (cordinates.Contains(cordinate))
            {
                cordinates.Remove(cordinate);
                if (!IsCorrectFigure())
                    cordinates.Add(cordinate);
            }
            else
            {
                cordinates.Add(cordinate);
                if (!IsCorrectFigure())
                    cordinates.Remove(cordinate);
            }
            
            UpdField();
        }

        private void UpdField()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    graphics.FillRectangle(Brushes.White, i * CELL_SIZE, j * CELL_SIZE, CELL_SIZE, CELL_SIZE);
                    graphics.DrawRectangle(Pens.Gray, i * CELL_SIZE, j * CELL_SIZE, CELL_SIZE, CELL_SIZE);
                }
            for (int i = 0; i < cordinates.Count(); i++)
            {
                graphics.FillRectangle(Brushes.Black, cordinates[i].X * CELL_SIZE, cordinates[i].Y * CELL_SIZE, CELL_SIZE, CELL_SIZE);
                graphics.DrawRectangle(Pens.Black, cordinates[i].X * CELL_SIZE, cordinates[i].Y * CELL_SIZE, CELL_SIZE, CELL_SIZE);
            }

            PictureBox.Image = bitmap;
        }

        private void добавитьФигуруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var figure = new int[2, cordinates.Count()];
            for (var i = 0; i < cordinates.Count(); i++)
            {
                figure[0, i] = cordinates[i].X;
                figure[1, i] = cordinates[i].Y;
            }
            FigureFactory.Add(figure);
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingForm = new SettingForm();
            this.Hide();
            settingForm.Show();
        }

        private bool IsCorrectFigure()
        {
            for (var i = 0; i < cordinates.Count(); i++)
            {
                var x = cordinates[i].X;
                var y = cordinates[i].Y;
                if (cordinates.Count() > 8
                    ||(cordinates.Count()>1
                    &&!cordinates.Contains(new Cordinate() { X = x - 1, Y = y })
                    && !cordinates.Contains(new Cordinate() { X = x + 1, Y = y })
                    && !cordinates.Contains(new Cordinate() { X = x, Y = y - 1 })
                    && !cordinates.Contains(new Cordinate() { X = x, Y = y + 1 })))
                    return false;
                else continue;
            }
            return true;


        }
    }

    internal class Cordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override bool Equals(object? obj)
        {
            var item = obj as Cordinate;
            if (item == null)
            {
                return false;
            }
            return this.X.Equals(item.X) && this.Y.Equals(item.Y);
        }
    }
}
