using System.Windows.Forms;

namespace Tetris
{
    public partial class GameForm : Form
    {
        private static int CELL_SIZE = 20;
        private static int INTERVAL = 500;

        private readonly int _width;
        private readonly int _height;

        private int[,] figure;
        private int[,] field;
        private Bitmap bitmap;
        private Graphics graphics;
        private int points = 0;

        private PictureBox PictureBox { get; }
        private System.Windows.Forms.Timer Timer { get; }

        public GameForm(int width = 15, int height = 20)
        {
            _width = width;
            _height = height;

            field = new int[_width, _height];
            bitmap = new Bitmap(CELL_SIZE * _width, CELL_SIZE * _height);

            PictureBox = new PictureBox { Dock = DockStyle.Fill, Parent = this };
            Timer = new System.Windows.Forms.Timer { Interval = INTERVAL, Enabled = true };
            Timer.Tick += Timer_Tick;
            KeyDown += Form1_KeyDown;
            InitNewFigure();
            InitializeComponent();
            this.Height = CELL_SIZE * (_height + 4);
            this.Width = CELL_SIZE * (_width + 1);

            graphics = Graphics.FromImage(bitmap);

        }

        private void InitNewFigure()
        {
            Random rand = new Random();
            var randValue = rand.Next(1, 7);
            figure = FigureFactory.Create(randValue);
            for (var i = 0; i < 4; i++)
                figure[1, i] += (_width - 3) / 2;
        }

        private void UpdField()
        {
            graphics.Clear(Color.Gray);

            for (int i = 0; i < _width; i++)
                for (int j = 0; j < _height; j++)
                    if (field[i, j] == 1)
                    {
                        graphics.FillRectangle(Brushes.Black, i * CELL_SIZE, j * CELL_SIZE, CELL_SIZE, CELL_SIZE);
                        graphics.DrawRectangle(Pens.Black, i * CELL_SIZE, j * CELL_SIZE, CELL_SIZE, CELL_SIZE);
                    }
            for (int i = 0; i < 4; i++)
            {
                graphics.FillRectangle(Brushes.White, figure[1, i] * CELL_SIZE, figure[0, i] * CELL_SIZE, CELL_SIZE, CELL_SIZE);
                graphics.DrawRectangle(Pens.White, figure[1, i] * CELL_SIZE, figure[0, i] * CELL_SIZE, CELL_SIZE, CELL_SIZE);
            }

            PictureBox.Image = bitmap;
        }

        private bool IsOutOfField()
        {
            for (int i = 0; i < 4; i++)
                if (figure[1, i] < 0
                    || figure[1, i] >= _width
                    || figure[0, i] < 0
                    || figure[0, i] >= _height
                    || field[figure[1, i], figure[0, i]] == 1
                    )
                    return true;
            return false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (field[_width / 2, 0] == 1)
                ShowStatistic();
            for (int i = 0; i < 4; i++)
                figure[0, i]++;
            for (int i = _height - 1; i > 1; i--)
            {
                var cross = Enumerable.Range(0, field.GetLength(0)).Count(j => field[j, i] == 1);
                if (cross == _width)
                {
                    for (int k = i; k > 1; k--)
                        for (int l = 1; l < _width - 1; l++)
                            field[l, k] = field[l, k - 1];
                    points += _width;
                }
            }
            if (IsOutOfField())
            {
                for (int i = 0; i < 4; i++)
                    field[figure[1, i], --figure[0, i]]++;
                InitNewFigure();
            }
            UpdField();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    for (int i = 0; i < 4; i++)
                        figure[1, i]--;
                    if (IsOutOfField())
                        for (int i = 0; i < 4; i++)
                            figure[1, i]++;
                    break;
                case Keys.D:
                    for (int i = 0; i < 4; i++)
                        figure[1, i]++;
                    if (IsOutOfField())
                        for (int i = 0; i < 4; i++)
                            figure[1, i]--;
                    break;
                case Keys.Space:
                    var shapeT = new int[2, 4];
                    Array.Copy(figure, shapeT, figure.Length);
                    int maxx = 0, maxy = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (figure[0, i] > maxy)
                            maxy = figure[0, i];
                        if (figure[1, i] > maxx)
                            maxx = figure[1, i];
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        int temp = figure[0, i];
                        figure[0, i] = maxy - (maxx - figure[1, i]) - 1;
                        figure[1, i] = maxx - (3 - (maxy - temp)) + 1;
                    }
                    if (IsOutOfField())
                        Array.Copy(shapeT, figure, figure.Length);
                    break;
            }
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingForm = new SettingForm();
            this.Hide();
            settingForm.Show();
        }

        private void ShowStatistic()

        {
            var statisticForm = new StatisticForm(points);
            this.Hide();
            statisticForm.Show();
        }
    }
}