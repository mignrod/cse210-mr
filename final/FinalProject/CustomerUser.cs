using System;

public class CustomerUser : User
{
    private List<Products> _shoppingList;

    public CustomerUser(string name, string email, string password, string address, string phoneNumber, string shoppingList) : base(name, email, password, address, phoneNumber)
    {
        _shoppingList = new List<Products>();
    
    }

    public void Buy()
    {

    }

    public void Edit()
    {

    }

    public override void GetUserInfo()
    {

    }
}