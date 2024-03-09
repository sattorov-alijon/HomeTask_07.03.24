using Task2;

var account1=new Account(); 
account1.AccountName="Heikki's account"; 
account1.AccountAmount=2000; 

var account2=new Account();
account2.AccountName="Personal account"; 
account2.AccountAmount=0; 

account1.WithdrawAmount(200); 
account2.AddAmount(200); 

System.Console.WriteLine(account1.ToString()); 
System.Console.WriteLine(account2.ToString()); 