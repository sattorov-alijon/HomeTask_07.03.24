﻿namespace Task5;

public class Counter
{
    private int _value; 
    public Counter(int value)
    {
    _value=value;  
    } 
    public int Decrement()
    {
        if (_value==0)
        {
        return 0;
        }  

        return _value--;
        
    } 
    public int Reset()
    { 
        _value=0;
        return _value;
    }  
    public void PrintValue()
    {
        System.Console.WriteLine(_value);
    }


}