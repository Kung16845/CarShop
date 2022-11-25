public class Program 
{
    static void main(string[] args)
    {
        Console.WriteLine("Hello world");
    }
    static void Signin()
    {
        
    }
    static void RandomOTP()
    {
        Random rnd = new Random();
                int i = 1;
                while (i <= 6)
                {
                    Console.Write(rnd.Next(0, 10));
                    i++;
                }
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
    }
}
