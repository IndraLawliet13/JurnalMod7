
﻿public class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswa103022300017 dataMahasiswa = new DataMahasiswa103022300017();
        dataMahasiswa.ReadJSON();
        TeamMembers10302230017 teamMembers = new TeamMembers10302230017();
        teamMembers.ReadJSON();
        GlossaryItem103022300017 glossaryItem = new GlossaryItem103022300017();
        glossaryItem.ReadJSON();
        DataMahasiswa103022300027 dataHandler = new DataMahasiswa103022300027();
        dataHandler.ReadJSON();
        TeamMembers103022300027 teamsHandler = new TeamMembers103022300027();
        teamsHandler.ReadJSON();
        GlossaryItem103022300027 glossaryHandler = new GlossaryItem103022300027();
        glossaryHandler.ReadJSON();
    }
}
