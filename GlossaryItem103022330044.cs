using System.Text.Json;

namespace Rakan
{
    public class GlossDef
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
    }

    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }
    public class GlossDiv
    {
        public GlossList GlossList { get; set; }
        public string title { get; set; }
    }
    public class Glossary
    {
        public GlossDiv GlossDiv { get; set; }
        public string title { get; set; }
    }
    public class GlossaryItem
    {
        public Glossary glossary { get; set; }
    }


    public class GlossaryItem103022330044
    {
        public void ReadJSON()
        {
            string filePath = "C:\\Users\\Rakan\\Documents\\Telkom\\SMT4\\KPL\\mod7\\modul7_kelompok-5\\jurnal7_3_103022330044.json";

            try
            {
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);

                    GlossaryItem data = JsonSerializer.Deserialize<GlossaryItem>(jsonString);
                    if (data != null)
                    {
                        var g = data.glossary.GlossDiv.GlossList.GlossEntry;

                        Console.WriteLine($"GLoss Entry: {g.ID} {g.SortAs} {g.GlossTerm} {g.Acronym} {g.Abbrev} {g.GlossDef.para} {g.GlossDef.GlossSeeAlso} {g.GlossSee}");//

                    }
                    else { Console.WriteLine("Data NULL"); }
                }
                else
                {
                    Console.WriteLine("File JSON tidak ditemukan di: " + Path.GetFullPath(filePath));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca file JSON:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}