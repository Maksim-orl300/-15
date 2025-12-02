using System;

namespace ConsoleApp19
{
    interface OnOrOff
    {
        void onOrOff();
    }
    interface SetLevel
    {
        void setLevel(int l);
    }
    class Lamp : SetLevel,OnOrOff
    {
        private int level;
        private bool on;

        public Lamp()
        {
            level = 0;
            on = false;
        }

        public void setLevel(int l)
        {
            level = l;
            on = true;
            Console.WriteLine($"Лампа включена, освещенность: {level}");
        }
        public void onOrOff()
        {
            on = !on;
            level = level == 100 ? 0 : 100;
            string onoroff = on ? "включена" : "выключена";
            Console.WriteLine($"Лампа {onoroff}");
        }

    }

    class Fan : OnOrOff
    {
        private bool on;
        public Fan()
        {
            on = !true;
        }
        public void onOrOff()
        {
            on = !on;
            string onoroff = on ? "включен" : "выключен";
            Console.WriteLine($"Вентилятор {onoroff}");
        }
    }

}
