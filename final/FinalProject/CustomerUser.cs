using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json.Linq;

public class SavedUser
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

}
public class CustomerUser : User
{
    private List<Products> _shoppingList;

    public CustomerUser(string name, string email, string password, string address, string phoneNumber, string shoppingList) : base(name, email, password, address, phoneNumber)
    {
        _shoppingList = new List<Products>();
    
    }

    public void CustomerUserManager()
    {
        Console.WriteLine($"Welcome {GetName()}.");
        Console.WriteLine($@"
Menu Options - {GetName()}.
==================================
1. Search products by name.
2. Search products by brand.
3. See list of available products.
==================================
Select one option: ");

        string option = Console.ReadLine();
    }

    public void SaveUser()
    {
        var savedUser = new SavedUser
        {
            Name = GetName()
        };
        string filePath = "\\sers.json";

        var options = new JsonSerializerOptions { WriteIndented = true};
        string jsonString = JsonSerializer.Serialize(savedUser, options);
        string jsonContent = File.ReadAllText(filePath);
        JObject jsonObject = JObject.Parse(jsonContent);
        jsonObject["newUser"] = jsonString;

        File.WriteAllText(filePath, jsonObject.ToString());




    }

    public void Buy()
    {

    }

    public void Edit()
    {

    }

    public override void GetUserInfo()
    {
        Console.Write($@"
*************************
Name : {GetName()}.
Email: {GetEmail()}
Password: {GetPassword()}
Address: {GetAddress()}.
Phone Number: {GetPhoneNumber()}
*************************
Click ENTER to continue... ");
        Console.ReadKey();


    }
}