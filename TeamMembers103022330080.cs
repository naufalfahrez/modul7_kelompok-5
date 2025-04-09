using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok-5
{
	internal class TeamMembers103022330080
	{
		public static void ReadJSON()
		{
            string JSONPath = "../../../jurnal7_2_103022330080.json";
            string JSONString = File.ReadAllText(JSONPath);

            var dataTeam = JsonSerializer.Deserialize<DataTeam>(JSONString);

            Console.WriteLine("Team member list:");
            for (int i = 0; i < dataTeam.members.Length; i++)
            {
                Console.WriteLine($"{dataTeam.members[i].nim} {dataTeam.members[i].firstName} {dataTeam.members[i].lastName} ({dataTeam.members[i].age} {dataTeam.members[i].gender})");
            }
        }
	}
    
    class DataTeam
    {
        public Member[] members { get; set; }
    }
    
    class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
}
