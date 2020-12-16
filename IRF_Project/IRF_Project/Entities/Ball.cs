using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IRF_Project.Entities
{
    public class Ball : Label
    {
        public Ball()
        {
            AutoSize = false;
            Width = 38;
            Height = 38;

            Paint += Ball_Paint;
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }
        protected void DrawImage(Graphics g)
        {
            Brush red = new SolidBrush(Color.Red);
            Pen rPen = new Pen(red, 3);
            g.FillEllipse(new SolidBrush(Color.Black), 0, 0, Width, Height);
            g.FillEllipse(new SolidBrush(Color.White), 2, 2, 34, 34);
            g.FillRectangle(new SolidBrush(Color.Red), 13, 17, 3, 8);
            g.DrawLine(rPen, 13, 25, 30, 15);

        }

        public void MoveBall()
        {
            Left += 1;
        }
    }
}
