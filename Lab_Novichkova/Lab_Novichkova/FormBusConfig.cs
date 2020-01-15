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
    public partial class FormBusConfig : Form
    {
        ITransport bus = null;
        private event busDelegate eventAddBus;

        public FormBusConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelAqua.MouseDown += panelColor_MouseDown;
            panelPurpe.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawBus()
        {
            if (bus != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bus.SetPosition(5, 5, pictureBoxBus.Width, pictureBoxBus.Height);
                bus.DrawBus(gr);
                pictureBoxBus.Image = bmp;
            }
        }

        public void AddEvent(busDelegate ev)
        {
            if (eventAddBus == null)
            {
                eventAddBus = new busDelegate(ev);
            }
            else
            {
                eventAddBus += ev;
            }
        }

        private void labelBus_MouseDown(object sender, MouseEventArgs e)
        {
            labelBus.DoDragDrop(labelBus.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }

        private void labelDoubleBus_MouseDown(object sender, MouseEventArgs e)
        {
            labelDoubleBus.DoDragDrop(labelDoubleBus.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }

        private void panelBus_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelBus_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Автобус":
                    bus = new Bus(100, 500, Color.White);
                    break;
                case "Автобус с гармошкой":
                    bus = new DoubleBus(100, 500, Color.White, Color.Black, true, true,
                   true, true, true);
                    break;
            }
            DrawBus();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
           DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                bus.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawBus();
            }
        }
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                if (bus is DoubleBus)
                {
                    (bus as DoubleBus).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawBus();
                }
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddBus?.Invoke(bus);
            Close();
        }
    }
}
