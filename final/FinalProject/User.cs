using System;
using System.Text;
using System.Text.Json;
// using Newtonsoft.Json;
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
        string filePath = @"C:\Users\User\Desktop\Software Development BS\BYU-I\webfundamentals\cse210-mr\final\FinalProject\users.json";

        string jsonContent = File.ReadAllText(filePath);
        var options = new JsonSerializerOptions { WriteIndented = true};
        string jsonString = JsonSerializer.Serialize(savedUser, options);

        StringBuilder stringBuilder = new StringBuilder(jsonContent);
        int index = stringBuilder.Length - 1;
        stringBuilder.Insert(index, $",\n{jsonString}\n");
        string modifiedString = stringBuilder.ToString();

        File.WriteAllText("users.json", modifiedString);

    }

    public void LoggedUser()
    {
        string filePath = @"C:\Users\User\Desktop\Software Development BS\BYU-I\webfundamentals\cse210-mr\final\FinalProject\users.json";
        string jsonContent = File.ReadAllText(filePath);
        var grups = JsonSerializer.Deserialize<List<Grup>>(jsonContent);

        bool AutenticateUser(string inputName, string inputPassword, string inputType)
        {
            Console.Write("Processing...");
            Thread.Sleep(2000);
            Console.Clear();

            var grup = grups.FirstOrDefault(g => g.Name == inputName);
            if (grup != null)
            {   
                if (inputType == "S")
                {
                    SellerUser seller = new SellerUser(grup.Name, grup.Email, grup.Password, grup.Address, grup.PhoneNumber, grup.Products);
                    seller.SellerUserManager();
                } else {
                    CustomerUser customer = new CustomerUser(grup.Name, grup.Email, grup.Password, grup.Address, grup.PhoneNumber, grup.Products);
                    customer.CustomerUserManager();
                }
                return grup.Password == inputPassword;
            }
            return false;
        }

        // Recieve data from user
        Console.WriteLine("Complete the following: ");
        Console.Write("User Name: ");
        string userName = Console.ReadLine();
        Console.Write("Password: ");
        string userPassword = Console.ReadLine();
        Console.Write("Seller or Customer?: (S or C) ");
        string userType = Console.ReadLine().ToUpper();


        if(AutenticateUser(userName, userPassword, userType))
        {
            
        }
        else
        {
            Console.WriteLine("User name or password incorrect!");
        }
        
    }

    public string GetJsonString()
    {
        string filePath = @"C:\Users\User\Desktop\Software Development BS\BYU-I\webfundamentals\cse210-mr\final\FinalProject\users.json";
        string jsonContent = File.ReadAllText(filePath);
        var grups = JsonSerializer.Deserialize<List<Grup>>(jsonContent);
        var grup = grups.FirstOrDefault(g => g.Name == GetName());
        return jsonContent;
        // return false;
    }

    public class Grup
    {
        public string Name { get; set;}
        public string Email { get; set;}
        public string Password { get; set;}
        public string Address { get; set;}
        public string PhoneNumber { get; set;}
        public string Products { get; set;}

    }

}