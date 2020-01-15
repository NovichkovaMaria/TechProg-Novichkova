﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Novichkova
{
    interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveBus(Direction direction);
        void DrawBus(Graphics g);
    }
}
