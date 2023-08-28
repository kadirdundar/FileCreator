using System;
using System.IO;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Dosya ismi girin:");
        string directorName = Console.ReadLine();// istenilen dosya ismi
        string pathOfDirectory = "/Users/kadirdundar/Desktop/projeKuveyt/project/" + directorName + "/";
        Console.WriteLine("Oluşturmak istediğiniz dosyalama türü; 1:Denetim, 2:Raporlar, 3:Tutanaklar")
        int choice = Console.ReadLine()

        //Dosyaların içereceği klasörler(bir tanesi seçilecektir)
        string[] directoryNames1 = {"AnaKaynaklar","Arşiv","CS_audit","Denetim","Education_Consultanty_Materials"};
        string[] directoryNames2 = {"Rapor1","Rapor2","Rapor3"};
        string[] directoryNames3 = {"Tutanak1","Tutanak2","Tutanak3"};

        string[] selectedDirectoryNames;
        switch (choice)
        {
            case 1:  selectedDirectoryNames = directoryNames1 break;
            case 2: selectedDirectoryNames = directoryNames2 break;
            case 3: selectedDirectoryNames = directoryNames3 break;
            
            default:
                break;
        }
        createFolder(selectedDirectoryNames,pathOfDirectory);
        provideAccsess();
    }
    static void provideAccsess(){//Klasörlere erişim izini verilmesi 
        try
        {
            // İzinleri temsil eden dizi
            string[][] permissions = new string[][]
            {
                new string[] { "kadir", "FullControl", "Allow" },
                new string[] { "admins", "Read", "Allow" },
                new string[] { "guests", "Read", "Deny" }
            };

            // Dosyanın izinlerini ayarlamak için FileSecurity sınıfından bir obje oluşturduk 
            FileSecurity fileSecurity = File.GetAccessControl(fileName);

            // İzinleri diziye ekledik
            foreach (string[] permission in permissions)
            {
                string userOrGroup = permission[0];
                FileSystemRights rights = (FileSystemRights)Enum.Parse(typeof(FileSystemRights), permission[1]);//Enum.parse ile type'ı değiştirdik
                AccessControlType controlType = (AccessControlType)Enum.Parse(typeof(AccessControlType), permission[2]);

                fileSecurity.AddAccessRule(new FileSystemAccessRule(userOrGroup, rights, controlType));
            }

            // Dosyanın izinlerini güncelledik
            File.SetAccessControl(directorName, fileSecurity);

            Console.WriteLine("Dosya izinleri başarıyla ayarlandı.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Dosya izinleri ayarlanırken bir hata oluştu: " + ex.Message);
        }

    }
    static void createFolder(string[] selelectedType,string pathOfDirectoryy){
           try
        {
            foreach (var directory in selelectedType)
            {
               Directory.CreateDirectory(pathOfDirectoryy + directory);//dosyaların oluşturulması
            }
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("dosya oluşturulurken bir hata alındı" + ex.Message);
        }
 

    }

    static string[] getInformationAuthority(){//yetkili kullanıcıların bilgisini çekmek için


        string klasorYolu = @"\\sunucu\paylasilanKlasor";
        string[] dosyaIsimleri = Directory.GetFiles(klasorYolu);

       return dosyaIsimleri;
    
    }
}
