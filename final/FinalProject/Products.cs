using System;

public abstract class Products
{
    private float _price;
    private string _productID;
    private string _productName;
    private string _productBrand;
    private int _quantity;

    public Products(string productName, string productBrand, string productID, float price, int quantity)
    {
        _price = price;
        _productID = productID;
        _productName = productName;
        _productBrand = productBrand;
        _quantity = quantity;

    }

    public  virtual void GetProductDetails()
    {

    }

    public abstract void GetOrder();


}