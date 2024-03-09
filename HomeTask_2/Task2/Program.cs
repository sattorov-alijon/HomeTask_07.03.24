string a;
int cnt=0;
System.Console.WriteLine("Satrhoro dokhil kuned:");
for (;;)
{
 System.Console.Write("> ");   a=Console.ReadLine();
    cnt++;
    if (a.ToLower().Trim()=="end")
    {
        break;
    }
}
System.Console.WriteLine(cnt);