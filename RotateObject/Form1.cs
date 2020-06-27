using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace RotateObject
{
    public partial class Form1 : Form
    {
        Graphics g;
        Spaceship spaceship = new Spaceship();
        Planet[] planet = new Planet[6];
        Random yspawn = new Random();

        bool turnLeft;
        bool turnRight;

        int score;
        int life = 10;

        List<Missile> missiles = new List<Missile>();

        public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, Canvas, new object[] { true });
            for (int i = 0; i < 6; i++)
            {
                int x = 10 + (i * 140);
                planet[i] = new Planet(x);
            }


        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            for (int i = 0; i < 6; i++)
            {
                planet[i].y++;

                planet[i].DrawPlanet(g);
            }
            // Drawing the spaceship
            spaceship.drawSpaceship(g);
            // NOTE: anything introduced after this will be rotated with the spaceship
            foreach (Missile m in missiles)
            {
                m.drawMissile(g);
                m.moveMissile(g);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //spaceship.moveSpaceship(e.X, e.Y);
            Console.WriteLine("Mouse Moved");
        }

        private void tmrSpaceship_Tick(object sender, EventArgs e)
        {
            if (turnRight)
            {
                spaceship.rotationAngle += 5;
            }
            if (turnLeft)
            { 
                spaceship.rotationAngle -= 5;
            }
        Canvas.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = true; }
            if (e.KeyData == Keys.Right) { turnRight = true; }
            if(e.KeyData == Keys.Space) { missiles.Add(new Missile(spaceship.spaceRec, spaceship.rotationAngle)); }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                missiles.Add(new Missile(spaceship.spaceRec, spaceship.rotationAngle));
            }

        }

        private void tmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                planet[i].MovePlanet(); 
                if (planet[i].y >= Canvas.Height)
                {
                    int rndmyspawn = yspawn.Next(1, 80);
                    life--;
                    UpdateLifeDisplay();
                    planet[i].y = rndmyspawn;
                }
                foreach (Missile m in missiles)
                {
                    if(planet[i].planetRec.IntersectsWith(m.missileRec))
                    {
                        int rndmyspawn = yspawn.Next(1, 80);
                        planet[i].y = rndmyspawn;
                        score += 100;
                        UpdateScoreDisplay();
                    }
                }

            }
            Canvas.Invalidate();
        }

        public void UpdateScoreDisplay()
        {
            ScoreTxtDisplay.Text = Convert.ToString(score);
        }

        public void UpdateLifeDisplay()
        {
            LifeTxtDisplay.Text = Convert.ToString(life);
            if(life == 0) { GameOver(); }
        }

        public void GameOver()
        {
            GameStop();
            MessageBox.Show("Game Over!");
        }

        public void GameStop()
        {
            tmrSpaceship.Enabled = false;
            tmrPlanet.Enabled = false;
        }

        public void GameStart()
        {
            tmrSpaceship.Enabled = true;
            tmrPlanet.Enabled = true;
        }

        private void MnuStart_Click(object sender, EventArgs e)
        {
            GameStart();
        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            GameStop();
        }
    }
}
