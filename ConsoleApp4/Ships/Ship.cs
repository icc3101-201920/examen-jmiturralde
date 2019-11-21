using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class Ship
    {
        protected string name;
        protected int positionX;
        protected int positionY;

        public Ship()
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int PositionX
        {
            get
            {
                return this.positionX;
            }
            set
            {
                this.positionX = value;
            }
        }

        public int PositionY
        {
            get
            {
                return this.positionY;
            }
            set
            {
                this.positionY = value;
            }
        }

        public virtual void MoveShip(string shipDirection)
        {
            this.positionX += 0;
            this.positionY += 0;
        }
    }
}
