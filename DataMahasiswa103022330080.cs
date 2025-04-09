using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok-5
{
	internal class DataMahasiswa103022330080
	{
		public static void ReadJSON()
		{
			string JSONPath = "../../../jurnal7_1_103022330080.json";
			string JSONString = File.ReadAllText(JSONPath);

			var dataMahasiswa = JsonSerializer.Deserialize<Data>(JSONString);

            Console.WriteLine($"Name   : {dataMahasiswa.firstName} {dataMahasiswa.lastName}");
            Console.WriteLine($"Gender : {dataMahasiswa.gender}");
            Console.WriteLine($"Age    : {dataMahasiswa.age}");
            Console.WriteLine($"Address: {dataMahasiswa.address.streetAddress}, {dataMahasiswa.address.city}, {dataMahasiswa.address.state}");
            Console.WriteLine($"Courses: {dataMahasiswa.courses[0].code} - {dataMahasiswa.courses[0].name}");
            Console.WriteLine($"         {dataMahasiswa.courses[1].code} - {dataMahasiswa.courses[1].name}");
        }
	}

	class data
	{
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public Course[] courses { get; set; }
    }

    class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}
