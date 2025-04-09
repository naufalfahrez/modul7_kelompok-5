using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;


namespace Rakan
{
    public class Alamat
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public Alamat address { get; set; }
        public string gender { get; set; }
    }
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class CourseList
    {
        public List<Course> courses { get; set; }
    }


    public class DataMahasiswa1030223330044
    {
        public void ReadJSON()
        {
            string filePath = "C:\\Users\\Rakan\\Documents\\Telkom\\SMT4\\KPL\\mod7\\modul7_kelompok-5\\jurnal7_1_103022330044.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);

                Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

                Console.WriteLine($"Nama {mhs.firstName} {mhs.lastName}\ngender: {mhs.gender}\numur: {mhs.age}\nalamat: {mhs.address.streetAddress}, {mhs.address.city}, {mhs.address.state}");

                CourseList data = JsonSerializer.Deserialize<CourseList>(jsonString);

                Console.WriteLine("Daftar mata kuliah yang diambil:");

                int nomor = 1;
                foreach (var mk in data.courses)
                {
                    Console.WriteLine($"MK {nomor} {mk.code} - {mk.name}");
                    nomor++;
                }
            }
            else
            {
                Console.WriteLine("File JSON tidak ditemukan.");
            }
            ;
        }
    }
}
