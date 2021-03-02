using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._1_лаба
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Bitmap bmp = new Bitmap(1000, 600);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Red, 4);

            graph.DrawLine(pen, 20, 20, 100, 100);//Отрезок
            pictureBox1.Image = bmp;

            graph.DrawRectangle(pen, 100, 20, 200, 80);//Прямоугольник

            graph.DrawEllipse(pen, 100, 20, 200, 80);//Эллипс в прямоугольнике

            Point point1 = new Point(300, 100);
            Point point2 = new Point(340, 90);
            Point point3 = new Point(370, 40);
            Point point4 = new Point(400, 120);
            Point point5 = new Point(450, 50);
            Point[] curvePoints1 = { point1, point2, point3, point4, point5};

            graph.DrawLines(pen, curvePoints1);//Ломаная

            Point point6 = new Point(300, 200);
            Point point7 = new Point(340, 140);
            Point point8 = new Point(370, 140);
            Point point9 = new Point(380, 220);
            Point point10 = new Point(350, 240);
            Point point11 = new Point(300, 200);
            Point[] curvePoints2 = { point6, point7, point8, point9, point10, point11};

            graph.DrawLines(pen, curvePoints2);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
