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
        MultiLevelParking parking;
        private const int countLevel = 5;

        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width,
           pictureBoxParking.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevel.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevel.SelectedIndex = 0;
        }

        private void Draw()
        {
            if (listBoxLevel.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
               pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevel.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        private void buttonSetBus_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var bus = new Bus(100, 1000, dialog.Color);
                    int place = parking[listBoxLevel.SelectedIndex] + bus;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }

        private void buttonSetDoubleBus_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var car = new DoubleBus(100, 1000, dialog.Color,
                       dialogDop.Color, true, true, true, true, true);
                        int place = parking[listBoxLevel.SelectedIndex] + car;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }

        private void buttonTakeBus_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var car = parking[listBoxLevel.SelectedIndex] -
                   Convert.ToInt32(maskedTextBox.Text);
                    if (car != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeBus.Width,
                       pictureBoxTakeBus.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        car.SetPosition(5, 5, pictureBoxTakeBus.Width,
                       pictureBoxTakeBus.Height);
                        car.DrawBus(gr);
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

        private void listBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
