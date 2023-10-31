using System;

namespace MainCore
{
    public struct FileProperties
    {
        public FileProperties(string path, string name, DateTime timeOfLastChange, DateTime timeCreate, long sizeBits)
        {
            Path = path;
            Name = name;
            TimeOfLastChange = timeOfLastChange;
            TimeCreate = timeCreate;
            SizeBites = sizeBits;
        }
        public string Path { get; private set; }
        public string Name { get; private set; }
        public DateTime TimeOfLastChange { get; private set; }
        public DateTime TimeCreate { get; private set; }
        public long SizeBites { get; private set; }
    }
}