using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tetris
{
    public class Block
    {
        public static int size = 16;
        public Color color;
        public int x, y;
        public Block(Color color, int x, int y)
        {
            this.color = color;
            this.x = x;
            this.y = y;
        }
        public void Move(int dx, int dy)
        {
            this.x += dx;
            this.y += dy;
        }
        public void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(this.color);
            Pen pen = new Pen(brush);
            Rectangle rect = new Rectangle(x * Block.size, y * Block.size, Block.size, Block.size);
            g.DrawRectangle(pen, rect);
            g.FillRectangle(brush, rect);
        }
    }
}
