public class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswa103022300017 dataMahasiswa = new DataMahasiswa103022300017();
        dataMahasiswa.ReadJSON();
        TeamMembers10302230017 teamMembers = new TeamMembers10302230017();
        teamMembers.ReadJSON();
    }
}