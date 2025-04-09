using System;

namespace modul7_kelompok-5
{
    internal class GlossaryItem103022330080
    {
        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public string Definition { get; set; }
            public string[] SeeAlso { get; set; }
        }
    
        public class Glossary
        {
            public GlossEntry GlossEntry { get; set; }
        }   

        public class Root
        {
            public Glossary Glossary { get; set; }
        }

        public void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_3_103022330080.json");
            Root data = JsonSerializer.Deserialize<Root>(json);
            var g = data.Glossary.GlossEntry;
            Console.WriteLine($"Term: {g.GlossTerm}, Definition: {g.Definition}");
        }
    }
}
