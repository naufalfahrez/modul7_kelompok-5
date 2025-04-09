using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_5
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state{ get; set; }
    }

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public class Mahasiswa 
    { 
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }
    }
    class DataMahasiswa_103022330096
    {
        public void ReadJson()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jurnal7_1_103022330096.json");

            string JsonString = File.ReadAllText(filePath);
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(JsonString);

            Console.WriteLine($"Name: {mhs.firstName} {mhs.lastName}");
            Console.WriteLine($"Gender: {mhs.gender}");
            Console.WriteLine($"Age: {mhs.age}");
            Console.WriteLine($"Address: {mhs.address.streetAddress}, {mhs.address.city}, {mhs.address.state}");
            Console.WriteLine($"Courses: ");
            for (int i=0; i<mhs.courses.Count; i++)
            {
                Console.WriteLine($"{mhs.courses[i].code} - {mhs.courses[i].name}");
            }
        }
    }
}
