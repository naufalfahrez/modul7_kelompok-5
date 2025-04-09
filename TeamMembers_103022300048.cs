using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class Member
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }
}

public class membersList
{
    public List<Member> members { get; set; }
}

public class TeamMembers_103022300048
{
	public void ReadJSON()
	{
        string filePath = "C:\\Users\\Faiz\\OneDrive - Telkom University\\Documents\\KS4\\KPL\\PRAKTIKUM\\modul7_kelompok-5\\jurnal7_2_103022300048.json";
        try
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);

                membersList data = JsonSerializer.Deserialize<membersList>(jsonString);

                Console.WriteLine("List kelompok 5: ");

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
            Console.WriteLine("Terjadi kesalahan saat membaca file JSON!");
            Console.WriteLine(ex.Message);
        }
    }
}

