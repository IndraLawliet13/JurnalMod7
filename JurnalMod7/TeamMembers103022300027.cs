using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Member
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }
}

public class MemberData
{
    public List<Member> members { get; set; }
}


public class TeamMembers103022300027
{
    public void ReadJSON()
    {
        string jsonFileName = "jurnal7_2_1030223000027.json";
        try
        {
            string jsonString = File.ReadAllText(jsonFileName);
            MemberData data = JsonSerializer.Deserialize<MemberData>(jsonString);

            if (data != null && data.members != null)
            {
                Console.WriteLine("Daftar anggota:");
                for (int i = 0; i < data.members.Count; i++)
                {
                    Member m = data.members[i];
                    Console.WriteLine($"Anggota {i + 1}: {m.firstName.Trim()} {m.lastName.Trim()}, Gender: {m.gender}, Age: {m.age}, NIM: {m.nim}");
                }
            }
            else
            {
                Console.WriteLine("Data JSON kosong atau gagal dibaca.");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File JSON '{jsonFileName}' tidak ditemukan.");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error saat parsing JSON: {ex.Message}. Pastikan format JSON valid.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi error: {ex.Message}");
        }
    }
}
