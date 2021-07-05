using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using NAudio.Wave;
using System.IO;
using CloneOSU2.Properties;

namespace CloneOSU2
{
    public partial class GameForm : Form
    {
        private MainForm parentForm;

        private WaveOutEvent outputSoundtrackDevice;
        private WaveOutEvent outputEffectDevice;
        private WaveStream stream;
        private List<MyCircle> circles = new List<MyCircle>();
        private int healthPoints = 3;
        private int currentRadius = 50;
        private int commonTick = 1000;
        private int bombTick = 2500;
        private int healthTick = 5000;
        private int circlesChangeTick = 200;
        private int moveCirclesTick = 50;
        private int scores = 0;
        Random rnd = new Random();
        
        public GameForm(MainForm parentForm)
        {
            this.parentForm = parentForm;

            InitializeComponent();

            this.Size = new Size(1200, 675);

            if (parentForm.pathToBackground!= "")
            {
                this.BackgroundImage = Image.FromFile(parentForm.pathToBackground);
            }

            outputSoundtrackDevice = new WaveOutEvent();
            outputSoundtrackDevice.PlaybackStopped += OnPlaybackStopped;

            outputEffectDevice = new WaveOutEvent();

            setSoundtrack();

            playerName_lbl.Text = parentForm.playerName;
            if (parentForm.isMusicOn) outputSoundtrackDevice.Play();

            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.UserPaint, true);
            UpdateStyles();

            startTimers();
        }

        private void setSoundtrack() 
        {
            if (parentForm.pathToMusic != "")
            {
                if (Path.GetExtension(parentForm.pathToMusic) == ".wav") stream = new WaveFileReader(parentForm.pathToMusic);
                else stream = new Mp3FileReader(parentForm.pathToMusic);
            }
            else
            {
                stream = new WaveFileReader(Resources.Music);
            }
            outputSoundtrackDevice.Init(stream);
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (outputSoundtrackDevice == null) return;
            setSoundtrack();
            outputSoundtrackDevice.Play();
        }

        // Game Form Buttons And Events

        private void pause_btn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            outputSoundtrackDevice.Pause();
            stopTimers();
            string message = "Пауза";
            DialogResult result;
            result = MessageBox.Show(message, message);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Enabled = true;
                if (parentForm.isMusicOn) outputSoundtrackDevice.Play();
                startTimers();
                
            }
        }

        private void exitGame_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            outputEffectDevice.Pause();
            outputSoundtrackDevice.Pause();
            saveScores();
            outputSoundtrackDevice.Dispose();
            outputSoundtrackDevice = null;
            stream.Dispose();
            stream = null;
            parentForm.Show();
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (MyCircle circle in circles)
                if (circle.enabled) circle.draw(g);
        }        

        private void GameForm_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (MyCircle circle in circles) 
            {
                if (checkIntersectionDotAndCircle(new Point (e.X, e.Y), circle.o, circle.radius)) 
                {
                    stream = new WaveFileReader(Resources.Bubble);
                    outputEffectDevice.Stop();
                    outputEffectDevice.Init(stream);
                    outputEffectDevice.Play();
                    circles.Remove(circle);
                    
                    if (circle.type == "common")
                    {
                        addScores(circle.radius - (int)getDistance(new Point(e.X, e.Y), circle.o));
                        return;
                    }
                    else if (circle.type == "bomb")
                    {
                        if (healthPoints > 1)
                        {
                            changeHealthPoints(-1);
                            this.BackgroundImage = Resources.BackgroundRed;
                            redBackground_tmr.Start();
                            return;
                        }
                        else
                        {
                            gameOver();
                            return;
                        }
                    }
                    else 
                    {
                        changeHealthPoints(1);
                        return;
                    }
                } 
            }
        }

        // Timers

        private void redBackground_tmr_Tick(object sender, EventArgs e)
        {
            if (parentForm.pathToBackground == "")
                this.BackgroundImage = Resources.Background;
            else
                this.BackgroundImage = Image.FromFile(parentForm.pathToBackground);
            redBackground_tmr.Stop();
        }

        private void main_tmr_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void commonCirclesAdd_tmr_Tick(object sender, EventArgs e)
        {
            circles.Add(randomizeCircle("common", currentRadius));
        }

        private void bombCirclesAdd_tmr_Tick(object sender, EventArgs e)
        {
            circles.Add(randomizeCircle("bomb", currentRadius));
        }

        private void healthCirclesAdd_tmr_Tick(object sender, EventArgs e)
        {
            circles.Add(randomizeCircle("health", currentRadius));
        }

        private void paramsChange_tmr_Tick(object sender, EventArgs e)
        {
            if (currentRadius > 15) currentRadius -= 2;
            if (commonTick > 150) commonTick -= 50;
            if (bombTick > 200) bombTick -= 50;
            if (circlesChangeTick > 30) circlesChangeTick -= 10;
            if (moveCirclesTick > 5) moveCirclesTick -= 2;
            healthTick += 200;
            commonCirclesAdd_tmr.Interval = commonTick;
            bombCirclesAdd_tmr.Interval = bombTick;
            healthCirclesAdd_tmr.Interval = healthTick;
            circlesChange_tmr.Interval = circlesChangeTick;
            moveCircles_tmr.Interval = moveCirclesTick;
        }

        private void circlesChange_tmr_Tick(object sender, EventArgs e)
        {
            foreach (MyCircle circle in circles) 
            {
                if (circle.enabled) 
                {
                    if (circle.radius > 10) 
                        circle.radius -= 2;
                    else
                    {
                        circle.enabled = false;
                        if (circle.type == "common") 
                        {
                            if (healthPoints > 1) changeHealthPoints(-1);
                            else gameOver();
                        }
                    }
                }
            }


        }

        private void moveCircles_tmr_Tick(object sender, EventArgs e)
        {
            foreach (MyCircle circle in circles) 
            {
                if (circle.o.X > this.Width - 50 || circle.o.X < 50)
                    circle.direction.X *= -1;
                if (circle.o.Y > this.Height - 50 || circle.o.Y < 50)
                    circle.direction.Y *= -1;
                circle.moveCircle();
            }
        }

        private void changeDirectionCircles_tmr_Tick(object sender, EventArgs e)
        {
            foreach (MyCircle circle in circles)
            {
                circle.changeDirection();
            }
        }

        // Using methods

        private void startTimers()
        {
            commonCirclesAdd_tmr.Start();
            bombCirclesAdd_tmr.Start();
            healthCirclesAdd_tmr.Start();
            circlesChange_tmr.Start();
            paramsChange_tmr.Start();
            moveCircles_tmr.Start();
            changeDirectionCircles_tmr.Start();
            main_tmr.Start();
        }

        private void stopTimers()
        {
            commonCirclesAdd_tmr.Stop();
            bombCirclesAdd_tmr.Stop();
            healthCirclesAdd_tmr.Stop();
            circlesChange_tmr.Stop();
            paramsChange_tmr.Stop();
            moveCircles_tmr.Stop();
            changeDirectionCircles_tmr.Stop();
            main_tmr.Stop();
        }

        private double getDistance(Point first, Point second)
        {
            return Math.Sqrt((first.X - second.X) * (first.X - second.X) + (first.Y - second.Y) * (first.Y - second.Y));
        }

        private bool checkIntersectionDotAndCircle(Point dot, Point o, int radius)
        {
            if (getDistance(dot, o) <= radius) return true;
            return false;
        }

        private bool checkIntersectionTwoCircles(MyCircle first, MyCircle second)
        {
            if (getDistance(first.o, second.o) <= first.radius + second.radius) return true;
            return false;
        }

        private void addScores(int scores)
        {
            this.scores += scores;
            score_lbl.Text = this.scores.ToString();
        }

        private void changeHealthPoints(int points)
        {
            healthPoints += points;
            healthPoints_lbl.Text = healthPoints.ToString();
        }

        private MyCircle randomizeCircle(string type, int currentRadius)
        {
            int x, y;

            if (currentRadius + 50 < this.Width - currentRadius - 50)
                x = rnd.Next(currentRadius + 50, this.Width - currentRadius - 50);
            else x = rnd.Next(this.Width - currentRadius - 50, currentRadius + 50);
            if (currentRadius + 50 < this.Height - currentRadius - 50)
                y = rnd.Next(currentRadius + 50, this.Height - currentRadius - 50);
            else y = rnd.Next(this.Height - currentRadius - 50, currentRadius + 50);

            Point o = new Point(x, y);


            Point direction = new Point(rnd.Next(-1, 2), rnd.Next(-1, 2));

            MyCircle newCircle = new MyCircle(currentRadius, o, type, direction);

            foreach (MyCircle circle in circles)
            {
                while (checkIntersectionTwoCircles(newCircle, circle))
                {
                    if (currentRadius + 50 < this.Width - currentRadius - 50)
                        x = rnd.Next(currentRadius + 50, this.Width - currentRadius - 50);
                    else x = rnd.Next(this.Width - currentRadius - 50, currentRadius + 50);
                    if (currentRadius + 50 < this.Height - currentRadius - 50)
                        y = rnd.Next(currentRadius + 50, this.Height - currentRadius - 50);
                    else y = rnd.Next(this.Height - currentRadius - 50, currentRadius + 50);

                    o = new Point(x, y);
                    newCircle.o = o;
                }
            }


            return newCircle;
        }

        private void saveScores() 
        {
            parentForm.serializer.Deserializing();

            foreach (Player player in parentForm.serializer.content.listPlayers)
            {
                if (player.name == parentForm.playerName)
                {
                    if (scores > player.scores)
                        player.scores = scores;
                    break;
                }
            }

            parentForm.serializer.Serializing();
        }

        private void gameOver()
        {
            this.Enabled = false;
            outputSoundtrackDevice.Pause();
            stopTimers();
            string message = "Игра окончена! :(";
            healthPoints_lbl.Text = "0";
            DialogResult result;
            result = MessageBox.Show(message);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                saveScores();
                this.Close();
            }
        }
    }
}
