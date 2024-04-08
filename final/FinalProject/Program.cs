using System;

class Program
{
    private static Dictionary<string, User> users = new Dictionary<string, User>();
    static void Main(string[] args)
    {
        File.WriteAllText("sers.json", "");
        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine("Here you could find a safe enviroment to buy or sell you products. Lets GO!\n");

        Console.Write($@"
  Menu Options:
===========================================
Please select one of the following choices:
1. Create New User account.
2. Log in.
===========================================
Select a choice from the menu:  ");

        string selection = Console.ReadLine();

        switch(selection)
        {
            case "1":
            Console.Clear();
            Console.WriteLine("Please select the user type: ");
            Console.WriteLine("1. Customer");
            Console.WriteLine("2. Buyer");
            Console.WriteLine("3. Quit Program.");
            Console.Write("Please select your prefer option: ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                Console.WriteLine("Complete the following data in order to complete the registration: ");
                Console.Write("Full name: ");
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
            }

            break;

        }

    }
}