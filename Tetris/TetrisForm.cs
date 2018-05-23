using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public partial class TetrisForm : Form
    {
        bool gameover = true;
        Figure figure;
        Figure nextFigure;
        int[][] gameboard;
        int[] rows = new int[21];
        int[] points = new int[] { 100, 300, 700, 1500 };
        int score = 0;
        bool pause = true;

        void Start()
        {
            gameoverLabel.Visible = false;
            figure = MakeFigure();
            nextFigure = MakeFigure();
            DrawNextFigure();
            timer.Start();
            gameover = false;
            pause = false;
            gameboard = new int[21][];
            rows = new int[21];
            for (int i = 0; i < 21; i++)
            {
                gameboard[i] = new int[10];
                for (int j = 0; j < 10; j++)
                {
                    gameboard[i][j] = -1;
                }
                rows[i] = 0;
            }
            for (int i = 0; i < 10; i++)
            {
                gameboard[20][i] = 1;
            }
            scoreBox.Text = "0";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!gameover)
            {
                try
                {
                    Redraw();
                    if (IsOnGround())
                    {
                        LeaveOnGround();
                        CheckFilling();
                        figure = nextFigure;
                        nextFigure = MakeFigure();
                        DrawNextFigure();
                        gameover = IsCrossGround();
                    }
                    else
                    {
                        MoveFigure(0, 1);
                    }
                }
                catch (Exception)
                {
                    timer.Stop();
                    scoreBox.Text = "Error";
                    gameover = true;
                }
            }
            else
            {
                timer.Stop();
                gameoverLabel.Visible = true;
            }
        }

        void MoveFigure(int dx, int dy)
        {
            bool pass = true;
            if (dx > 0)
            {
                pass = !IsTouchWall("right");
            }
            if (dx < 0)
            {
                pass = !IsTouchWall("left");
            }
            if (dy > 0)
            {
                pass = !IsOnGround();
            }
            if (pass)
            {
                foreach (Block block in figure.blocks)
                {
                    block.Move(dx, dy);
                }
                figure.x += dx;
                figure.y += dy;
            }
        }

        void RotateFigure()
        {
            int oldConfig = figure.config;
            //Clockwise
            figure.config = (figure.config + 1) % 4;
            figure.CreateShape();
            bool pass = !IsWrongPlace();
            if (!pass)
            {
            //Counterclockwise
                figure.config = (figure.config + 2) % 4; // figure.config + 4 - 2 => prevent negative result
                figure.CreateShape();
                pass = !IsWrongPlace();
            }
            if (!pass)
            {
                figure.config = oldConfig;
                figure.CreateShape();
            }
        }

        bool IsWrongPlace()
        {
            foreach (Block block in figure.blocks)
            {
                if (block.x < 0
                    || block.x > 9
                    || block.y > 19
                    || block.y < 0
                    || gameboard[block.y][block.x] > -1)
                {
                    return true;
                }
            }
            return false;
        }

        bool IsOnGround()
        {
            foreach (Block block in figure.blocks)
            {
                if (gameboard[block.y + 1][block.x] > -1)
                {
                    return true;
                }
            }
            return false;
        }

        bool IsCrossGround()
        {
            foreach (Block block in figure.blocks)
            {
                if (gameboard[block.y][block.x] > -1)
                {
                    return true;
                }
            }
            return false;
        }

        void LeaveOnGround () 
        {
            int colorNumber = Figure.FindColor(figure.color);
            foreach (Block block in figure.blocks)
            {
                //colorNumber - number in Figure.colors
                gameboard[block.y][block.x] = colorNumber;
                rows[block.y]++;
            }
        }

        bool IsTouchWall(string direction)
        {
            foreach (Block block in figure.blocks)
            {
                if (direction == "left")
                {
                    if (block.x == 0 || gameboard[block.y][block.x - 1] > -1)
                    {
                        return true;
                    }
                }
                if (direction == "right")
                {
                    if (block.x == 9 || gameboard[block.y][block.x + 1] > -1)
                    {
                        return true;
                    }
                        
                }
            }
            return false;
        }

        void CheckFilling()
        {
            int pos = -1;
            int inline = 0;
            for (int i = rows.Length - 2; i >= 0; i--)
            {
                if (rows[i] == 10)
                {
                    pos = i;
                    break;
                }
            }
            if (pos != -1)
            {
                while (pos - inline > 0 && rows[pos - inline - 1] == 10)
                {
                    inline++;
                }
                score += points[inline];
                scoreBox.Text = score.ToString();
                int lines = inline + 1;
                for (int i = pos; i >= lines; i--)
                {
                    rows[i] = rows[i - lines];
                    for (int j = 0; j < 10; j++)
                    {
                        gameboard[i][j] = gameboard[i - lines][j];
                    }
                }
                for (int i = lines - 1; i >= 0; i--)
                {
                    rows[i] = 0;
                    for (int j = 0; j < 10; j++)
                    {
                        gameboard[i][j] = -1;
                    }
                }
            }
        } 

        void DrawNextFigure()
        {
            Bitmap bmp = new Bitmap(nextFigureBox.Width, nextFigureBox.Height);
            Graphics g = Graphics.FromImage(bmp);
            int[] shape = Figure.shapes[nextFigure.type][nextFigure.config];
            foreach(int pos in shape)
            {
                int x = (pos - 1) % 4;
                int y = ((pos - 1) / 4 + 1);  // 1 block lower for better picture
                Rectangle rect = new Rectangle(x * Block.size, y * Block.size, Block.size, Block.size);
                SolidBrush brush = new SolidBrush(nextFigure.color);
                Pen pen = new Pen(brush);
                g.DrawRectangle(pen, rect);
                g.FillRectangle(brush, rect);
            }
            nextFigureBox.Image = bmp;
        }

        void Redraw()
        {
            Bitmap bmp = new Bitmap(boardBox.Width, boardBox.Height);
            Graphics g = Graphics.FromImage(bmp);
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (gameboard[i][j] > -1)
                    {
                        SolidBrush brush = new SolidBrush(Figure.colors[gameboard[i][j]]);
                        Pen pen = new Pen(brush);
                        Rectangle rectangle = new Rectangle(j * Block.size, i * Block.size, Block.size, Block.size);
                        g.DrawRectangle(pen, rectangle);
                        g.FillRectangle(brush, rectangle);
                    }
                }
            }
            figure.Draw(g);
            boardBox.Image = bmp;
        }

        Figure MakeFigure()
        {
            Random rand = new Random();
            string types = "IJLOSTZ";
            int colorNumber = rand.Next(Figure.colors.Length);
            string type = types.Substring(rand.Next(7), 1);
            Color color = Figure.colors[colorNumber];
            return new Figure(type, color, 3, 0);
        }

        public TetrisForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            focusLabel.Focus();
            Start();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            timer.Stop();
            help.ShowDialog();
            if (!pause)
            {
                timer.Start();
            }
            focusLabel.Focus();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                pause = true;
            }
            else if (!gameover)
            {
                timer.Start();
                pause = false;
            }
            focusLabel.Focus();
        }

        private void focusLabel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }

        private void TetrisForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Left)
                {
                    MoveFigure(-1, 0);
                }
                if (e.KeyCode == Keys.Right)
                {
                    MoveFigure(1, 0);
                }
                if (e.KeyCode == Keys.Up)
                {
                    RotateFigure();
                }
                if (e.KeyCode == Keys.Down)
                {
                    MoveFigure(0, 1);
                }
            }
        }
    }
}
