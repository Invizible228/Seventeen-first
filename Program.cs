using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace okk
{
    class Program
    {
        static void Main(string[] args)
        {
            //дом
            if (File.Exists("Vkusno.txt"))
            {
                int j = 0;
                Console.Write("Ваш текст:");
                string Data = File.ReadAllText("Vkusno.txt");
                Console.WriteLine(Data);
                Console.Write("Введите слово:");
                try
                {
                    string word = Console.ReadLine();
                    Data.Split(' ');
                    var needly = Data.ToLower().GroupBy(n => n);
                    foreach (var item in needly)
                    {
                        Console.WriteLine("Слово {0} встречается {1} раз", word, item.Count());
                        break;
                    }
                }
                catch { Console.WriteLine("Ошибка!"); }
                Console.ReadKey();
            }
        }
    }
}
