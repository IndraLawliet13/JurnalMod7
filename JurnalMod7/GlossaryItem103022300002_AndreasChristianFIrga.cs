using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GlossDef103022300002
{
    public string para { get; set; }
    public List<string> GlossSeeAlso { get; set; }
}

public class GlossEntry103022300002
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public GlossDef103022300002 GlossDef { get; set; }
    public string GlossSee { get; set; }
}

public class GlossList103022300002
{
    public GlossEntry103022300002 GlossEntry { get; set; }
}

public class GlossDiv103022300002
{
    public string title { get; set; }
    public GlossList103022300002 GlossList { get; set; }
}

public class GlossaryItemData103022300002
{
    public string title { get; set; }
    public GlossDiv103022300002 GlossDiv { get; set; }
}

public class GlossaryRoot103022300002
{
    public GlossaryItemData103022300002 glossary { get; set; }
}

public class GlossaryItem103022300002
{
    public void ReadJSON()
    {
        string jsonName = "jurnal7_3_103022300002.json";
        try
        {
            string jsonString = File.ReadAllText(jsonName);
            GlossaryRoot103022300002 glossary = JsonSerializer.Deserialize<GlossaryRoot103022300002>(jsonString);

            Console.WriteLine("Glossary title: " + glossary.glossary.title);
            Console.WriteLine("Glossary ID: " + glossary.glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine("Glossary SortAs: " + glossary.glossary.GlossDiv.GlossList.GlossEntry.SortAs);
            Console.WriteLine("Glossary GlossTerm: " + glossary.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
            Console.WriteLine("Glossary Acronym: " + glossary.glossary.GlossDiv.GlossList.GlossEntry.Acronym);
            Console.WriteLine("Glossary Abbrev: " + glossary.glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            Console.WriteLine("Glossary GlossDef para: " + glossary.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
            Console.WriteLine("Glossary GlossDef GlossSeeAlso:");
            foreach (var item in glossary.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso)
            {
                Console.WriteLine(" - " + item);
            }
            Console.WriteLine("Glossary GlossSee: " + glossary.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
