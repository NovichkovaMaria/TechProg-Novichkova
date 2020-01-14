using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Novichkova
{
    class DoorClassBlue : IDoors
    {
        public DoorCount Count { private set; get; }
        public Color FirstColor { private set; get; }
        public float globalPosX;
        public float globalPosY;
        public DoorClassBlue(DoorCount doorCount, Color firstColor, 
         float posX, float posY)
        {
            FirstColor = firstColor;
            Count = doorCount;
            globalPosX = posX;
            globalPosY = posY;
        }
        public void DrawDoor(Graphics g)
        {
            Brush brBlue = new SolidBrush(Color.LightBlue);
            Pen pen = new Pen(FirstColor);
            switch (Count)
            {
                case DoorCount.THREE:

                    g.FillRectangle(brBlue, globalPosX - 5, globalPosY + 5, 10, 35);
                    g.DrawRectangle(pen, globalPosX - 5, globalPosY + 5, 10, 35);
                    g.FillRectangle(brBlue, globalPosX + 20, globalPosY + 5, 11, 35);
                    g.DrawRectangle(pen, globalPosX + 20, globalPosY + 5, 11, 35);
                    g.FillRectangle(brBlue, globalPosX + 98, globalPosY + 5, 10, 35);
                    g.DrawRectangle(pen, globalPosX + 98, globalPosY + 5, 10, 35);
                    break;
                case DoorCount.FOUR:
                    g.FillRectangle(brBlue, globalPosX - 5, globalPosY + 5, 10, 35);
                    g.DrawRectangle(pen, globalPosX - 5, globalPosY + 5, 10, 35);
                    g.FillRectangle(brBlue, globalPosX + 20, globalPosY + 5, 11, 35);
                    g.DrawRectangle(pen, globalPosX + 20, globalPosY + 5, 11, 35);
                    g.FillRectangle(brBlue, globalPosX + 32, globalPosY + 5, 11, 35);
                    g.DrawRectangle(pen, globalPosX + 87, globalPosY + 5, 10, 35);
                    g.FillRectangle(brBlue, globalPosX + 98, globalPosY + 5, 10, 35);
                    g.DrawRectangle(pen, globalPosX + 98, globalPosY + 5, 10, 35);
                    break;
                case DoorCount.FIVE:
                    g.FillRectangle(brBlue, globalPosX - 5, globalPosY + 5, 10, 35);
                    g.DrawRectangle(pen, globalPosX - 5, globalPosY + 5, 10, 35);
                    g.FillRectangle(brBlue, globalPosX + 20, globalPosY + 5, 11, 35);
                    g.DrawRectangle(pen, globalPosX + 20, globalPosY + 5, 11, 35);
                    g.FillRectangle(brBlue, globalPosX + 32, globalPosY + 5, 11, 35);
                    g.DrawRectangle(pen, globalPosX + 32, globalPosY + 5, 11, 35);
                    g.FillRectangle(brBlue, globalPosX + 87, globalPosY + 5, 10, 35);
                    g.DrawRectangle(pen, globalPosX + 87, globalPosY + 5, 10, 35);
                    g.FillRectangle(brBlue, globalPosX + 98, globalPosY + 5, 10, 35);
                    g.DrawRectangle(pen, globalPosX + 98, globalPosY + 5, 10, 35);
                    break;
            }
        }
    }
}
