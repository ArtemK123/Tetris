using System;
using System.Collections.Generic;
using System.Drawing;

namespace Tetris
{
    class Figure
    {
        // 1  2  3  4
        // 5  6  7  8
        // 9 10 11 12
        //13 14 15 16

        public static Dictionary<string, int[][]> shapes = new Dictionary<string, int[][]>
            {
                { "I", new int[][] {
                    new int[]{ 5, 6, 7, 8 },
                    new int[]{ 2, 6, 10, 14},
                    new int[]{ 5, 6, 7, 8 },
                    new int[]{ 2, 6, 10, 14 } } },
                { "J", new int[][] {
                    new int[]{ 1, 5, 6, 7 },
                    new int[]{ 2, 1, 5, 9 },
                    new int[]{ 1, 2, 3, 7 },
                    new int[]{ 2, 6, 10, 9 } } },
                { "L", new int[][] {
                    new int[]{ 5, 6, 7, 3 },
                    new int[]{ 1, 5, 9, 10 },
                    new int[]{ 5, 1, 2, 3},
                    new int[]{ 1, 2, 6, 10 } } },
                { "O", new int[][] {
                    new int[]{ 2, 3, 6, 7 },
                    new int[]{ 2, 3, 6, 7 },
                    new int[]{ 2, 3, 6, 7 },
                    new int[]{ 2, 3, 6, 7 } } },
                { "S", new int[][] {
                    new int[]{ 5, 6, 2, 3 },
                    new int[]{ 1, 5, 6, 10 },
                    new int[]{ 5, 6, 2, 3 },
                    new int[]{ 1, 5, 6, 10 } } },
                { "T", new int[][] {
                    new int[]{ 5, 6, 7, 2 },
                    new int[]{ 1, 5, 9, 6 },
                    new int[]{ 1, 2, 3, 6 },
                    new int[]{ 5, 2, 6, 10 } } },
                { "Z", new int[][] {
                    new int[]{ 1, 2, 6, 7 },
                    new int[]{ 2, 6, 5, 9 },
                    new int[]{ 1, 2, 6, 7 },
                    new int[]{ 2, 6, 5, 9 } } }
            };

        public static Color[] colors = new Color[]
        {
                Color.Red,
                Color.Navy,
                Color.Lime,
                Color.Blue,
                Color.Magenta,
                Color.Orange,
                Color.Chocolate,
                Color.Purple

        };

        public static int FindColor(Color color)
        {
            for (int i = 0; i < colors.Length; i++)
            {
                if (colors[i] == color)
                {
                    return i;
                }
            }
            return -1;
        }

        public Block[] blocks;
        public Color color;
        public int config;
        public int x, y;
        public string type;

        public Figure(string type, Color color, int x, int y)
        {
            this.color = color;
            this.x = x;
            this.y = y;
            this.type = type;
            this.config = 0;
            this.CreateShape();
            foreach (Block block in blocks)
            {
                block.color = color;
            }
        }

        public void CreateShape()
        {
            Block[] arr = new Block[4];
            for (int i = 0; i < 4; i++)
            {
                arr[i] = new Block(color, x, y);
                int dx = (Figure.shapes[type][config][i] - 1) % 4;
                int dy = (Figure.shapes[type][config][i] - 1) / 4;
                arr[i].Move(dx, dy);
            }
            this.blocks = arr;
        }

        public void Draw(Graphics g)
        {
            foreach (Block block in blocks)
            {
                block.Draw(g);
            }
        }
    }
}
