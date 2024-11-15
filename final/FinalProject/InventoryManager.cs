using System;
using System.Collections.Generic;
using System.IO;

public class InventoryManager
{
    
    private List<Products> _stock = new List<Products>();
    private bool _InStock = false;

    public InventoryManager()
    {

    }

    public void SearchProduct()
    {

    }

    public void SaveProductList(List<Products> _stock, string fileName)
    {   
        // Reading previous data
        string[] data = System.IO.File.ReadAllLines(fileName);
        string lines = "";
        foreach(Products product in _stock)
        {
            lines = product.GetStringRepresentation();
        }
        // Write the file to save
        if(data.Length > 0)
        {
            using (StreamWriter outputfile = new StreamWriter(fileName))
            {
                data[data.Length - 1] += $"\n{lines}";

                foreach(string line in data)
                {
                    outputfile.WriteLine(line);
                }
            }
        } else {
            using (StreamWriter outputfile = new StreamWriter(fileName))
            {
                foreach(Products product in _stock)
                {
                    outputfile.WriteLine(product.GetStringRepresentation());
                }
            }
        }
            

    }

    public void AddProduct(List<Products> _stock)
    {
        Console.Clear();
        Console.Write("What is the product name?: ");
        string productName = Console.ReadLine();
        Console.Write("What is the product brand?: ");
        string productBrand = Console.ReadLine();
        Console.Write("What is the product ID (ex. 001)?: ");
        string productID = Console.ReadLine();
        Console.Write("Set the product price per unit (xx.xx): ");
        float productPrice = float.Parse(Console.ReadLine());
        Console.Write("How many items are availables?: ");
        int productQuantity = Convert.ToInt32(Console.ReadLine());
        Console.Write(@"
Select the type of product:
1. Technology
2. Clothing
Chose your option: ");
        string productType = Console.ReadLine();
        switch(productType)
        {
            case "1":
            Console.Write("Bring more details about the product, specifications or features: ");
            string productSpecs = Console.ReadLine();
            TechProducts techProduct = new TechProducts(productName, productBrand, productID, productPrice, productQuantity, productSpecs);
            _stock.Add(techProduct);
            break;

            case "2":
            Console.Write("What is the size?: ");
            string productSize = Console.ReadLine();
            Console.Write("What is the color?: ");
            string productColor = Console.ReadLine();
            ClothingProducts clothingProduct = new ClothingProducts(productName, productBrand, productID, productPrice, productQuantity, productSize, productColor);
            _stock.Add(clothingProduct);
            break;

        }
        
    }

    public void ReduceProduct()
    {

    }

    public void GetStockStatus()
    {

    }

    public void GetOrder()
    {

    }

    public void PackingLabel()
    {

    }

    public void TotalCost()
    {

    }
    public bool InStock()
    {
        return _InStock;
    }
}

