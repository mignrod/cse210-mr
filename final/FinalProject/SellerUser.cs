using System;
using System.Collections.Generic;

public class SellerUser : User
{
    private List<Products> _products;

    public SellerUser(string name, string email, string password, string address, string phoneNumber, string products) : base(name, email, password, address, phoneNumber)
    {
        _products = new List<Products>();
        

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