using System;

namespace Core
{
    public struct Filter
    {
        public Filter(string mask, bool isDateTimeIntervalChange, bool isDateTimeIntervalCreate, bool isSizeBitsInterval, DateTimeInterval dateTimeIntervalChange = new DateTimeInterval(), DateTimeInterval dateTimeIntervalCreate = new DateTimeInterval(), SizeInterval sizeBitsInterval = new SizeInterval())
        {
            Mask = mask;
            HasDateTimeIntervalChange = isDateTimeIntervalChange;
            HasDateTimeIntervalCreate = isDateTimeIntervalCreate;
            HasSizeBitsInterval = isSizeBitsInterval;
            DateTimeIntervalChange = dateTimeIntervalChange;
            DateTimeIntervalCreate = dateTimeIntervalCreate;
            SizeBitesInterval = sizeBitsInterval;
        }
        public string Mask { get; private set; }
        public DateTimeInterval DateTimeIntervalChange { get; private set; }
        public bool HasDateTimeIntervalChange { get; private set; }
        public DateTimeInterval DateTimeIntervalCreate { get; private set; }
        public bool HasDateTimeIntervalCreate { get; private set; }
        public SizeInterval SizeBitesInterval { get; private set; }
        public bool HasSizeBitsInterval { get; private set; }
    }
}
