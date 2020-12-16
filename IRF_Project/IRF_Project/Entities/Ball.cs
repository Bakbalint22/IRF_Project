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
            Width = 30;
            Height = 30;

            Paint += Ball_Paint;
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }
        protected void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Black), 0, 0, Width, Height);
            g.FillEllipse(new SolidBrush(Color.White), 0, 0, 28, 28);
        }

        public void MoveBall()
        {
            Left += 1;
        }
    }
}
