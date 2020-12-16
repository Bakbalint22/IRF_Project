using IRF_Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    public partial class Animation : Form
    {
        private List<Ball> _balls = new List<Ball>();
        int a;
        int chance;
        Random rnd = new Random();
        private BallFactory _factory;
        public BallFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }
        public Animation()
        {
            InitializeComponent();
            Factory = new BallFactory();

            this.BackColor = Color.Green;

            
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var ball = Factory.CreateNew();
            _balls.Add(ball);
            ball.Left = -ball.Width;
            panel1.Controls.Add(ball);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
            var maxPosition = 0;
           
            foreach (var ball in _balls)
            {
                ball.MoveBall();
                if (ball.Left > maxPosition)
                {
                   
                    maxPosition = ball.Left;
                   
                }
            }

            if (maxPosition > 550)
            {

                var oldestBall = _balls[0];
                panel1.Controls.Remove(oldestBall);
                _balls.Remove(oldestBall);

                chance = rnd.Next(1, 10) * 10;
                lblchance.Text = chance.ToString();

                if (chance > 70)
                {
                    a++;
                    labelscore.Text = a.ToString();
                    pBGoal.Visible = true;
                    pBNoGoal.Visible = false;
                    labeloutput.Text = "GOOOOAAAL";
                    if (a == 10)
                    {
                        timer1.Stop();
                        timer2.Stop();
                        MessageBox.Show("It was humiliating!");
                        Application.Exit();
                    }
                }
                else
                {
                    pBGoal.Visible = false;
                    pBNoGoal.Visible = true;
                    labeloutput.Text = "MISS :(";
                }
                
            }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
            Pen bPen = new Pen(black, 10);

            g.DrawLine(bPen, 40, 0, 130, 50);
            g.FillRectangle(new SolidBrush(Color.Black), 40, 0, 10, 120);
            g.FillRectangle(new SolidBrush(Color.Black), 120, 40, 10, 120);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
