using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    public class Paint
    {
        Planet Sun, Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune, Pluto;
        public Planet[] planets;
        Point centerPoint;
        Graphics g;
        public Bitmap bt;
        int Wh, Ht;
        Image back;
        public Paint(int Wh, int Ht)
        {
            bt = new Bitmap(Wh, Ht);
            g = Graphics.FromImage(bt);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            centerPoint = new Point(Wh / 2, Ht / 2);
            Default();
            planets = new Planet[] { Sun, Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune, Pluto };
            this.Wh = Wh;
            this.Ht = Ht;
        }
        public Bitmap StandartImage(ref double angle, bool orbit)
        {
            g.Dispose();
            bt.Dispose();
            bt = new Bitmap(Wh, Ht);
            g = Graphics.FromImage(bt);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawImage(back, new Point(0, 0));
            if (orbit)
                DrawOrbits();
            g.DrawImage(planets[0].Image, new Point(centerPoint.X - 30, centerPoint.Y - 30));
            DrawPlanet(ref angle);
            return bt;
        }
        void DrawOrbits()
        {
            int x = 55;
            int rad = 50;
            for (int i = 0; i < 9; i++)
            {
                g.DrawEllipse(Pens.Gray, centerPoint.X - x, centerPoint.Y - x, rad * 2, rad * 2);
                rad += 40;
                x += 40;
            }
        }
        void DrawPlanet(ref double angle)
        {
            for (int i = 1; i < planets.Length; i++)
            {
                if (i == 1)
                {
                    g.DrawImage(planets[i].Image, NewCrd(planets[i], angle, 1.5));
                }
                else
                {
                    g.DrawImage(planets[i].Image, NewCrd(planets[i], angle, 2));
                }
            }
        }
        PointF NewCrd(Planet q, double angle, double z)
        {
            double x = centerPoint.X - q.Image.Size.Width / z + Math.Cos((float)(angle * q.Angle)) * q.Rad;
            double y = centerPoint.Y - q.Image.Size.Height + Math.Sin((float)(angle * q.Angle)) * q.Rad;
            return new PointF((float)x, (float)y);
        }
        void Default()
        {
            back = Image.FromFile(@"Images\Background.jpg");
            Sun = new Planet(0, "Sun", Image.FromFile(@"Images\Sun.png"), 0, 0);
            Mercury = new Planet(10, "Mercury", Image.FromFile(@"Images\Mercury.png"), 50, 0.9F);
            Venus = new Planet(9, "Venus", Image.FromFile(@"Images\Venus.png"), 90, 0.75F);
            Earth = new Planet(8, "Earth", Image.FromFile(@"Images\Earth.png"), 130, 0.5F);
            Mars = new Planet(7, "Mars", Image.FromFile(@"Images\Mars.png"), 170, 0.45F);
            Jupiter = new Planet(6, "Jupiter", Image.FromFile(@"Images\Jupiter.png"), 210, 0.3F);
            Saturn = new Planet(5, "Saturn", Image.FromFile(@"Images\Saturn.png"), 250, 0.25F);
            Uranus = new Planet(4, "Uranus", Image.FromFile(@"Images\Uranus.png"), 290, 0.2F);
            Neptune = new Planet(3, "Neptune", Image.FromFile(@"Images\Neptune.png"), 330, 0.15F);
            Pluto = new Planet(2, "Plutoe", Image.FromFile(@"Images\Pluto.png"), 370, 0.1F);
        }
        void ReAngle(ref float angle)
        {
            if (angle > 2f * Math.PI)
                angle -= 2f * (float)Math.PI;
        }
    }
}
