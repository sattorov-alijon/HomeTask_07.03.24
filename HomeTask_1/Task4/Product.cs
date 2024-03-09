﻿namespace Task4;

public class Product
{
    private string _name; 
    private double _price; 
    private int _quantity; 
    public Product(string name,double price,int quantity)
    {
       _name=name; 
       _price=price; 
       _quantity=quantity; 
    }

    public void PrintProduct()
    {
        System.Console.WriteLine($"{_name}: price {_price}: {_quantity} pcs");
    }
}