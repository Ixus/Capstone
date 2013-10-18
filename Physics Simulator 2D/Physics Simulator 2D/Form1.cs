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

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = TimeInverval;
            timer1.Enabled = true;
            MyWorld = new World(panel1.Width, panel1.Height);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            PhysicalPoint o = new PhysicalPoint(e.X, panel1.Height - e.Y, 40, 40, 0, 0, 10, Color.Black);
            MyWorld.AddObject(o);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Double time = (Double)TimeInverval;
            MyWorld.Update(time/1000D);
            //Clear();
            Draw();
        }

        private void Draw()
        {
            List<PhysicalPoint> objectList = MyWorld.GetObjectList();

            Graphics g = panel1.CreateGraphics();

            foreach (PhysicalPoint o in objectList)
            {               
                MyBrush = new SolidBrush(o.BasicColor);
                g.FillEllipse(MyBrush, (int)o.Location.X, panel1.Height - (int)o.Location.Y, PhysicalPoint.DefaultDiamater, PhysicalPoint.DefaultDiamater);               
            }

            g.Dispose();
        }

        private void Clear()
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
        }
    }
}
