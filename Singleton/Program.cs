using System;

namespace Singleton
{
    public class Manager
    {
        static Manager manager;

        protected Manager()
        {
            Console.WriteLine("Добро пожаловать, новый менеджер!");
        }
        // Возвращается единственный объект менеджера
        public static Manager Instance()
        {
            if (manager == null)
                manager = new Manager();
            else
                Console.WriteLine("Два менеджера не может существовать одновременно");
            return manager;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Manager u = new Manager();

            Manager manager1 = Manager.Instance();

            Manager manager2 = Manager.Instance();
            // Повторим создание. Instance вернет уже созданный объект.

            Console.Read();
        }
    }
}
