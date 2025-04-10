using System;
using System.IO;
using System.Text.Json;

namespace JurnalMod7
{
    public class GlossaryItem103022300002_AndreasChristianFirga
    {
        
        public class Glossary
        {
            public string title { get; set; }
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }

        public class GlossDef
        {
            public string para { get; set; }
            public string[] GlossSeeAlso { get; set; }
        }

        public class Root
        {
            public Glossary glossary { get; set; }
        }

        // Method ReadJSON
        public void ReadJSON()
        {
            string path = "jurnal7_3_103022300002.json"; 
            if (!File.Exists(path))
            {
                Console.WriteLine("File JSON tidak ditemukan.");
                return;
            }

            string jsonData = File.ReadAllText(path);
            Root data = JsonSerializer.Deserialize<Root>(jsonData);

            var entry = data?.glossary?.GlossEntry;

            if (entry == null)
            {
                Console.WriteLine("Data GlossEntry tidak ditemukan.");
                return;
            }

           
            Console.WriteLine("=== GlossEntry ===");
            Console.WriteLine($"ID         : {entry.ID}");
            Console.WriteLine($"GlossTerm  : {entry.GlossTerm}");
            Console.WriteLine($"Acronym    : {entry.Acronym}");
            Console.WriteLine($"Abbrev     : {entry.Abbrev}");
            Console.WriteLine($"Definition : {entry.GlossDef?.para}");
            Console.WriteLine($"See Also   : {string.Join(", ", entry.GlossDef?.GlossSeeAlso ?? new string[0])}");
            Console.WriteLine($"GlossSee   : {entry.GlossSee}");
        }
    }
}
