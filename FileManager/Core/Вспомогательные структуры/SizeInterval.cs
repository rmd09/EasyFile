using System;

namespace Core
{
    /// <summary>
    /// Структура для сравнения размера файла (>,<,==,<=,>=)
    /// </summary>
    public struct SizeInterval
    {

        public const int K_TO_TB = 1024 * 1024 * 1024;
        public const int K_TO_GB = 1024 * 1024;
        public const int K_TO_KB = 1024;

        public SizeInterval(long start, long end)
        {
            Start = start;
            End = end;
        }
        public long Start { get; set; }
        public long End { get; set; }
    }
}
public enum TypeSize
{
    Tb,
    Gb,
    Mb,
    Kb
}