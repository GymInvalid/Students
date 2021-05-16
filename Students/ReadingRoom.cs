using System;
using System.Collections.Generic;
using System.Text;

namespace _15_05_Quest
{
    class ReadingRoom
    {
        public List<int> IdList;
        public bool Entered;

        public ReadingRoom()
        {
            IdList = new List<int>(10);
            Entered = false;
        }

        public void EnterTheRoom(Visiter visiter)
        {
            if (visiter.NumberIsTaken)
            {
                IdList.Add(visiter.id);
                Entered = true;
            }
        }

        public string IsVisiterAdd(Visiter visiter)
        {
            if (visiter.NumberIsTaken)
            {
                return $"Посетитель зашёл в читальный зал, записан под номером {visiter.id}";
            }
            return $"Посетитель {visiter.id} не имеет номерка";
        }
    }
}
