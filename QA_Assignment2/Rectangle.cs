using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Assignment2
{
    public class Rectangle
    {
        private int width;
        private int height;

        public Rectangle()
        {
            this.width = 1;
            this.height = 1;
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }
    }
}
