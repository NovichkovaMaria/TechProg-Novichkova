using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Novichkova
{
    class Bus : AbstractBus
    {
        protected const int busWidth = 90;
        protected const int busHeight = 50;
        public Bus(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public override void MoveBus(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - busWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - busHeight)

                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawBus(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(MainColor);
            g.FillRectangle(brush, _startPosX, _startPosY, 90, 45);
            g.DrawRectangle(pen, _startPosX, _startPosY, 90, 45);
            Brush brush1 = new SolidBrush(Color.Black);
            g.FillEllipse(brush1, _startPosX + 10, _startPosY + 35, 20, 20);
            g.FillEllipse(brush1, _startPosX + 55, _startPosY + 35, 20, 20);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX, _startPosY + 5, 28, 25);
            g.FillRectangle(brBlue, _startPosX + 47, _startPosY + 5, 25, 25);
            g.DrawRectangle(pen, _startPosX, _startPosY + 5, 28, 25);
            g.DrawRectangle(pen, _startPosX + 47, _startPosY + 5, 25, 25);
            g.FillRectangle(brBlue, _startPosX + 30, _startPosY + 5, 15, 40);
            g.DrawRectangle(pen, _startPosX + 30, _startPosY + 5, 15, 40);
            g.FillRectangle(brBlue, _startPosX + 75, _startPosY + 5, 15, 40);
            g.DrawRectangle(pen, _startPosX + 75, _startPosY + 5, 15, 40);
        }
    }
}
