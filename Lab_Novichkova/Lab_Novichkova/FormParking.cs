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
    public partial class FormParking : Form
    {
        Parking<ITransport> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(20, pictureBoxParking.Width,
           pictureBoxParking.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        private void buttonSetBus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var bus = new Bus(100, 1000, dialog.Color);
                int place = parking + bus;
                Draw();
            }
        }
        private void buttonSetBus2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var bus = new DoubleBus(100, 1000, dialog.Color, dialogDop.Color, true, true, true, true, true);
                    int place = parking + bus;
                    Draw();
                }
            }
        }
        private void buttonTakeBus_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var bus = parking - Convert.ToInt32(maskedTextBox.Text);
                if (bus != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeBus.Width, pictureBoxTakeBus.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    bus.SetPosition(5, 5, pictureBoxTakeBus.Width,
                   pictureBoxTakeBus.Height);
                    bus.DrawBus(gr);
                    pictureBoxTakeBus.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeBus.Width,
                   pictureBoxTakeBus.Height);
                    pictureBoxTakeBus.Image = bmp;
                }
                Draw();
            }
        }
    }
}
