using Core;

namespace Interface
{
    [Serializable]
    public class Shablon
    {
        public Shablon(string name, Filter filter)
        {
            Name = name;
            Filter = filter;
        }
        public string Name { get; set; }
        public Filter Filter { get; set; }
    }
}
