using System;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json.Linq;

public class SavedUser
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Products { get; set; }
}
public class User
{
    private string _name;
    private string _email;
    private string _password;
    private string _address;
    private string _phoneNumber;

    public User()
    {
        
    }
    public User(string name, string email, string password, string address, string phoneNumber)
    {
        _name = name;
        _email = email;
        _password = password;
        _address = address;
        _phoneNumber = phoneNumber;

    }

    public string GetName()
    {
        return _name;
    }

    public string GetEmail()
    {
        return _email;
    }

    public string GetPassword()
    {
        return _password;
    }

    public string GetAddress()
    {
        return _address;
    }

    public string GetPhoneNumber()
    {
        return _phoneNumber;
    }

    public virtual void GetUserInfo()
    {

    }

    public void SaveUser()
    {
        var savedUser = new SavedUser
        {
            Name = GetName(),
            Email = GetEmail(),
            Password = GetPassword(),
            Address = GetAddress(),
            PhoneNumber = GetPhoneNumber(),
            Products = ""
        };
        string filePath = @"C:\Users\User\Desktop\Software Development BS\BYU-I\webfundamentals\cse210-mr\final\FinalProject\sers.json";

        string jsonContent = File.ReadAllText(filePath);
        var options = new JsonSerializerOptions { WriteIndented = true};
        string jsonString = JsonSerializer.Serialize(savedUser, options);

        StringBuilder stringBuilder = new StringBuilder(jsonContent);
        int index = stringBuilder.Length - 1;
        stringBuilder.Insert(index, $",\n{jsonString}\n");
        string modifiedString = stringBuilder.ToString();

        File.WriteAllText("sers.json", modifiedString);

    }

    public void LoggedUser()
    {
        string filePath = @"C:\Users\User\Desktop\Software Development BS\BYU-I\webfundamentals\cse210-mr\final\FinalProject\sers.json";
        string jsonContent = File.ReadAllText(filePath);
        
    }
}