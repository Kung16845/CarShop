enum Menu 
{   
    MenuLogin = 1
    ,MenuListCar
}
public class Program 
{
    static Emaillist emaillist;
    static Persondlist persondlist;
    static Vehiclelist vehiclelist;

    static void PreparInfo()
    {
        Program.emaillist = new Emaillist();
        Program.persondlist = new Persondlist();
        Program.vehiclelist = new Vehiclelist();
        InfoAdmin();
        InfoCar();
    }
    static void Main(string[] args)
    {
        PreparInfo();
        MenuCar();   
    }
    static void MenuCar()
    {
        Console.WriteLine("Welcome To Car Rental Office");
        Console.WriteLine(" 1 : MenuLogin \n 2 : MenuListCar");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));
        switch(menu)
        {
            case Menu.MenuLogin:
                Login();
                AdminMode();
                break;
            case Menu.MenuListCar:
                vehiclelist.PrintInfoCar();
                BookatCar(); 
                break;
            default :
                break;
        }
    }
    static void BookatCar()
    {
        Console.WriteLine("Choose Car in Catalogue");
        Console.WriteLine("Back to MainMenu : 0");
        int numbercar = int.Parse(Console.ReadLine());
        if (numbercar == 0)
        {
            MenuCar();
        }
        // เลือกรถจอง 
        RegisterCustomer();
        Console.WriteLine("Recived Order!!!");
        MenuCar();
    }
    static void RegisterCustomer()
    {
        Console.Clear();
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
    static void AdminMode()
    {
        Console.Clear();
        Console.WriteLine(" 1 : Signin New Worker \n 2 : Customers of Data \n 3 : Data All Worker \n 0 : Back To MainMenu");
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Signin();
        }
        else if (n == 2)
        {
            Output();
        }
        else if (n == 3)
        {
            //ข้อมูลพนักงาน 
        }
        else if (n == 0)
        {
            MenuCar();
        }
       
    }
    static void Signin()
    {
        Console.Clear();
        Console.WriteLine("Sign-In new worker!!!");
        Email email = new Email(InputEmail(),InputPassword());
        if (emaillist.checkmail(email.GetEmail()) == "Alreadytanken") 
        {
            Console.WriteLine("Alreadytanken");
            System.Threading.Thread.Sleep(2000);
            Signin();
        }
        else if (emaillist.checkmail(email.GetEmail()) == "e")
        {
            MenuCar();
        }
        else 
        {
            Console.WriteLine("Thank You for Register!!!!");
            emaillist.AddNewEmail(email);
            MenuCar();
        }       
    }
    static void Login()
    {      
        Console.Clear();
        Console.WriteLine("Login to AdminMode");
        Console.WriteLine("Back to MainMenu : exit");
        Email email = new Email(InputEmail(),InputPassword());
        if (emaillist.login(email.GetEmail(),email.Getpassword()) == "Passed")
        {
            Console.WriteLine("Welcome");
        }
        else if (emaillist.login(email.GetEmail(),email.Getpassword()) == "Deninded")
        {
            Console.WriteLine("Wrong Email or Wrong Password");
            System.Threading.Thread.Sleep(2000);
            Login();
        }
        else 
        {
            MenuCar();
        }
    }
    static void InfoAdmin()
    {
        emaillist.AddNewEmail(new Email("11","22"));
    }
    static void InfoCar()
    {
        vehiclelist.AddNewVehicle(new Vehicleinfo("Fortuner","Toyota","SUV",5000));
        vehiclelist.AddNewVehicle(new Vehicleinfo("Pajero Sports","Mitsubishi","SUV",5000));
        vehiclelist.AddNewVehicle(new Vehicleinfo("City 1.5","Honda","SUV",5000));
        vehiclelist.AddNewVehicle(new Vehicleinfo("Almera 1.2","Nissan","SUV",5000));
        vehiclelist.AddNewVehicle(new Vehicleinfo("Mu-X","ISUZU ","SUV",5000));
    }
   
    static void Output()
    {
        persondlist.ShowPerson();
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
