using System;

namespace ConsoleApp36
{
    interface Charge
    {
        void charge();
    }
    interface Work
    {
        void work();
    }
    class Robot : Work, Charge
    {
        private readonly string name;
        private int energy;

        public Robot(string n)
        {
            name = n;
            energy = 100;
        }
        public void work()
        {
            if (energy - 20 >= 0)
            {
                energy -= 20;
                Console.WriteLine($"Робот {name} работает заряд {energy}.");

            }
            else
            {
                Console.WriteLine($"Ошибка: слишком маленькая зарядка {energy} ");
            }
        }
        public void charge()
        {
            if (energy + 50 > 100)
            {
                Console.WriteLine($" {name} зарядка  не нужна {energy}  ");
            }
            else
            {
                energy += 50;
                Console.WriteLine($"{name} зарядился, зарядка больше не нужна {energy}");
            }

        }
    }
}
