// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_103022300048 mahasiswa = new DataMahasiswa_103022300048();
        mahasiswa.ReadJSON();
        Console.WriteLine();
        TeamMembers_103022300048 team = new TeamMembers_103022300048();
        team.ReadJSON();

    }
}