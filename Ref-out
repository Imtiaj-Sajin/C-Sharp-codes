using System;

public class Program
{
   public static void m1(int a,int b,ref int x,ref int y)
    {
        x=a+b;
        x=a+b;
    }
    public static void m2(int a,int b,out int x,out int y)
    {
        x=a+b;
        y=a+b;
    }
    public static void Main(string[] args)
    {
        int k=0;
        int p=0;
        m1(50,50,ref k,ref p);
        Console.WriteLine($"K:{k}");
       Console.WriteLine($"P:{p}");
       int yOut=0,zOut=0;
       m2(50,50,out yOut,out zOut);
       Console.WriteLine($"yOut:"+yOut);
       Console.WriteLine($"zOut:"+zOut);
    }
}
