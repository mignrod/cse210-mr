using System;

public class ClothingProducts : Products
{
    private string _size;
    private string _color;

    public ClothingProducts(string productName, string productBrand, string productID, float price, int quantity, string size, string color) : base(productName, productBrand, productID, price, quantity)
    {
        _size = size;
        _color = color;

    }

    public override void GetProductDetails()
    {

    }

    public override void GetOrder()
    {
        
    }

    public override string GetStringRepresentation()
    {
        return $"Product: {GetProductName()} | Brand: {GetProductBrand()} | ID: {GetProductID()} | Price: {GetPrice()} | Quantity: {GetQuantity()} | Size: {_size} | Color: {_color}";
    }
}