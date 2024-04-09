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
        Console.WriteLine($@"
Menu Options - {GetName()}.
==================================
1. Add Product to Inventory.
2. Edit Inventory.
3. Publish Product.
4. Complete orders.
==================================
Select one option: ");

        string option = Console.ReadLine();
    }
    public void publish()
    {

    }

    public void Edit()
    {

    }

    public override void GetUserInfo()
    {

    }

}