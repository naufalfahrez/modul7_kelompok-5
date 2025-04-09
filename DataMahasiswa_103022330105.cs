using System.Text.Json;

namespace Naufal
{
    
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
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

    public class DataMahasiswa_103022330105
    {
        public void ReadJSON()
        {
            string filePath = "jurnal7_1_103022330105.json";
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);

                    Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);


                    Console.WriteLine($"Nama {mhs.firstName} {mhs.lastName} memiliki gender {mhs.gender} berumur {mhs.age} beralamat {mhs.address.streetAddress},{mhs.address.city},{mhs.address.state}");
                    Console.WriteLine($"Memiliki Courses: ");
                    for (int i = 0; i < mhs.courses.Count; i++)
                    {
                        Console.WriteLine($"{mhs.courses[i].code} - {mhs.courses[i].name}");
                    }
                }
                else
                {
                    Console.WriteLine("File JSON tidak ditemukan.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca file JSON:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}