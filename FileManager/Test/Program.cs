using System;
using Core;
using CoreForWindows;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к папке: ");
            string pathToMainFolder = Console.ReadLine();
            Console.Write("Введите конечную папку: ");
            string pathToFinalFolder = Console.ReadLine();
            Console.Write("Введите маску: ");
            Filter filter = new Filter(Console.ReadLine(), false, false, false);
            FileSorter fileSorter = new FileSorter(pathToMainFolder, pathToFinalFolder, filter);
            fileSorter.Sort();
            Console.WriteLine("Сортировка завершена!");
        }
    }
}