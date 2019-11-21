using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Player
    {
        private static int idCounter;
        private const int NUMBER_OF_SHIPS = 5;

        private int id;
        private int numerOfShips;
        private Ship ship;
        private Board board;


        public Player()
        {
            Id = idCounter++;
            NumerOfShips = NUMBER_OF_SHIPS;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public int NumerOfShips
        {
            get
            {
                return this.numerOfShips;
            }
            set
            {
                this.numerOfShips = value;
            }
        }

        public void PlaceShip(int x, int y, int size)
        {
            for (int x1=0; x<=9; x1++)
            {
                for (int y1 = 0; y1 <= 9; y1++)
                {

                }
            }
        }
    }
}
