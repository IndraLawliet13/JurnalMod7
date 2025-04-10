using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class address103022300017
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}

public class course103022300017
{
    public string code { get; set; }
    public string name { get; set; }
}

public class Mahasiswa103022300017
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public address103022300017 address { get; set; }
    public List<course103022300017> courses { get; set; }

}

public class DataMahasiswa103022300017
{
	public void ReadJSON()
	{
		string jsonName = "jurnal7_1_103022300017.json";
        try
        {
            string jsonString = File.ReadAllText(jsonName);
            Mahasiswa103022300017 mahasiswa = JsonSerializer.Deserialize<Mahasiswa103022300017>(jsonString);
            Console.WriteLine("First Name: " + mahasiswa.firstName + "\nMata Kuliah Yang Diambil: \n");
            for (int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine("Course " + (i + 1) + ": " + mahasiswa.courses[i].name);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
