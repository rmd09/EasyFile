using System;

namespace Core
{
    [Serializable]
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
        public string Mask { get; set; }
        public DateTimeInterval DateTimeIntervalChange { get; set; }
        public bool HasDateTimeIntervalChange { get; set; }
        public DateTimeInterval DateTimeIntervalCreate { get; set; }
        public bool HasDateTimeIntervalCreate { get; set; }
        public SizeInterval SizeBitesInterval { get; set; }
        public bool HasSizeBitsInterval { get; set; }
    }
}
