namespace Interface
{
    public class JsonStruct
    {
        public JsonStruct(List<Shablon> shablons)
        {
            Shablons = shablons;
        }

        public List<Shablon> Shablons { get; set; }
    }
}