using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGame
{
    public partial class Form1 : Form
    {
        PictureBox[] cloud;
        int backgroundspeed;
        Random rnd;
        int playerspeed;

        PictureBox[] fireball;
        int sizefireball;
        int firespeed;
        
        PictureBox[] enemies;
        int sizeenemy;
        int enemiesspeed;

        int score;
        int level;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundspeed = 1;
            cloud = new PictureBox[20];
            rnd = new Random();
            playerspeed = 6;

            fireball = new PictureBox[1];
            firespeed = 3000;
            
            for (int i = 0; i < fireball.Length; i++)
            {
                fireball[i] = new PictureBox();
                fireball[i].Size = new Size(90, 90);
                fireball[i].SizeMode = PictureBoxSizeMode.Zoom;
                fireball[i].BackColor = Color.Transparent;
                fireball[i].Image = Image.FromFile("assets\\faerbol.gif");
                this.Controls.Add(fireball[i]);

            }
            
            level = 1;
            score = 0;

            enemies = new PictureBox[4];
            int sizeenemy = rnd.Next(60, 85);
            enemiesspeed = 3;
            Image imenemy = Image.FromFile("assets\\enemy.gif");

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(sizeenemy, sizeenemy);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BackColor = Color.Transparent;
                enemies[i].Image = imenemy;
                enemies[i].Location = new Point((i + 1) * rnd.Next(90, 160) + 1000, rnd.Next(450, 600)); 
                this.Controls.Add(enemies[i]);
            }

            for (int i = 0; i < cloud.Length; i++)
            {
                cloud[i] = new PictureBox();
                cloud[i].BorderStyle = BorderStyle.None;
                cloud[i].Location = new Point(rnd.Next(-1000, 1280), rnd.Next(140, 320));
                if (i % 2 == 1)
                {
                    cloud[i].Size = new Size(rnd.Next(100, 225), rnd.Next(30, 70));
                    cloud[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 255, 200, 200);
                }
                else
                {
                    cloud[i].Size = new Size(150, 25);
                    cloud[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 255, 200, 200);
                }
                this.Controls.Add(cloud[i]);
            }
        }
        private void MovoBgTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < cloud.Length; i++)
            {
                cloud[i].Left += backgroundspeed;

                if (cloud[i].Left >= 1280)
                {
                    cloud[i].Left = cloud[i].Height;
                }
            }
            for (int i = cloud.Length; i < cloud.Length; i++)
            {
                cloud[i].Left += backgroundspeed - 10;
                if (cloud[i].Left >= 1280)
                {
                    cloud[i].Left = cloud[i].Left;
                }
            }
        }
        
        private void leftmove_Tick(object sender, EventArgs e)
        {
            if(MainPlayer.Left > -30)
            {
                MainPlayer.Left -= playerspeed;
            }
        }

        private void rightmove_Tick(object sender, EventArgs e)
        {
            if (MainPlayer.Left < 980)
            {
                MainPlayer.Left += playerspeed;
            }
        }

        private void upmove_Tick(object sender, EventArgs e)
        {
            if (MainPlayer.Top > 450)
                MainPlayer.Top -= playerspeed;
        }

        private void downmove_Tick(object sender, EventArgs e)
        {
            if (MainPlayer.Top < 600)
                MainPlayer.Top += playerspeed;
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MainPlayer.Image = Properties.Resources.levo;
                leftmove.Start();
            }
            if (e.KeyCode == Keys.Right)
            {
                MainPlayer.Image = Properties.Resources.pravo;
                rightmove.Start();
            }
            if (e.KeyCode == Keys.Up)
            {
                MainPlayer.Image = Properties.Resources.pravo;
                upmove.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                MainPlayer.Image = Properties.Resources.pravo;
                downmove.Start();
            }
            if (e.KeyCode == Keys.Space)
            {
                firespeed = 35;
                MainPlayer.Image = Properties.Resources.agon;
                for (int i = 0; i < fireball.Length; i++)
                {
                    Intersect();

                    if (fireball[i].Left > 1280)
                    {
                        fireball[i].Location = new Point(MainPlayer.Location.X - 10, MainPlayer.Location.Y - 10);

                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            MainPlayer.Image = Properties.Resources.mesto;
            leftmove.Stop();
            rightmove.Stop();
            upmove.Stop();
            downmove.Stop();

        }

        private void movefireballtimer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < fireball.Length; i++)
            {
                fireball[i].Left += firespeed;
            }
        }

        private void moveenemiestimer_Tick(object sender, EventArgs e)
        {
            moveEnemis(enemies, enemiesspeed);
        }

        private void moveEnemis (PictureBox[] enemies, int speed)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Left -= speed + (int)(Math.Sin(enemies[i].Left * Math.PI / 180) + Math.Cos(enemies[i].Left * Math.PI / 180));

                Intersect();

                if (enemies[i].Left < -20)
                {
                    int sizeenemy = rnd.Next(60, 90);
                    enemies[i].Size = new Size(sizeenemy, sizeenemy);
                    enemies[i].Location = new Point((i + 1) * rnd.Next(150, 250) + 1080, rnd.Next(450, 600));
                }

            }
        }

        private void Intersect()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (fireball[0].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    enemies[i].Location = new Point((i + 1) * rnd.Next(150, 250) + 1280, rnd.Next(450, 600));
                    fireball[0].Location = new Point(1000, 1000);

                    score += 1;
                    labelScore.Text = (score < 10) ? "0" + score.ToString() : score.ToString();

                    if (score % 10 == 0)
                    {
                        level += 1;
                        labelLevel.Text = (score < 10) ? "0" + level.ToString() : level.ToString();

                        if (enemiesspeed <= 3)
                        {
                            enemiesspeed++;
                        }

                        if (level == 4)
                        {
                            GameOver("EPIC POWER!");
                            labelRestart.Visible = true;
                        }

                    }

                }
                
                if (MainPlayer.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    MainPlayer.Visible = false;
                    GameOver("GAME OVER");
                    labelRestart.Visible = true;
                }
            }
        }

        private void GameOver(string str)
        {
            label1.Text = str;
            label1.Location = new Point(270, 100);
            label1.Visible = true;
            moveenemiestimer.Stop();
        }

        private void GameOver_Click(object sender, EventArgs e)
        {

        }

        private void labelRestart_Click(object sender, EventArgs e)
        {
            MainPlayer.Location = new Point (88, 492);
            MainPlayer.Visible = true;
            label1.Visible = false;
            labelRestart.Visible = false;
            moveenemiestimer.Start();
            
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Location = new Point((i + 1) * rnd.Next(90, 160) + 1000, rnd.Next(450, 600));

            }
            
            score = 0;
            level = 0;
            labelScore.Text = (score < 10) ? "0" + score.ToString() : score.ToString();
            labelLevel.Text = (score < 10) ? "0" + level.ToString() : level.ToString();
        }
    }
}
