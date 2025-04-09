using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_5
{
    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public class Members
    {
        public List<Member> members { get; set; }
    }
    class TeamMembers_103022330096
    {
        public void ReadJson()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jurnal7_2_103022330096.json");

            string JsonString = File.ReadAllText(filePath);
            Members data = JsonSerializer.Deserialize<Members>(JsonString);

            Console.WriteLine("Team member list:");
            for (int i=0; i<data.members.Count; i++)
            {
                Console.WriteLine($"{data.members[i].nim} {data.members[i].firstName} {data.members[i].lastName} ({data.members[i].age} {data.members[i].gender})");
            }
        }
    }
}
