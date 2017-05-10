﻿using System.Drawing;

namespace Serenity.Objects
{
    public class Fov
    {
        public Point Resolution { get; set; }

        public Rectangle FieldOfView { get; set; }

        public Point RangeValues { get; set; }

        public Point Tolerance { get; set; }
    }
}
