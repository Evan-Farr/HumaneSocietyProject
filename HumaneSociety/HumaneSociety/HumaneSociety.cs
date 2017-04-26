using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class HumaneSociety
    {
        public Dictionary<Animal, string> animals;
        public List<Room> rooms;

        public HumaneSociety()
        {
            animals = new Dictionary<Animal, string>();
            rooms = new List<Room>();
            BuildRooms(10);
        }

        public string GenerateUniqueID()
        {
            Random random = new Random();
            int newRandom = random.Next(100000);
            for (int i = 0; i < animals.Count; i++)
            {
                if (newRandom.Equals(i))
                {
                    GenerateUniqueID();
                }
            }
            string ID = newRandom.ToString();
            return ID;
        }

        public void BuildRooms(int amount)
        {
            for(int i = 0; i < amount; i++)
            {
                Room room = new Room(GenerateRoomNumber());
                rooms.Add(room);
            }
        }

        public int GenerateRoomNumber()
        {
            int roomNumber = rooms.Count + 1;
            return roomNumber;
        }

        public void FindOpenRoom(List<Room> rooms)
        {
            var openRooms = rooms.Where(r => r.Available == true);
            foreach(var room in openRooms)
            {
                Console.WriteLine(room.RoomNumber + "\n");
            }
        }

        public void IntakeAnimal(Animal animal)
        {
            animals.Add(animal, animal.ID);

            Console.WriteLine("Open rooms: ");
            FindOpenRoom(rooms);
            AddAnimalToRoom(animal);
        }

        public void AddAnimalToRoom(Animal animal)
        {
            Console.WriteLine($"Enter the room number where {animal.Name} should be placed.");
            int placement = int.Parse(Console.ReadLine());
            var room = rooms.Where(r => r.RoomNumber == placement);
            foreach(var r in room)
            {
                r.Animal = animal;
                r.Available = false;
                break;
            }
        }

        public void SpayNeuter(IMedical animal)
        {
            animal.SpayedNeutered = true;
        }

        public void GiveShots(IMedical animal)
        {
            animal.Shots = true;
        }

        public void DeClaw(Cat cat)
        {
            cat.DeClawed = true;
        }
    }
}
