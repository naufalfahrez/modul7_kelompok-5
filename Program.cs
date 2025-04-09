using System;
using Naufal;
using Tim;

namespace program_naufal
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DataMahasiswa_103022330105();
            data.ReadJSON();

            var tim = new TeamMembers_103022330105();
            tim.ReadJSON();

            Console.ReadKey();
        }
    }
}