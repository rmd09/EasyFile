using Core;

namespace Interface
{
    [Serializable]
    public class Shablon
    {
        public Shablon()
        {
            
        }
        public Shablon(string name, Filter filter)
        {
            Name = name;
            Filter = filter;
        }
        public Shablon(Shablon shablon)
        {
            Name = shablon.Name;
            Filter = shablon.Filter;
        }
        public string Name { get; set; }
        public Filter Filter { get; set; }
    }
}
