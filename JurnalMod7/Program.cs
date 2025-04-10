using JurnalMod7;

public class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswaAndreasChristianFirga dataMahasiswa = new DataMahasiswaAndreasChristianFirga();
        dataMahasiswa.ReadJSON();
        TeamMembers103022300002 teamMembers = new TeamMembers103022300002();
        teamMembers.ReadJSON();
        GlossaryItem103022300002 glossaryItem = new GlossaryItem103022300002();
        glossaryItem.ReadJSON();
    }
}