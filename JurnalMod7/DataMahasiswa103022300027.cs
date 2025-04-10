using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

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

public class MahasiswaData
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Course> courses { get; set; }
}

public class DataMahasiswa103022300027
{
    public void ReadJSON()
    {
        string jsonFileName = "jurnal7_1_103022300027.json";
        try
        {
            string jsonString = File.ReadAllText(jsonFileName);
            MahasiswaData dataMahasiswa = JsonSerializer.Deserialize<MahasiswaData>(jsonString);

            if (dataMahasiswa != null)
            {
                Console.WriteLine($"Nama: {dataMahasiswa.firstName.Trim()} {dataMahasiswa.lastName}");
                Console.WriteLine($"Gender: {dataMahasiswa.gender}");
                Console.WriteLine($"Usia: {dataMahasiswa.age} tahun");
                Console.WriteLine($"Alamat: {dataMahasiswa.address.streetAddress}, {dataMahasiswa.address.city}, {dataMahasiswa.address.state}");
                Console.WriteLine("Daftar Mata Kuliah:");
                foreach (var course in dataMahasiswa.courses)
                {
                    Console.WriteLine($"- {course.code}: {course.name}");
                }
            }
            else
            {
                Console.WriteLine("Gagal melakukan deserialisasi data JSON.");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File JSON '{jsonFileName}' tidak ditemukan.");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error saat parsing JSON: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi error: {ex.Message}");
        }
    }
}
