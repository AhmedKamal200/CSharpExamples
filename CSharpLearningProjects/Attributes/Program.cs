namespace Attributes
{
     class Program
     {
        static void Main(string[] args) 
        {
            Update[] updates = {
             new Update (1, "security update"),
             new Update (2, "ui enhancements"),
             new Update (3, "No. of bug fixes update"),
             new Update (4, "security update"),
            };
            //UpdateProcessor.Download(updates);
            //UpdateProcessor.Install(updates);
            UpdateProcessor.DownloadAndInstall(updates);

        }

    }
}
