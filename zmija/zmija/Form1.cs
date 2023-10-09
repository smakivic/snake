using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace zmija
{
    public partial class Form1 : Form
    {


        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle { X=-1,Y=-1};

        int maxWidth;
        int maxHeight;

        int score;
        
        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp, end;


        public Form1()
        {
            InitializeComponent();

            new Settings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
          

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && Settings.directions != "right" )
            {
                goLeft = true;

            }

            if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && Settings.directions != "left")
            {
                goRight = true;

            }

            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && Settings.directions != "down")
            {
                goUp = true;

            }

            if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && Settings.directions != "up")
            {
                goDown = true;

            }


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A )
            {
                goLeft = false;

            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = false;

            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = false;

            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = false;

            }



        }

        private void start_button_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void snimi_button_Click(object sender, EventArgs e)
        {



            
        }

        private void game_Timer_Tick(object sender, EventArgs e)
        {

            // postavljanje smjera

            if(goLeft)
            {
                Settings.directions = "left";
            }
            else if(goRight)
            {
                Settings.directions = "right";
            }
            else if(goUp)
            {
                Settings.directions = "up";
            }
            else if(goDown)
            {
                Settings.directions = "down";
            }

            // kraj postavljanja smjera


            //pomjeranje zmije
            for (int i = Snake.Count -1; i >= 0; i--)
            {
                if(i== 0)
                {
                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }
                    
                    if(Snake[i].X<0 || Snake[i].X > maxWidth || Snake[i].Y < 0 || Snake[i].Y > maxHeight)
                    {
                        GameOver();
                    }
                    
                    if(Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }


                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if(Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }


                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

            
            pic_canvas.Invalidate();


        }

        private void txt_score_Click(object sender, EventArgs e)
        {

        }

        private void pic_canvas_Paint(object sender, PaintEventArgs e)
        {


            Graphics canvas = e.Graphics;

            Image img;
            string putanja;
            for (int i = 0; i < Snake.Count; i++)
            {
                if(i==0)
                {
                    putanja = System.IO.Directory.GetCurrentDirectory();
                    img = Image.FromFile(putanja+"\\glava.png");

                }
                else
                {
                    putanja = System.IO.Directory.GetCurrentDirectory();
                    img = Image.FromFile(putanja + "\\tijelo.jpg");
                }


                
                canvas.DrawImage(img, new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height,Settings.Width,Settings.Height));
               if(end==true)
                {
                    canvas.FillEllipse(Brushes.White, new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height, Settings.Width, Settings.Height));

                }




            }

            putanja = System.IO.Directory.GetCurrentDirectory();
            Image img2 = Image.FromFile(putanja + "\\jabuka.png");

            canvas.DrawImage(img2, new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height));

            if (end == true)
            {
                canvas.FillEllipse(Brushes.White, new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height));
                end = false;
            }

        }




        private void RestartGame()
        {
            end = false;
            maxWidth = pic_canvas.Width / Settings.Width - 1;
            maxHeight = pic_canvas.Height / Settings.Height - 1;
           

            Snake.Clear();

            start_button.Enabled = false;
           
            score = 0;
            txt_score.Text = "Score: " + score;
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head); // dodavanje "glave" zmije u listu 


            for(int i = 0; i < 6; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }
 

            food = new Circle { X = rand.Next(2,maxWidth), Y = rand.Next(2,maxHeight) };
            game_Timer.Start();




        }

        private void EatFood()
        {


            score++;
            txt_score.Text = "Score: " + score;


            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }

        private void GameOver()
        {

            end = true;
            game_Timer.Stop();
            start_button.Enabled = true;
           


            MessageBox.Show("Izgubili ste! Pokusajte ponovo!");

            Snake.Clear();

            score = 0;
            txt_score.Text = "Score: " + score;
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head); // dodavanje "glave" zmije u listu 

        }



    }
}
