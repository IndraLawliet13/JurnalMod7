using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JurnalMod7
{
    public class GlossaryItem103022300017
    {
        public class Member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }

        public class Root
        {
            public List<Member> members { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = "jurnal7_2_103022300002.json";
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File tidak ditemukan: {filePath}");
                return;
            }

            string jsonString = File.ReadAllText(filePath);
            Root data = JsonSerializer.Deserialize<Root>(jsonString);

            Console.WriteLine("GlossEntry:");
            foreach (var member in data.members)
            {
                Console.WriteLine($"- {member.firstName} {member.lastName} ({member.nim})");
            }
        }
    }
}
