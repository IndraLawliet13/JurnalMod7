﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public class Member103022300017
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }

}

public class Members103022300017
{
    public List<Member103022300017> members { get; set; }
}

public class TeamMembers10302230017
{
	public void ReadJSON()
	{
        string jsonName = "jurnal7_2_103022300017.json";
        try
        {
            string jsonString = File.ReadAllText(jsonName);
            Members103022300017 mahasiswa = JsonSerializer.Deserialize<Members103022300017>(jsonString);
            Console.WriteLine("Team member list: ");
            for (int i = 0; i < mahasiswa.members.Count; i++)
            {
                Console.WriteLine(mahasiswa.members[i].nim + " " + mahasiswa.members[i].firstName + " " + mahasiswa.members[i].lastName + " ("+ mahasiswa.members[i].age + " "+ mahasiswa.members[i].gender + ")");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
