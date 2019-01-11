﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Paint
{

    interface Shape
    {
        void Draw(Graphics g);
        void SetParam(int x, int y, int width, int height, Color color);
    }
}
