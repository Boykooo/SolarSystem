using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarSystem
{
    public partial class MainForm : Form
    {
        Paint draw;
        public MainForm()
        {
            InitializeComponent();
            draw = new Paint(pictureBox1.Width, pictureBox1.Height);
            timer1.Interval = 30;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = e.X + ";" + e.Y;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = draw.StandartImage(ref angle, true);
        }

        double angle = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = draw.StandartImage(ref angle, OrbitCheck.Checked);
            if (Check.CheckInput(SpeedText.Text))
                angle += Convert.ToDouble(SpeedText.Text);
            else
            {
                timer1.Stop();
                MessageBox.Show("Ошибка!");
                paint = false;
                StartButton.Text = "Запустить";
            }
        }

        bool paint = false;
        private void button1_Click(object sender, EventArgs e)
        {
            switch (paint)
            {
                case true:
                    timer1.Stop();
                    paint = false;
                    StartButton.Text = "Запустить";
                    break;
                case false:
                    StartButton.Text = "Остановить";
                    timer1.Start();
                    paint = true;
                    break;
            }
            
        }
    }
}
