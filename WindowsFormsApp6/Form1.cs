using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Очистка фона
            e.Graphics.Clear(Color.White);

            // Рисование круга
            int centerX = ClientSize.Width / 2;
            int centerY = ClientSize.Height / 2;
            int radius = 100;
            e.Graphics.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, radius * 2, radius * 2);

            int hourHandLength = radius - 40;
            int minuteHandLength = radius - 20;
            int hour = DateTime.Now.Hour % 12;
            int minute = DateTime.Now.Minute;
            double hourAngle = (hour + minute / 60.0) * 30 * Math.PI / 180;
            double minuteAngle = minute * 6 * Math.PI / 180;
            int hourHandX = (int)(centerX + hourHandLength * Math.Sin(hourAngle));
            int hourHandY = (int)(centerY - hourHandLength * Math.Cos(hourAngle));
            int minuteHandX = (int)(centerX + minuteHandLength * Math.Sin(minuteAngle));
            int minuteHandY = (int)(centerY - minuteHandLength * Math.Cos(minuteAngle));
            e.Graphics.DrawLine(Pens.Black, centerX, centerY, hourHandX, hourHandY);
            e.Graphics.DrawLine(Pens.Black, centerX, centerY, minuteHandX, minuteHandY);
        }

    }
}
