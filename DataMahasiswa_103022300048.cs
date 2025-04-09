using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class Alamat
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

public class MahasiswaData
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Alamat address { get; set; }
    public List<Course> courses { get; set; }
}

public class DataMahasiswa_103022300048
{
    public void ReadJSON()
    {
        string filePath = "C:\\Users\\Faiz\\OneDrive - Telkom University\\Documents\\KS4\\KPL\\PRAKTIKUM\\modul7_kelompok-5\\jurnal7_1_103022300048.json";

        try
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                MahasiswaData data = JsonSerializer.Deserialize<MahasiswaData>(jsonString);

                Console.WriteLine($"Nama Mahasiswa: {data.firstName} {data.lastName}");
                Console.WriteLine($"Kelamin: {data.gender}");
                Console.WriteLine($"Umur: {data.age}");
                Console.WriteLine($"Alamat: {data.address.streetAddress}, {data.address.city}, {data.address.state}");

                Console.WriteLine("\nDaftar mata kuliah yang diambil:");
                int nomor = 1;
                foreach (var mk in data.courses)
                {
                    Console.WriteLine($"MK {nomor}: {mk.code} - {mk.name}");
                    nomor++;
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
