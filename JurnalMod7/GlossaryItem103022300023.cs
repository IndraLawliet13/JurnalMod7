using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JurnalMod7
{

    public class GlossDef10302230023
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
    }

    public class GlossEntry103022300023
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef10302230023 GlossDef { get; set; }

    }

    public class GlossList103022300023
    {
        public GlossEntry103022300023 glossEntry { get; set; }
    }

    public class GlossDiv103022300023
    {
        public string title { get; set; }
        public GlossList103022300023 glossList { get; set; }
    }

    public class glossaryItem103022300023
    {
        public string title { get; set; }
        public GlossDiv103022300023 GlossDiv { get; set; }
    }

    public class glossary103022300023
    {
        public glossary103022300023 glossary2 { get; set; }
    }
    public class GlossaryItem103022300023
    {
        public void ReadJSON()
        {
            string jsonName = "jurnal7_3_103022300023.json";
            try
            {
                string jsonString = File.ReadAllText(jsonName);
                glossary103022300023 glossary = JsonSerializer.Deserialize<glossary103022300023>(jsonString);
            }
        }
    }
}
