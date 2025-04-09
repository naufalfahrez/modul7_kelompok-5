using System.Text.Json;

namespace Tim
{ 
    public class Members
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public class TimList
    {
        public List<Members> members { get; set; }
    }

    public class TeamMembers_103022330105
    {
        public void ReadJSON()
        {
            string filePath = "jurnal7_2_103022330105.json";

            try
            {
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);

                    TimList T = JsonSerializer.Deserialize<TimList>(jsonString);

                    Console.WriteLine("Team member list:");
                    for (int i = 0; i < T.members.Count; i++)
                    {
                        Console.WriteLine($"{T.members[i].nim} {T.members[i].firstName} {T.members[i].lastName} {T.members[i].gender} {T.members[i].age}");
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