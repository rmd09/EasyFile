using System;

namespace Core
{
    /// <summary>
    /// Структура для сравнения размера файла (>,<,==,<=,>=)
    /// </summary>
    public struct SizeInterval
    {
        public const int K_TO_GB = 1024 * 1024 * 1024;
        public const int K_TO_MB = 1024 * 1024;
        public const int K_TO_KB = 1024;

        public SizeInterval(long start, long end, TypeSize typeSize = TypeSize.b)
        {
            Start = start;
            End = end;
            TypeSize = typeSize;
        }
        public long Start { get; set; }
        public long End { get; set; }
        public TypeSize TypeSize { get; set; }

        /// <summary>
        /// Возвращает промежуток в байтах
        /// </summary>
        /// <returns>Item1 - start, Item2 - end</returns>
        /// <exception cref="ArgumentException"></exception>
        public (long, long) GetBites()
        {
            switch (TypeSize)
            {
                case TypeSize.Gb:
                    return (Start * K_TO_GB, End * K_TO_GB);
                case TypeSize.Mb:
                    return (Start * K_TO_MB, End * K_TO_MB);
                case TypeSize.Kb:
                    return (Start * K_TO_KB, End * K_TO_KB);
                case TypeSize.b:
                    return (Start, End);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
public enum TypeSize
{
    b,
    Kb,
    Mb,
    Gb
}