using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Board
    {
        private const int X_DIMENSION = 10;
        private const int Y_DIMENSION = 10;

        private int xDimension;
        private int yDimension;

        public Board()
        {
            XDimension = X_DIMENSION;
            YDimension = Y_DIMENSION;
        }
        public int XDimension
        {
            get
            {
                return this.xDimension;
            }
            set
            {
                this.xDimension = value;
            }
        }
        public int YDimension
        {
            get
            {
                return this.yDimension;
            }
            set
            {
                this.yDimension = value;
            }
        }


    }
}
