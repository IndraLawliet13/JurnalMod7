using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System;

namespace JurnalMod7
{

    public class address103022300023
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class course103022300023
    {
        public string code { get; set; }
        public string name { get; set; }
    } 

    public class DataMahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public address103022300023 address { get; set; }
        public List<course103022300023> courses { get; set; }
    }
    public class DataMahasiswa103022300023
    {
        public void ReadJSON()
        {
            string jsonName = "jurnal7_1_103022300023.json";
            try
            {
                string jsonString = File.ReadAllText(jsonName);
                DataMahasiswa dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);
                if (dataMahasiswa != null)
                {
                    Console.WriteLine($"Nama : {dataMahasiswa.firstName} {dataMahasiswa.lastName}\nUmur: {dataMahasiswa.age}\nAlamat: {dataMahasiswa.address.streetAddress} {dataMahasiswa.address.city} {dataMahasiswa.address.state}Mata kuliah yang diambil: \n");
                    for (int i = 0; i < dataMahasiswa.courses.Count; i++)
                    {
                        Console.WriteLine("Course " + (i + 1) + ": " + dataMahasiswa.courses[i].name);
                    }
                }
                else
                {
                    Console.WriteLine("Gagal melakukan deserialisasi data JSON");
                }
            } 
            catch (FileNotFoundException)
            {
                
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error saat parsing JSON '{ex.Message}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi error: {ex.Message}");
            }
        }
    }
}
