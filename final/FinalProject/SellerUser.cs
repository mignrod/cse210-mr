using System;
using System.Collections.Generic;

public class SellerUser : User
{
    private List<Products> _products;

    public SellerUser(string name, string email, string password, string address, string phoneNumber, string products) : base(name, email, password, address, phoneNumber)
    {
        _products = new List<Products>();
        

    }

    public void SellerUserManager()
    {
        Console.WriteLine($"Welcome {GetName()}.");

        while(true)
        {
            Console.Write($@"
Menu Options - {GetName()}.
==================================
1. Add Product to Inventory.
2. Edit Inventory.
3. Publish Product.
4. Complete orders.
5. Edit user information.
6. Show user information. 
7. Exit Program.
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
                break;

                case "4":
                break;

                case "5":
                break;

                case "6":
                GetUserInfo();
                break;

                case "7":
                Environment.Exit(0);
                return;

            }
        }
    }
    public void publish()
    {

    }

    public void Edit()
    {

    }

    public override void GetUserInfo()
    {
        Console.Clear();
        Console.Write(@$"
===============================
Username : {GetName()}
Email : {GetEmail()}
Address : {GetAddress()}
Phone Number : {GetPhoneNumber()}
List of Available Products :

===============================
Click ENTER to continue...
");
        Console.ReadKey();
        Console.Clear();

    }

}