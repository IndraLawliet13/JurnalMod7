using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace JurnalMod7
{
    public class Member103022300023
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
}
    public class Member2
    {
        public List<Member103022300023> members { get; set; }
    }

    public class TeamMembers103022300023
    {
        public void ReadJSON()
        {
            string jsonName = "jurnal7_2_103022300023.json";
            try
            {
                string JsonString = File.ReadAllText(jsonName);
                Member2 mahasiswa = JsonSerializer.Deserialize<Member2>(JsonString);
                Console.WriteLine("Team Member List: ");
                for (int i = 0; i < mahasiswa.members.Count; i++)
                {
                    Console.WriteLine(mahasiswa.members[i].nim + " " + mahasiswa.members[i].firstName + " " + mahasiswa.members[i].lastName + " " + mahasiswa.members[i].age + " " + mahasiswa.members[i].gender + ")");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
