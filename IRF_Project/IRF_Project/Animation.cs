﻿using IRF_Project.Entities;
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
            int a = 0;
            var maxPosition = 0;
            foreach (var ball in _balls)
            {
                ball.MoveBall();
                if (ball.Left > maxPosition)
                {
                    maxPosition = ball.Left;
                    a++;
                    label1.Text = a.ToString();
                }
            }

            if (maxPosition > 1000)
            {

                var oldestBall = _balls[0];
                panel1.Controls.Remove(oldestBall);
                _balls.Remove(oldestBall);
            }

            
        }
    }
}
