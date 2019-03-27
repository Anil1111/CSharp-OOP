﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Coordinate
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }

        public Coordinate(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
    }
}