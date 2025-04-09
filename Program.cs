// See https://aka.ms/new-console-template for more information
using modul7_kelompok_5;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_103022330096 mhs = new DataMahasiswa_103022330096();
        mhs.ReadJson();

        TeamMembers_103022330096 members = new TeamMembers_103022330096();
        members.ReadJson();

        GlossaryItem_103022330096 gc = new GlossaryItem_103022330096();
        gc.ReadJson();
    }
}