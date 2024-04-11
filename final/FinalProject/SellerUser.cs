using System;
using System.Collections.Generic;

public class SellerUser : User
{
    private List<Products> _products;

    public SellerUser(string name, string email, string password, string address, string phoneNumber, string products) : base(name, email, password, address, phoneNumber)
    {
        _products = new List<Products>();
        products = String.Join(",", _products);
        

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
2. Publish Product.
3. Complete orders.
4. Show user information. 
5. Exit Program.
==================================
Select one option: ");

            string option = Console.ReadLine();
            InventoryManager inventory = new InventoryManager();
            switch(option)
            {
                case "1":
                inventory.AddProduct(_products);
                string fileName = $"{GetName()}.txt";
                inventory.SaveProductList(_products, fileName);
                break;

                case "2":
                publish();
                break;

                case "3":
                break;

                case "4":
                GetUserInfo();
                break;

                case "5":
                Environment.Exit(0);
                return;

            }
        }
    }
    public void publish()
    {
        Console.Clear();
        Console.Write("Select what product you want to publish.");
        string fileName = $"{GetName()}.txt";

        Console.Write(@$"
{GetName()} Products:
====================================");

        string[] lines = System.IO.File.ReadAllLines(fileName);
        int j = 1;
        for(int i = 0; i < lines.Count(); i++)
        {
        
            Console.Write(@$"
{j}. Product: {lines[i]}");
            j++;
        }
        Console.Write(@"Select your option: ");
        int selectedProduct = Convert.ToInt32(Console.ReadLine()) - 1;
        string s = lines[selectedProduct];
        string[] storeText = System.IO.File.ReadAllLines("store.txt");
        if(storeText.Length > 0)
        {
            storeText[storeText.Length - 1] += $"\n{s}";

            using (StreamWriter outputfile = new StreamWriter("store.txt"))
            {
                foreach(string line in storeText)
                {
                    outputfile.WriteLine(line);
                }
            }
        } else {

            using (StreamWriter outputfile = new StreamWriter("store.txt"))
            {
                outputfile.WriteLine(s);
            }
        }
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