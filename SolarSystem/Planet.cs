using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    public class Planet
    {
        public float Speed { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }
        public float Angle { get; set; }
        public int Rad { get; set; }
        public Planet(float speed, string name, Image image, int rad, float angle)
        {
            Speed = speed;
            Name = name;
            Image = image;
            Rad = rad;
            Angle = angle;
        }
    }
}
