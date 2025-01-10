﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_02
{
    internal struct Rectangle
    {
        #region Attributes

        private double width;
        private double height;
        #endregion

        #region Properties
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value >= 0) width = value;
                else Console.WriteLine("Value Can't Be Negative");
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value >= 0) height = value;
                else Console.WriteLine("Value Can't Be Negative");
            }
        } 
        public double Area
        {
            get { return width * height; }
        }
        #endregion

        #region Constructor

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        #endregion

        #region Methods
        public void DisplayInfo()
        {
            Console.WriteLine("Rectangle's Info");
            Console.WriteLine($"Width: {Width}, Height: {Height} and Area = {Area}");
        }
        #endregion
    }
}
