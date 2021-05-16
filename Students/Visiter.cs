using System;
using System.Collections.Generic;
using System.Text;

namespace _15_05_Quest
{
    class Visiter
    {
        public int id { get; }
        public bool NumberIsTaken;

        public Visiter()
        {
            id = 0;
            NumberIsTaken = false;
        }

        public Visiter(int id)
        {
            for (int i = 0;i < 100;i++)
            {
                this.id = id;
            }

            NumberIsTaken = false;
        }

        public void TakeNumber(Wardrobe wardrobe)
        {
            if (!wardrobe.IsFull())
            {
                for (int i = 0; i < 10;i++)
                {
                    wardrobe.GiveNumber();
                    NumberIsTaken = true;
                }
            }
        }

        public void TakeClothes(Wardrobe wardrobe)
        {
            for (int i = 0;i < 10;i++)
            {
                if (NumberIsTaken)
                {
                    wardrobe.GiveClothes();
                    NumberIsTaken = false;
                }
            }
        }

        public string IsNumberTaken()
        {
            if (NumberIsTaken)
            {
                return $"Номерок {id} получен, одежда сдана в гардероб";
            }
            return "Похоже гардероб переполнен";
        }

        public string IsNumberGived(ReadingRoom readingRoom)
        {
            if (readingRoom.Entered)
            return $"Номерок {id} сдан, одежда получена";

            return "Что-то пошло не так(((";
        }
    }
}
