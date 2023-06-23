using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBoxHomework1
{
    internal class Program
    {
        /// <summary>
        /// Метод , который выполняется в первую очередь при запуске приложения
        /// </summary>
        /// <param name="args">Параметры запуска</param>
        static void Main(string[] args)
        {
            Write("Привет "); // Выводит текст в консоль
            Write("Мир "); // Выводит текст в консоль
            WriteLine("!!!!!!!!!!!!!!!!");  // Выводит текст в консоль и переводит на другую строку
            ReadKey(); // Ожидает , пока пользователь нажмёт любую клавишу
        }
    }
}
