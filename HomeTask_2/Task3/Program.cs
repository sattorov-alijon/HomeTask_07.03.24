using System.Runtime.ConstrainedExecution;
using Task3;

var gauge=new Gauge();
System.Console.WriteLine(gauge.Get());
gauge.Enhance();
gauge.Enhance();
gauge.Enhance();
gauge.Enhance();
System.Console.WriteLine(gauge.Get());
gauge.Decrease();
gauge.Decrease();
gauge.Decrease();
System.Console.WriteLine(gauge.Get());

System.Console.WriteLine(gauge.Full());
gauge.Set(5);
System.Console.WriteLine(gauge.Get());

System.Console.WriteLine(gauge.Full());
