﻿namespace Task2;

public class Account
{
     public string AccountName { get; set; } 
     public decimal AccountAmount { get; set; }
       

    public void AddAmount(decimal deposit)
    {
        AccountAmount+=deposit; 
    }  

    public void WithdrawAmount(decimal money)
    {
        AccountAmount-=money;
    }
    public override string ToString()
    {
        return  $"{AccountName} account balance is {AccountAmount}";
    }
}