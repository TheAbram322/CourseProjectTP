using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CloneOSU2
{
    class MyCircle
    {
        
        public MyCircle(int radius, Point o, string type, Point direction) 
        {
            this.radius = radius;
            this.o.X = o.X;
            this.o.Y = o.Y;
            this.type = type;
            this.enabled = true;
            if (type == "common") image = Resources.Circle;
            else if (type == "bomb") image = Resources.Bomb;
            else image = Resources.Health;
            this.direction = direction;
        }
        public Bitmap image;
        public int radius;
        public Point o;
        public string type;
        public bool enabled;
        public Point direction;

        public void draw(Graphics g) 
        {
            g.TranslateTransform(0, 0) ;
            g.DrawImage(image, new Rectangle(o.X - radius, o.Y - radius , 2*radius, 2*radius));
        }

        public void moveCircle() 
        {
            o.X += direction.X * 2;
            o.Y += direction.Y * 2;
        }

        public void changeDirection() 
        {
            Random rnd = new Random();
            direction.X = rnd.Next(-1, 2);
            direction.Y = rnd.Next(-1, 2);
        }
    }
}
