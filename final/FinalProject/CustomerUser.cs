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
        while(true)
        {
            Console.Write($@"
Menu Options - {GetName()}.
==================================
1. Search products.
2. See list of available products.
3. Show user information.
4. Exit Program.
==================================
Select one option: ");

            string option = Console.ReadLine();
            
            switch(option)
            {
                case "1":
                break;

                case "2":
                break;

                case "3":
                GetUserInfo();
                break;

                case "4":
                Environment.Exit(0);
                break;

            }
        }
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