using System;

public class TechProducts : Products
{
    private string _specifications;

    public TechProducts(string productName, string productBrand, string productID, float price, int quantity, string specifications) : base(productName, productBrand, productID, price, quantity)
    {
        _specifications = specifications;

    }

    public override void GetProductDetails()
    {

    }
    public override void GetOrder()
    {

    }

}