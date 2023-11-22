namespace Core
{
    /// <summary>
    /// Структура для сравнения размера файла (>,<,==,<=,>=)
    /// </summary>
    public struct SizeInterval
    {
        public SizeInterval(long start, long end)
        {
            Start = start;
            End = end;
        }
        public long Start { get; private set; }
        public long End { get; private set; }
    }
}
