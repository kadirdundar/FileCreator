using System.IO;
using System;
namespace Project
{
    class Program
    {
        static void Main(string[] args)
    {
        Console.Write("Dosya ismi girin:");
        string directorName = Console.ReadLine();
        string pathOfDirectory = "/Users/kadirdundar/Desktop/projeKuveyt/project/" + directorName + "/";

        string[] directoryNames = {"AnaKaynaklar","Arşiv","CS_audit","Denetim","Education_Consultanty_Materials"};

        string[] allowedUsers = {"kadir", "Aüstad","Büstad"};

        string username = Environment.UserName;

        if (Array.Exists(allowedUsers, element => element == username)){

        try
        {
            foreach (var directory in directoryNames)
            {
               Directory.CreateDirectory(pathOfDirectory + directory);
            }
        }
        catch (System.Exception ex)
        {
            
            Console.WriteLine("dosya oluşturulurken bir hata alındı" + ex.Message);
        }
    }
    }
    }
}