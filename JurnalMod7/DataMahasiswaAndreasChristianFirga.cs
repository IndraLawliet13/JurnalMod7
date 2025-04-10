using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JurnalMod7
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

    public class DataMahasiswaAndreasChristianFirga
    {
        public void ReadJSON()
        {
            string filePath = "jurnal7_1_103022300002.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

                Console.WriteLine("=== Data Mahasiswa ===");
                Console.WriteLine($"Nama       : {mhs.firstName} {mhs.lastName}");
                Console.WriteLine($"Gender     : {mhs.gender}");
                Console.WriteLine($"Usia       : {mhs.age}");
                Console.WriteLine("Alamat     :");
                Console.WriteLine($"  Jalan    : {mhs.address.streetAddress}");
                Console.WriteLine($"  Kota     : {mhs.address.city}");
                Console.WriteLine($"  Provinsi : {mhs.address.state}");

                Console.WriteLine("\n=== Mata Kuliah ===");
                foreach (var course in mhs.courses)
                {
                    Console.WriteLine($"- {course.code}: {course.name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal membaca file JSON:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
