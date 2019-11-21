using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Ships
{
    public class Portaaviones : Ship
    {
        private int lifes;
        private int move;
        private string direction;
        private string special;

        public Portaaviones(string name, int positionX, int positionY, int lifes, int move, string direction, string special)
        {
            Name = "Portaaviones";
            PositionX = positionX;
            PositionY = positionY;
            Lifes = 5;
            Move = 1;
            Direction = direction;
            Special = "P";

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

        public override void MoveShip(string shipDirection)
        {
            if (shipDirection == "Left" && positionY-1 >= 0)
            {
                PositionY -= 1;
            }

            else if (shipDirection == "Right" && positionY + 1 >= 10)
            {
                PositionX += 1;
            }
            else if (shipDirection == "Up" && positionX + 1  >= 10)
            {
                PositionX += 1;
            }
            else if (shipDirection == "Down" && positionX + 1 >= 10)
            {
                PositionX += 1;
            }
        }

    }
}
