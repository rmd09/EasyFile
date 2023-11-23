using Core;

namespace Interface
{
    internal static class SizeConverter
    {
        public static long GetBites(this long value, TypeSize typeSize)
        {
            switch (typeSize)
            {
                case TypeSize.Tb:
                    return value / SizeInterval.K_TO_TB;

                case TypeSize.Gb:
                    return value / SizeInterval.K_TO_GB;

                case TypeSize.Mb:
                    return value / SizeInterval.K_TO_KB;

                case TypeSize.Kb:
                    return value;

                default:
                    throw new ArgumentException();
            }
        }
    }
}
