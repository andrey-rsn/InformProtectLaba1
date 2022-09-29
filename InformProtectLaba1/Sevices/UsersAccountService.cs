using InformProtectLaba1.Data;
using Newtonsoft.Json;

namespace InformProtectLaba1.Sevices;

public static class UsersAccountService
{
    private static readonly string _path;
    public static List<User> Users { get; set; }

    static UsersAccountService()
    {
        _path= Path.GetDirectoryName(Path.GetDirectoryName(
                Path.GetDirectoryName(
                    Path.GetDirectoryName(
                        AppDomain.CurrentDomain.SetupInformation.ApplicationBase))));
        ReadDataFromFile();
    }

    public static void SaveData()
    {
        var filePath = Path.Combine(_path, "Data", "accounts.json");
        string json = JsonConvert.SerializeObject(Users);
        File.WriteAllText(filePath, json);
    }
    private static void ReadDataFromFile()
    {
        var filePath= Path.Combine(_path, "Data", "accounts.json");
        if (!File.Exists(filePath))
        {
            CreateAndFullFile(filePath);
        }
        using (StreamReader r = new StreamReader(filePath))
        {
            string json = r.ReadToEnd();
            Users = JsonConvert.DeserializeObject<List<User>>(json);
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
        string json = JsonConvert.SerializeObject(data);
        File.WriteAllText(path, json);
    }
}
