using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_5
{
    public class GlossaryItem
    {
        public GlossaryClass glossary { get; set; }
    }

    public class GlossaryClass
    {
        public string title { get; set; }
        public GlossDivClass GlossDiv { get; set; }
    }

    public class GlossDivClass
    {
        public string title { get; set; }
        public GlossListClass GlossList { get; set; }
    }

    public class GlossListClass
    {
        public GlossEntryClass GlossEntry { get; set; }
    }

    public class GlossEntryClass
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDefClass GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossDefClass
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
    }

   

    class GlossaryItem_103022330096
    {
        public void ReadJson()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jurnal7_3_103022330096.json");

            string JsonString = File.ReadAllText(filePath);
            GlossaryItem gc = JsonSerializer.Deserialize<GlossaryItem>(JsonString);

            Console.WriteLine("GlossEntry: ");
            Console.WriteLine($"{gc.glossary.GlossDiv.GlossList.GlossEntry.ID}");
            Console.WriteLine($"{gc.glossary.GlossDiv.GlossList.GlossEntry.SortAs}");
            Console.WriteLine($"{gc.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm}");
            Console.WriteLine($"{gc.glossary.GlossDiv.GlossList.GlossEntry.Acronym}");
            Console.WriteLine($"{gc.glossary.GlossDiv.GlossList.GlossEntry.Abbrev}");
            Console.WriteLine("GlossDef: ");
            Console.WriteLine($"     {gc.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para}");
            Console.WriteLine("       GlossSee Also: ");
            for (int i=0; i< gc.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso.Count; i++)
            {
                Console.WriteLine($"     {gc.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[i]}");
            }
            Console.WriteLine($"{gc.glossary.GlossDiv.GlossList.GlossEntry.GlossSee}");
        }
    }
}
