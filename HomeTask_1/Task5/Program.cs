﻿using Task5;

var counter1=new Counter(5);
counter1.Decrement(); 
counter1.PrintValue(); 
System.Console.WriteLine(); 

var counter2=new Counter(0); 
counter2.Decrement(); 
counter2.PrintValue(); 
System.Console.WriteLine(); 

var counter3=new Counter(0); 
counter3.Reset(); 
counter3.PrintValue(); 
System.Console.WriteLine(); 