using Rakan;
class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa1030223330044 mahasiswa = new DataMahasiswa1030223330044();
        TeamMembers103022330044 members = new TeamMembers103022330044();
        GlossaryItem103022330044 gloss = new GlossaryItem103022330044();
        mahasiswa.ReadJSON();

        Console.WriteLine();
        members.ReadJSON();
        
        Console.WriteLine();
        gloss.ReadJSON();
    }
}
