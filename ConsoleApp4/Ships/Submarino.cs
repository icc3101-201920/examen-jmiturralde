using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Ships
{
    public class Submarino : Ship
    {
        private int lifes;
        private int move;
        private string direction;
        private string special;

        public Submarino(string name, int positionX, int positionY, int lifes, int move, string direction, string special)
        {
            Name = "Submarino";
            PositionX = positionX;
            PositionY = positionY;
            Lifes = 3;
            Move = 3;
            Direction = direction;
            Special = "S";

        }

        public int Lifes
        {
            get
            {
                return this.lifes;
            }
            set
            {
                this.lifes = value;
            }
        }
        public int Move
        {
            get
            {
                return this.move;
            }
            set
            {
                this.move = value;
            }
        }
        public string Direction
        {
            get
            {
                return this.direction;
            }
            set
            {
                this.direction = value;
            }
        }
        public string Special
        {
            get
            {
                return this.special;
            }
            set
            {
                this.special = value;
            }
        }
    }
}
