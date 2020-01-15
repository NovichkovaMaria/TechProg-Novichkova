using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Novichkova
{
    public partial class FormBus : Form
    {
        private ITransport bus;
        public FormBus()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            bus.DrawBus(gr);
            pictureBoxBus.Image = bmp;
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    bus.MoveBus(Direction.Up);
                    break;
                case "buttonDown":
                    bus.MoveBus(Direction.Down);
                    break;
                case "buttonLeft":
                    bus.MoveBus(Direction.Left);
                    break;
                case "buttonRight":
                    bus.MoveBus(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bus = new Bus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black);
            bus.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBus.Width,
           pictureBoxBus.Height);
            Draw();
        }

        private void buttonCreateDouble_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bus = new DoubleBus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
           Color.Yellow, true, true, true, true, true);
            bus.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBus.Width,
           pictureBoxBus.Height);
            Draw();
        }
    }
}
