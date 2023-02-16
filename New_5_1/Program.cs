using System.Reflection.Metadata;

namespace New_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string [] Dishes) User;
            Console.Write("Введите ваше имя: ");
            User.Name = Console.ReadLine();
            User.Dishes = new string[5];
            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine("Введите ваше любимое блюдо номер {0}", i + 1);
                User.Dishes[i] = Console.ReadLine();
            }
            Console.WriteLine($"Ваше имя {User.Name}");
            Console.WriteLine("Ваши любимые блюда: ");

            foreach (var Dish in User.Dishes)
            {
                Console.WriteLine(Dish);
            }
            Console.ReadKey();
        }
    }
}