using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_Novichkova
{
    class DoubleBus
    {
        protected float _startPosX;
        protected float _startPosY;
        protected int _pictureWidth;
        protected int _pictureHeight;
        private const int busWidth = 100;
        private const int busHeight = 60;
        public Color DopColor { private set; get; }
        public bool FirstBus { private set; get; }
        public bool MidBus { private set; get; }
        public bool SecondBus { private set; get; }
        public bool Windows { private set; get; }
        public bool Doors { private set; get; }
        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }
        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public DoubleBus(int maxSpeed, float weight, Color mainColor, Color dopColor,
         bool firstBus, bool midBus, bool secondBus, bool windows, bool doors)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FirstBus = firstBus;
            MidBus = midBus;
            SecondBus = secondBus;
            Windows = windows;
            Doors = doors;
        }
        public void MoveBus(Direction direction)
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
        public void DrawBus(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            if (FirstBus)
            {
                Brush brush = new SolidBrush(MainColor);
                g.FillRectangle(brush, _startPosX - 5, _startPosY, 65, 40);
                g.DrawRectangle(pen, _startPosX - 5, _startPosY, 65, 40);
                Brush brush1 = new SolidBrush(Color.Black);
                g.FillEllipse(brush1, _startPosX + 4, _startPosY + 35, 16, 16);
                g.FillEllipse(brush1, _startPosX + 42, _startPosY + 35, 16, 16);
            }
            if (MidBus)
            {
                Brush brush = new SolidBrush(DopColor);
                g.FillRectangle(brush, _startPosX + 60, _startPosY + 5, 10, 30);
                g.DrawRectangle(pen, _startPosX + 60, _startPosY + 5, 10, 30);
            }
            if (SecondBus)
            {
                Brush brush = new SolidBrush(MainColor);
                g.FillRectangle(brush, _startPosX + 70, _startPosY, 55, 40);
                g.DrawRectangle(pen, _startPosX + 70, _startPosY, 55, 40);
                Brush brush1 = new SolidBrush(Color.Black);
                g.FillEllipse(brush1, _startPosX + 72, _startPosY + 35, 16, 16);
                g.FillEllipse(brush1, _startPosX + 108, _startPosY + 35, 16, 16);
            }
            if (Windows)
            {
                Brush brBlue = new SolidBrush(Color.LightBlue);
                g.FillRectangle(brBlue, _startPosX + 5, _startPosY + 5, 15, 25);
                g.FillRectangle(brBlue, _startPosX + 43, _startPosY + 5, 16, 25);
                g.FillRectangle(brBlue, _startPosX + 70, _startPosY + 5, 18, 25);
                g.FillRectangle(brBlue, _startPosX + 108, _startPosY + 5, 17, 25);
                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 5, 15, 25);
                g.DrawRectangle(pen, _startPosX + 43, _startPosY + 5, 16, 25);
                g.DrawRectangle(pen, _startPosX + 70, _startPosY + 5, 18, 25);
                g.DrawRectangle(pen, _startPosX + 108, _startPosY + 5, 17, 25);
            }
            if (Doors)
            {
                Brush brBlue = new SolidBrush(Color.LightBlue);
                g.FillRectangle(brBlue, _startPosX - 5, _startPosY + 5, 10, 35);
                g.DrawRectangle(pen, _startPosX - 5, _startPosY + 5, 10, 35);
                g.FillRectangle(brBlue, _startPosX + 20, _startPosY + 5, 11, 35);
                g.DrawRectangle(pen, _startPosX + 20, _startPosY + 5, 11, 35);
                g.FillRectangle(brBlue, _startPosX + 32, _startPosY + 5, 11, 35);
                g.DrawRectangle(pen, _startPosX + 32, _startPosY + 5, 11, 35);
                g.FillRectangle(brBlue, _startPosX + 87, _startPosY + 5, 10, 35);
                g.DrawRectangle(pen, _startPosX + 87, _startPosY + 5, 10, 35);
                g.FillRectangle(brBlue, _startPosX + 98, _startPosY + 5, 10, 35);
                g.DrawRectangle(pen, _startPosX + 98, _startPosY + 5, 10, 35);
            }      
        }
    }
}
