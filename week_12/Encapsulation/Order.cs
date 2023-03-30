// File: Order //
// Date: 3/26/2023 // 
// Author: Scott Kamerath // 
// Purpose: To learn how to write an Encapsulation (Order) Activity code in CS#. //
// namespace Order //
// namespace Encapsulation //
// using System //
// using System.Diagnostics //
// The parent class. //


namespace Encapsulation;
using System;
using System.Diagnostics;

class Order
// partial class Order
{
    protected int _above;
    protected int _below;

    public Order()
    {
        // Revert to 1/1
        _above = 1;
        _below = 1;
    }
    public Order(int wholeNumber)
    {
        _above = wholeNumber;
        _below = 1;
    }
    public Order(int above, int below)
    {
        _above = above;
        _below = below;
    }

    public string GetOrderString()
    {
        // Notice that this is not stored as a member variable.
        // This is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_above}/{_below}";
        return text;
    }
    public double GetOrderValue() 
   {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_above / (double)_below;
    }

    internal bool GetDecimalValue()
    {
        throw new NotImplementedException();
    }
}