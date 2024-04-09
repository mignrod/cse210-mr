using System;

class Program
{
    
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine("Here you could find a safe enviroment to buy or sell you products. Lets GO!");

        Console.Write($@"
  Menu Options:
===========================================
Please select one of the following choices:
1. Create New User account.
2. Log in.
3. Quit Program.
===========================================
Select a choice from the menu:  ");

        string selection = Console.ReadLine();
        while(true)
        {
            switch(selection)
            {
                case "1":
                Console.Clear();
                Console.WriteLine("Please select the user type: ");
                Console.WriteLine("1. Customer");
                Console.WriteLine("2. Buyer");
                Console.WriteLine("3. Quit Program.");
                Console.Write("Please select your option: ");
                string choice = Console.ReadLine();
    
                switch(choice)
                {
                    case "1":
                    Console.Clear();
                    Console.WriteLine("Complete the following data in order to complete the registration: ");
                    Console.Write("User Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Email address: ");
                    string email = Console.ReadLine();
                    Console.Write("Create your password: ");
                    string password = Console.ReadLine();
                    Console.Write("Address: ");
                    string address = Console.ReadLine();
                    Console.Write("Phone Number: ");
                    string phoneNumber = Console.ReadLine();
                    string shoppingList = "";
                    CustomerUser customer = new CustomerUser(name, email, password, address, phoneNumber, shoppingList);
                    Console.Clear();
                    Console.WriteLine("Well Done!! This is your basic information: ");
                    customer.GetUserInfo();
                    customer.SaveUser();
                    customer.CustomerUserManager();
                    break;

                    case "2":
                    Console.Clear();

                    Console.WriteLine("Complete the following data in order to complete the registration: ");
                    Console.Write("User Name: ");
                    name = Console.ReadLine();
                    Console.Write("Email address: ");
                    email = Console.ReadLine();
                    Console.Write("Create your password: ");
                    password = Console.ReadLine();
                    Console.Write("Address: ");
                    address = Console.ReadLine();
                    Console.Write("Phone Number: ");
                    phoneNumber = Console.ReadLine();
                    string products = "";
                    SellerUser seller = new SellerUser(name, email, password, address, phoneNumber, products);
                    Console.Clear();
                    Console.WriteLine("Well Done!! This is your basic information: ");
                    seller.GetUserInfo();
                    seller.SaveUser();
                    seller.SellerUserManager();
                    break;

                    case "3":
                    Console.WriteLine("Good Bye!!!");
                    return;

                }

                break;

                case "2":
                User logUser = new User();
                logUser.LoggedUser();
                

                break;

                
                case "3":
                return;
            }
        }

    }
}