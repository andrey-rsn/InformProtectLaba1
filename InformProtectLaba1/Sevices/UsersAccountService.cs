using InformProtectLaba1.Data;
using Newtonsoft.Json;

namespace InformProtectLaba1.Sevices;

public class UsersAccountService
{
    private readonly string _path;
    public List<User> Users { get; set; }

    public UsersAccountService()
    {
        _path= Path.GetDirectoryName(Path.GetDirectoryName(
                Path.GetDirectoryName(
                    Path.GetDirectoryName(
                        AppDomain.CurrentDomain.SetupInformation.ApplicationBase))));
        ReadDataFromFile();
    }
    private void ReadDataFromFile()
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

    private void CreateAndFullFile(string path)
    {
        var data = new List<User>()
        {
            new User()
            {
                Id=1,
                isBlocked=false,
                isPasswordConstraint=true,
                Login="admin",
                Password="admin123",
                Role="admin"
            }
        };
        string json = JsonConvert.SerializeObject(data);
        File.WriteAllText(path, json);
    }
}
