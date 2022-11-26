public class Program 
{
    static Emaillist emaillist;
    static Persondlist persondlist;

    static void PreparPersonListAndEmilList()
    {
        Program.emaillist = new Emaillist();
        Program.persondlist = new Persondlist();
    }
    static void Main(string[] args)
    {
        PreparPersonListAndEmilList();
        RegisterCustomer();       
    }
    static void RegisterCustomer()
    {
        Console.WriteLine("Type in Pronouns is Mr press 1, Mrs press 2 ,Miss press 3");
        string pronouns = Console.ReadLine();
        if (pronouns == "1" )
        {
            pronouns = "Mr";
        }
        else if (pronouns == "2" )
        {
            pronouns = "Mrs";
        }
        else if (pronouns == "3" )
        {
            pronouns = " Miss";
        }
        Console.Write("Type in Name : ");
        string name = Console.ReadLine();
        Console.Write("Type in SurName : ");
        string surname = Console.ReadLine();
        Console.Write("Type in Age : ");
        string age = Console.ReadLine();
        Person persons = new Person(pronouns,name,surname,age);
        persondlist.AddNewPerson(persons);
    }  
    static void Signin()
    {
        Email email = new Email(InputEmail(),InputPassword());
        if (emaillist.checkmail(email.GetEmail()) == "Alreadytanken") 
        {
            Console.WriteLine("Alreadytanken");
            Signin();
        }
        else if (emaillist.checkmail(email.GetEmail()) == "e")
        {
            Console.WriteLine("Menu");
        }
        else 
        {
            Console.WriteLine("Thank You for Register!!!!");
            emaillist.AddNewEmail(email);
        }       
    }
    static void Login()
    {      
        Email email = new Email(InputEmail(),InputPassword());
        if (emaillist.login(email.GetEmail(),email.Getpassword()) == "Passed")
        {
            Console.WriteLine("Welcome");
        }
        else if (emaillist.login(email.GetEmail(),email.Getpassword()) == "Deninded")
        {
            Console.WriteLine("Wrong Email or Wrong Password");
            Login();
        }
        else 
        {
            Console.WriteLine("Menu");
        }
    }
    static void Output()
    {
        persondlist.ShowPerson();
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
    public static string InputEmail()
    {
        Console.WriteLine("Input your Email");
        return Console.ReadLine();
    }
    public static string InputPassword()
    {
        Console.WriteLine("Input your Password");
        return Console.ReadLine();
    }
    
}
