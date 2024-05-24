using System;

namespace Core
{
    internal static class InfoSorter
    {
        /// <summary>
        /// Определяет, подходит ли строка под маску
        /// </summary>
        /// <param name="str">Строка</param>
        /// <param name="mask">Маска</param>
        /// <returns>Подходит/Не подходит</returns>
        public static bool SortWithMask(this string name, string mask)
        {
            if (!mask.Contains('*') && !mask.Contains('?'))
            {
                return name == mask;
            }

            for (int i = 0, j = 0; ;)
            {
                switch (mask[i])
                {
                    case '*':
                        if (i == mask.Length - 1)
                        {
                            return true; //Если * последняя - значит нам всё равно, что там дальше
                        }
                        if (name[j] == mask[i + 1])
                        {
                            i += 2;
                            j++;
                            break;
                        }

                        while (j < name.Length)
                        {
                            if (name[j] == mask[i + 1])
                            {
                                if (i == mask.Length - 2)
                                {
                                    return true; //* стоит на предпоследнем месте, а последняя буква подходит нам
                                }
                                if (j == name.Length - 1)
                                {
                                    if (mask[mask.Length - 1] == '*')
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }
                                j++;
                                i += 2;
                                goto EndOfCase;
                            }
                            j++;
                        }
                        if (i == mask.Length - 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        
                        EndOfCase:
                        break;
                    case '?':
                        if (j == name.Length - 1)
                        {
                            if (i == mask.Length - 1 || (mask[i + 1] == '*' && i == mask.Length - 2))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }

                        j++;
                        i++;

                        break;

                    default:
                        if (name[j] != mask[i])
                        {
                            return false;
                        }
                        else
                        {
                            if (i == mask.Length - 1)
                            {
                                if (j == name.Length - 1)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else if (j == name.Length - 1)
                            {
                                if (mask[i + 1] == '*' && i == mask.Length - 2)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }

                        i++;
                        j++;
                        break;
                }
            }
        }

        public static bool SortDateByInterval(this DateTime dateTime, DateTime start, DateTime finish)
        {
            if (dateTime >= start && dateTime <= finish)
                return true;
            else
                return false;
        }
        public static bool SortDateByInterval(this DateTime dateTime, DateTimeInterval dateTimeInterval)
        {
            return dateTime.SortDateByInterval(dateTimeInterval.Start, dateTimeInterval.End);
        }

        public static bool SortBySize(this long sizeBits, SizeInterval sizeInterval)
        {
            var values = sizeInterval.GetBites();
            long start = values.Item1;
            long end = values.Item2;

            if (sizeBits >= start && sizeBits <= end)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}