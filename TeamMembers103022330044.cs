using System.Text.Json;

namespace Rakan
{
    public class x
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public class membersList
    {
        public List<x> members { get; set; }
    }

    public class TeamMembers103022330044
    {
        public void ReadJSON()
        {
            string filePath = "C:\\Users\\Rakan\\Documents\\Telkom\\SMT4\\KPL\\mod7\\modul7_kelompok-5\\jurnal7_2_103022330044.json";

            try
            {
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);

                    membersList data = JsonSerializer.Deserialize<membersList>(jsonString);

                    Console.WriteLine("Team member list:");

                    foreach (var mhs in data.members)
                    {
                        Console.WriteLine($"{mhs.nim} {mhs.firstName} {mhs.lastName} ({mhs.age} {mhs.gender})");
                    }
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