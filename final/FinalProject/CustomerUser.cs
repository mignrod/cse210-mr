using System;
using System.IO;
using System.Collections.Generic;

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
        Console.Clear();



    }
}