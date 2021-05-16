using System;

namespace _15_05_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            int visiterCount = 10;
            Visiter[] visiter = new Visiter[visiterCount];
            for (int i = 0;i < visiterCount; i++)
            {
                visiter[i] = new Visiter(i);
            }

            Wardrobe wardrobe = new Wardrobe();
            ReadingRoom readingRoom = new ReadingRoom();

            for (int i = 0; i < visiterCount; i++)
            {
                visiter[i].TakeNumber(wardrobe);
                Console.WriteLine(visiter[i].IsNumberTaken());
                readingRoom.EnterTheRoom(visiter[i]);
                Console.WriteLine(readingRoom.IsVisiterAdd(visiter[i]));
                visiter[i].TakeClothes(wardrobe);
                Console.WriteLine(visiter[i].IsNumberGived(readingRoom));
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
