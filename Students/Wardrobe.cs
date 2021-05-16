using System;
using System.Collections.Generic;
using System.Text;

namespace _15_05_Quest
{
    class Wardrobe
    {
        int n;
        public bool[] clothes;
        bool[] numbers;
        int NumberValue;
        bool full;

        public Wardrobe()
        {
            n = 10;
            clothes = new bool[n];
            numbers = new bool[n];
            full = false;
            NumberValue = 0;
        }

        public void GiveNumber()
        {
            if (!full)
            {
                for (int i = 0;i < n;i++)
                {
                    if (numbers[i] == false)
                    {
                        numbers[i] = true;
                        clothes[i] = true;
                        NumberValue += 1;
                    }
                }
            }
        }

        public void GiveClothes()
        {
            for (int i = 0;i < 10;i++)
            {
                if (numbers[i] == true)
                {
                    clothes[i] = false;
                    numbers[i] = false;
                    NumberValue -= 1;
                }
            }
        }

        public bool IsFull()
        {
            for (int i = 0;i < n;i++)
            {
                if (NumberValue == clothes.Length)
                {
                    full = true;
                }
                else
                {
                    full = false;
                }
            }
            return full;
        }
    }
}
