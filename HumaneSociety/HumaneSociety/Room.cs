using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Room
    {
        private bool available;
        private int roomNumber;

        public bool Available { get { return available; } set { available = value; } }
        public int RoomNumber { get { return roomNumber; } set { roomNumber = value; } }

        public Room(int roomNumber)
        {
            this.available = false;
            this.roomNumber = roomNumber;
        }
    }
}
