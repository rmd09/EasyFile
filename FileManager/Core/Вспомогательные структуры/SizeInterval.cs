namespace MainCore
{
    public enum TypeСomparing
    {
        Greater,
        Less,
        Equal,
        CreaterOrEqual,
        LessOrEqual
    }
    /// <summary>
    /// Структура для сравнения размера файла (>,<,==,<=,>=)
    /// </summary>
    public struct SizeInterval
    {
        public SizeInterval(long sizeBits, TypeСomparing typeСomparing)
        {
            SizeBites = sizeBits;
            TypeСomparing = typeСomparing;
        }
        public long SizeBites { get; private set; }
        public TypeСomparing TypeСomparing { get; private set; }
    }
}
