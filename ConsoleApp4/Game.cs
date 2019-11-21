using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Game
    {
        private Player[] players;
        private Player activePlayer;
        List<string> shipsNames = new List<string>() { "Radar", "Reparador", "Submarino", "Fragata","Portaaviones"};
        List<string> direction = new List<string>() {"Vertical", "Horizontal" };
        private int size;
        public Game()
        {
        }

        public Player[] Players
        {
            get
            {
                return this.players;
            }
        }

        public Player ActivePlayer
        {
            get
            {
                return this.activePlayer;
            }
            set
            {
                activePlayer = value;
            }
        }

        public void SetShips(int id, Board board, Ship ship)
        {
            Console.WriteLine("Input the X position (0-9)");
            int x = Static.GetUserInput(9);
            Console.WriteLine("Input the Y position (0-9)");
            int y = Static.GetUserInput(9);
            Static.ShowListOptions(shipsNames, "Select ship to place");
            int shipSelected = Static.GetUserInput(shipsNames.Count);
            Static.ShowListOptions(direction, "Select direction");
            int directionSelected = Static.GetUserInput(direction.Count);
            size = shipSelected + 1;
            players[id].PlaceShip(x, y, size);

        }
    }

}
