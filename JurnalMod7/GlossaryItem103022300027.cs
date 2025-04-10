using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class Glossary
{
    public string title { get; set; }
    public GlossDiv GlossDiv { get; set; }
}

public class GlossDiv
{
    public string title { get; set; }
    public GlossList GlossList { get; set; }
}

public class GlossList
{
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
    public List<string> GlossSeeAlso { get; set; }
}

public class GlossaryItem103022300027
{
    public void ReadJSON()
    {
        string jsonFileName = "jurnal7_3_103022300027.json";
        try
        {
            string jsonString = File.ReadAllText(jsonFileName);
            var root = JsonSerializer.Deserialize<Dictionary<string, Glossary>>(jsonString);

            if (root != null && root.ContainsKey("glossary"))
            {
                var glossary = root["glossary"];
                Console.WriteLine($"Judul: {glossary.title}");
                Console.WriteLine($"GlossTerm: {glossary.GlossDiv.GlossList.GlossEntry.GlossTerm}");
                Console.WriteLine($"Penjelasan: {glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para}");
            }
            else
            {
                Console.WriteLine("Data glossary tidak ditemukan.");
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
