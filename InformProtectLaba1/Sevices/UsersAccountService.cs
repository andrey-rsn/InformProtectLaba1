using InformProtectLaba1.Data;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

namespace InformProtectLaba1.Sevices;

public static class UsersAccountService
{
    private static readonly string _path;

    public static bool isEncrypted=false;
    public static List<User> Users { get; set; }

    static UsersAccountService()
    {
        _path= Path.GetDirectoryName(Path.GetDirectoryName(
                Path.GetDirectoryName(
                    Path.GetDirectoryName(
                        AppDomain.CurrentDomain.SetupInformation.ApplicationBase))));
        //InitData();
    }

    public static void SaveData()
    {
        if (isEncrypted)
        {
            var filePath = Path.Combine(_path, "Data", "accounts.json");
            string json = Crypting.Encrypt(JsonConvert.SerializeObject(Users));
            File.WriteAllText(filePath, json);
        }
        
    }
    public static void ReadDataFromFile(string key)
    {
        var filePath= Path.Combine(_path, "Data", "accounts.json");
        if (!File.Exists(filePath))
        {
            CreateAndFullFile(filePath);
        }
        using (StreamReader r = new StreamReader(filePath))
        {
            string json = r.ReadToEnd();
            Users = JsonConvert.DeserializeObject<List<User>>(Crypting.Decrypt(json,key));
        }
    }

    private static void CreateAndFullFile(string path)
    {
        var data = new List<User>()
        {
            new User()
            {
                Id=1,
                isBlocked=false,
                isPasswordConstraint=true,
                Login="admin",
                Password="",
                Role="admin"
            }
        };
        string json = Crypting.Encrypt(JsonConvert.SerializeObject(data));
        File.WriteAllText(path, json);
    }

}
