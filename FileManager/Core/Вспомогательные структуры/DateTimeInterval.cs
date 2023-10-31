using System;

namespace MainCore
{
    public struct DateTimeInterval
    {
        public DateTimeInterval(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }
        public DateTime Start {  get; private set; }
        public DateTime End { get; private set; }
    }
}
