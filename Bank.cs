using System;

namespace ConsoleApp1
{
    interface Perevod
    {
        void perevod(Dep Object, decimal n);
    }
    interface VnesOrSnyl
    {
        void Vnes(decimal v);
        void Snyl(decimal v);
    }
    class Dep : Perevod, VnesOrSnyl
    {
        private decimal babki;
        public Dep()
        {
            babki = 0;
        }

        public void Vnes(decimal v)
        {
            babki += v;
        }
        public void Snyl(decimal v)
        {
            if (babki - v < 0)
            {
                Console.WriteLine("Снять не возможно");
            }
            else
            {
                babki -= v;
                Console.WriteLine($"вы сняли {v}, баланс {babki}");
            }
        }
        public void perevod(Dep Object, decimal n)
        {
            if (n > babki)
            {
                Console.WriteLine("перевод невозможен");
            }
            else
            {
                babki -= n;
                Object.babki += n;
                Console.WriteLine($"Вы перевели {n},Осталось {babki}");
            }
        }
    }
}
