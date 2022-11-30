using System;
 class Program
{
    public int P = 0;
    public int R = 0;
    static void Main(string[] args)
    {
        string[] RentDate = new string[] 
        {
            "Clock",
            "Rent Time Remaining"
        };
        for(int i=0; i < RentDate.Length; i++)
        {
            Console.WriteLine("{0}. {1}", i, RentDate[i]);
        }
        int u = 0;
        Console.Write("Select Menu From Keyboard : ");
        u = int.Parse(Console.ReadLine());
        if(u == 0)
        {
             
            int a = 99999;
            long currenttime = DateTime.Now.Ticks;
            Console.WriteLine(new DateTime(currenttime));
            for(int i = 0; i < a; i--)
            {
            Console.Clear();
            currenttime = currenttime + 10000000;
            Console.WriteLine(new DateTime(currenttime));
            System.Threading.Thread.Sleep(1000);
            }
        }
        
        else if (u == 1)
        {
            Console.WriteLine("Your Rent Duration is {0} Day(s)");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Command Not Found!");
            Console.Clear();
        }
       
    }
    
}
       