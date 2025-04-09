using System.Text.Json;

namespace Item
{
    public class Glosarry
    {
        public string title { get; set; }
        public string GlossDiv { get; set; }
    }

    public class glossDiv
    {
        public string title { get; set; }
        public string GlossList { get; set; }
    }
}