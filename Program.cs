using System;
using Naufal;

namespace program_naufal
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DataMahasiswa_103022330105();
            data.ReadJSON();

            Console.ReadKey();
        }
    }
}