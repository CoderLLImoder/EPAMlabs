using System;



namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FileWatcher Watcher = new FileWatcher();
            

        int i = 0;
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Выберите режим:");
                Console.WriteLine("1) Включить наблюдение.");
                Console.WriteLine("2) Выполнить откат.");
                Console.WriteLine("0) Выход из программы.");
                Console.WriteLine("-------------------------");
                char c = Console.ReadKey().KeyChar;
                switch (c)
                {
                    case '1':
                        Console.WriteLine(">>>Включен режим наблюдения.");
                        Watcher.Watching();
                        break;
                    case '2':
                        Console.WriteLine(">>>Включен режим отката изменений.");
                        
                        Watcher.Return();
                        break;
                    case '0':
                        i++;
                        break;
                    default:
                        Console.WriteLine(">>>Ошибка: неверное действие");
                        break;
                }
            } while (i == 0);
        }
    }
}