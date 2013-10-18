using Physics_Simulator_2D.Objects;
using Physics_Simulator_2D.Place;
using Physics_Simulator_2D.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Physics_Simulator_2D
{
    public partial class Form1 : Form
    {
        private World MyWorld;
        private SolidBrush MyBrush;
        private int TimeInverval = 100;
        private bool IsMouseDown = false;
        private Point MouseDownPoint;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = TimeInverval;
            timer1.Enabled = true;
            MyWorld = new World(panel1.Width, panel1.Height);

            option_Trace.Checked = true;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int diam = 8;
            int x = MouseDownPoint.X;
            int y = MouseDownPoint.Y;
            Circle o = new Circle(diam, x - diam, panel1.Height - y + (diam / 2), 40, 0, 0, 0, 10, Color.FromArgb(255, 0, 0, 0));
            MyWorld.AddObject(o);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Double time = (Double)TimeInverval;
            MyWorld.Update(time/1000D);
            if(option_Trace.Checked == false) Clear();
            Draw();
        }

        private void Draw()
        {
            List<PhysicalPoint> objectList = MyWorld.GetObjectList();

            Graphics g = panel1.CreateGraphics();
            
            foreach (PhysicalPoint o in objectList)
            {
                MyBrush = new SolidBrush(o.BasicColor);

                if (o.Shape().Equals("Point"))
                {                   
                    g.FillEllipse(MyBrush, (int)o.Location.X, panel1.Height - (int)o.Location.Y, 4, 4);
                }
                else if (o.Shape().Equals("Circle"))
                {
                    Circle o2 = (Circle)o;
                    g.FillEllipse(MyBrush, (int)o.Location.X, panel1.Height - (int)o.Location.Y, (int)o2.Diameter, (int)o2.Diameter);
                    Console.WriteLine(o2.GetAngleDegrees());
                }                             
            }

            g.Dispose();
        }

        private void Clear()
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
        }

        private void option_PlayPause_Click(object sender, EventArgs e)
        {
            if (MyWorld.Play)
            {
                MyWorld.Play = false;
                option_PlayPause.Text = ">";
            }
            else
            {
                MyWorld.Play = true;
                option_PlayPause.Text = "||";
            }
        }

        private void option_Clear_Click(object sender, EventArgs e)
        {
            MyWorld.Clear();
            Clear();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            MouseDownPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                Clear();
                Graphics g = panel1.CreateGraphics();
                Pen pen = new Pen(new SolidBrush(Color.Gray), 2);
                g.DrawLine(pen, MouseDownPoint, new Point(e.X, e.Y));
            }
        }
    }
}
