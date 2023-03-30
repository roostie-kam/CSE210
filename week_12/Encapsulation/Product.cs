// File: Product //
// Date: 3/26/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Encapsulation (Product) Activity code in CS#. //
// namespace Product //
// namespace Encapsulation //
// using System //
// using System.Diagnostics //
// Attribute - Noun. //
// Method - (Action) - Adjective.

namespace Encapsulation;
using System;
using System.Diagnostics;

class Product
// partial class Product
{
    protected int _product;
    protected int _productId;
    protected int _price; // Per Unit Price.
    protected int _quantity;
    private int price;
    private int quantity;

    public Product()
    {
        // Revert to 1/1
        _product = 1;
        _productId = 1;
        _price = 1;
        _quantity = 1;
    }
    public Product(int wholeNumber)
    {
        _product = wholeNumber;
        _productId = 1;
        _price = wholeNumber;
        _quantity = 1;
    }
    public Product(int product, int productID)
    {
        _product = product;
        _productId = productID;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductString()
    {
        // Understand that this is not stored as a member variable.
        // This is just an interim, local variable that will be recalculated every time it's called.
        string text = $"{_product}/{_productId}";
        return text;
    }
    public string GetQuantityString()
    {
        // Understand that this is not stored as a member variable.
        // This is just an interim, local variable that will be recalculated every time it's called.
        string text = $"{_price}/{_quantity}";
        return text;
    }
    public double GetProductValue() 
   {
        // Understand that this is not stored as a member variable.
        // This will be recalculated every time it's called.
        return (double)_product / (double)_productId;
    }
    public double GetPriceValue()
    {
        return (double)_price / (double)_quantity;
    }

    internal bool GetDecimalValue()
    {
        throw new NotImplementedException();
    }
}