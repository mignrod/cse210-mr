using System;

public class User
{
    private string _name;
    private string _email;
    private string _password;
    private string _address;
    private string _phoneNumber;

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
}