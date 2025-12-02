using ConsoleApp1;
using ConsoleApp36;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("Выся");
            robot.work();
            robot.work();
            robot.charge();
            robot.work();
            robot.charge();


            Console.WriteLine();


            Lamp lamp1 = new Lamp();
            lamp1.setLevel(10);
            lamp1.onOrOff();

            Fan fan = new Fan();
            fan.onOrOff();
            fan.onOrOff();


            Console.WriteLine();


            List<setPrice> products = new List <setPrice>
            {
                new Phone(29990.00m, 12),
                new Laptop(79990.00m),
                new Phone(45990.00m, 24),
                new Laptop(129990.00m)
            };

            decimal totalCost = 0;

            foreach (var product in products)
            {
                decimal price = product.Price();
                totalCost += price;

                if (product is garantyTerm gar)
                {
                    int warrantyMonths = gar.Term();
                }
                else
                {
                    Console.WriteLine("Гарантия: не предусмотрена");
                }

                Console.WriteLine();
            }
            Console.WriteLine("------------------");
            Console.WriteLine($"Общая стоимость всех товаров: {totalCost:C}");

            Console.WriteLine();


            Warrior warrior = new Warrior();
            Mage mage = new Mage();

            warrior.Attack();

            mage.Attack();
            mage.Heal();


            Console.WriteLine();


            Dep dep = new Dep();
            Dep dep1 = new Dep();
            dep.Vnes(500);
            dep.Snyl(300);
            dep.perevod(dep1, 200);
        }
    }
}
