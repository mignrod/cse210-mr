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
                Search();
                break;

                case "2":
                SeeList();
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
    public void Search()
    {
        Console.Clear();
        string[] pLines = System.IO.File.ReadAllLines("store.txt");
        Console.Write("What are you looking for?: ");
        string response = Console.ReadLine();
        
        foreach(string line in pLines)
        {
            string[] parts = line.Split('|');
            if(parts[0] == $"Product : {response}")
            {
                Console.WriteLine(line);
            } else {
                Console.WriteLine($"Sorry!! There is no product *{response}* on sell.");

            }
        }

    }

    public void SeeList()
    {
        Console.Clear();
        string[] pLines = System.IO.File.ReadAllLines("store.txt");
        if(pLines.Length > 0)
        {
            Console.WriteLine("List of Available products: ");
            Console.WriteLine(@$"
============================================");
            int j = 1;
            foreach(string line in pLines)
            {
                Console.WriteLine($"{j}. {line}");
                j++;
            }
            Console.Write("Select the product: ");
            int pSelect = Convert.ToInt32(Console.ReadLine()) - 1;
            string productBuyed = pLines[pSelect];
            Buy(productBuyed);
        } else {
            Console.WriteLine("Sorry! There is no avaible products right now.");
        }
    }

    public void Buy(string s)
    {
        Console.Clear();
        string[] parts = s.Split("|");
        string[] section = parts[1].Split(":");
        Console.WriteLine($"You have Selected the current {parts[0]} {section[1]}");
        Console.WriteLine($"{parts[3]}.");
        Console.Write("Do you want to confirm this buy? (Y or N): ");
        string confirmation = Console.ReadLine().ToUpper();
        switch(confirmation)
        {
            case "Y":
            break;

            case "N":
            return;
        }
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