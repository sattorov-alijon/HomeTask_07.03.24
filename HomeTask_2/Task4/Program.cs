using System.Runtime.ConstrainedExecution;
using Task4;

var counter=new Counter();
System.Console.WriteLine(counter.Get());
counter.Increase();
counter.Increase();
System.Console.WriteLine(counter.Get());
counter.Decrease();
counter.Decrease();
System.Console.WriteLine(counter.Get());
counter.Increase(5);
System.Console.WriteLine(counter.Get());
counter.Decrease(3);
System.Console.WriteLine(counter.Get());
var counter1=new Counter(10);
counter1.Decrease(6);
System.Console.WriteLine(counter1.Get());