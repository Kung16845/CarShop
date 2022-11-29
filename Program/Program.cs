enum Menu 
{   
    MenuLogin = 1
    ,MenuListCar,StatusCustomer
}
public class Program 
{
    static Emaillist emaillist;
    static Persondlist persondlist;
    static Vehiclelist vehiclelist;
    static Customerlist customerlist;

    static void PreparInfo()
    {
        Program.emaillist = new Emaillist();
        Program.persondlist = new Persondlist();
        Program.vehiclelist = new Vehiclelist();
        Program.customerlist = new Customerlist();
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
        Console.Clear();
        Console.WriteLine("Welcome To Car Rental Program");
        Console.WriteLine(" 1 : MenuLogin \n 2 : Carlist for rent \n 3 : Rent Status" );
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));
        switch(menu)
        {
            case Menu.MenuLogin:
                Login();
                AdminMode();
                break;
            case Menu.MenuListCar:               
                BookatCar();
                break;
            case Menu.StatusCustomer:
                PrintStatusCustomer();
                //ข้อมูลลูกค้าที่จองรถแล้ว
                break;
            default :
                break;
        }
    }
    static void PrintStatusCustomer()//แสดงข้อมู,ลูกค้าส่วนตัว 
    {
        Console.Clear();
        Console.Write("Please Input Your Serial number:");
        customerlist.SearchStatusYourBookCar(int.Parse(Console.ReadLine()));
        Thread.Sleep(5000);
        MenuCar();
    }
    static void BookatCar()
    {
        Console.Clear();      
        vehiclelist.PrintInfoCar(); 
        Console.WriteLine("Choose Car in Catalogue");
        Console.WriteLine("Back to MainMenu : 0");        
        int numbercar = int.Parse(Console.ReadLine());            
        if (numbercar == 0)
        {
            MenuCar();
        }
        else if (numbercar == 1)
        {
            Console.Write("Input your amount of rent day : ");
            int numberday = int.Parse(Console.ReadLine());      
            int code = Randompassword();
            Customer customer = new Customer(InputPronoun(),InputName(),InputSurName(),InputAge(),
            "000001","Fortuner","Toyota","SUV",5000,CalculateDay(numberday),code);
            customerlist.Addnewcustomer(customer);
            Console.WriteLine("Your serial number for check status is {0}",code); 
            Console.WriteLine("Recived Order!!!");
            Thread.Sleep(5000);
                       
        }
        else if (numbercar == 2)
        {
            Console.Write("Input your amount of rent day : ");
            int numberday = int.Parse(Console.ReadLine());  
            int code = Randompassword();    
            Customer customer = new Customer(InputPronoun(),InputName(),InputSurName(),InputAge(),
            "000002","Pajero Sports","Mitsubishi","SUV",5000,CalculateDay(numberday),code);
            customerlist.Addnewcustomer(customer);
            Console.WriteLine("Your serial number for check status is {0}",code); 
            Console.WriteLine("Recived Order!!!");            
            Thread.Sleep(5000);
        }
        else if (numbercar == 3)
        {
            Console.Write("Input your amount of rent day : ");
            int numberday = int.Parse(Console.ReadLine());
            int code = Randompassword();      
            Customer customer = new Customer(InputPronoun(),InputName(),InputSurName(),InputAge(),
            "000003","City 1.5","Honda","SUV",5000,CalculateDay(numberday),code);
            customerlist.Addnewcustomer(customer);
            Console.WriteLine("Your serial number for check status is {0}",code); 
            Console.WriteLine("Recived Order!!!");          
            Thread.Sleep(5000);
        }
        else if (numbercar == 4)
        {
            Console.Write("Input your amount of rent day : ");
            int numberday = int.Parse(Console.ReadLine());      
            int code = Randompassword();
            Customer customer = new Customer(InputPronoun(),InputName(),InputSurName(),InputAge(),
            "000004","Almera 1.2","Nissan","SUV",5000,CalculateDay(numberday),code);
            customerlist.Addnewcustomer(customer);
            Console.WriteLine("Your serial number for check status is {0}",code); 
            Console.WriteLine("Recived Order!!!"); 
            Thread.Sleep(5000);
        }
        else if (numbercar == 5)
        {
            Console.Write("Input your amount of rent day : ");
            int numberday = int.Parse(Console.ReadLine());     
            int code = Randompassword(); 
            Customer customer = new Customer(InputPronoun(),InputName(),InputSurName(),InputAge(),
            "000005","Mu-X","ISUZU ","SUV",5000,CalculateDay(numberday),code);
            customerlist.Addnewcustomer(customer);
            Console.WriteLine("Your serial number for check status is {0}",code);    
            Console.WriteLine("Recived Order!!!");      
            Thread.Sleep(5000);
        } // เลือกรถจอง 
        MenuCar();
    } 
    static void AdminMode()
    {
        Console.Clear();
        Console.WriteLine(" 1 : Signin New Worker \n 2 : list of Customer \n 3 : list of Worker \n 0 : Back To MainMenu");
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Signin();
        }
        else if (n == 2)
        {
            Console.Clear();
            OutputDataCustomerAdmin();
        }
        else if (n == 3)
        {
            WorkerData();
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
        persondlist.AddNewPerson(new Worker(InputPronoun(),InputName(),InputSurName(),InputAge(),InputPosition()));     
    }
    static void Login()
    {      
        Console.Clear();
        Console.WriteLine("Login to AdminMode");
        Console.WriteLine("Back to MainMenu : type exit");
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
        persondlist.AddNewPerson(new Worker("Mr","varit","Trippichaphan","20","Owner"));
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
   
    static void OutputDataCustomerAdmin()
    {
        customerlist.ShowCustomerclass();
        Thread.Sleep(10000);
        MenuCar();
    }
    static void WorkerData()
    {
        persondlist.Showworker();
        Thread.Sleep(10000);
        MenuCar();
    }
    static long CalculateDay(int numberday)
    {
        long currenttime = DateTime.Now.Ticks;
        long future = currenttime + (numberday*864000000000);
        return future;
    }
    static string InputPronoun()
    {
        Console.Clear();
        Console.WriteLine("Type your Pronouns Mr press 1, Mrs press 2 ,Miss press 3");
        string pronoun = Console.ReadLine();
        if (pronoun == "1" )
        {
            return "Mr";
        }
        else if (pronoun == "2" )
        {
            return "Mrs";
        }
        else if (pronoun == "3" )
        {
            return "Miss";
        }
        return null;
    }
    static int Randompassword()
    {
        Random rnd = new Random();
        var serialnumber = rnd.Next(000000,1000000);
        return serialnumber;
    }
    static string InputName()
    {
        Console.Write("Type in Name : ");
        return Console.ReadLine();
    }
    static string InputSurName()
    {
        Console.Write("Type in SurName : ");
        return Console.ReadLine();
    }
    static string InputAge()
    {
        Console.Write("Type in Age : ");
        return Console.ReadLine(); 
    } 
    static string InputPosition()
    {
        Console.Write("Type in Position : ");
        return Console.ReadLine();
    }
    static string InputEmail()
    {
        Console.WriteLine("Input your Email");
        return Console.ReadLine();
    }
    static string InputPassword()
    {
        Console.WriteLine("Input your Password");
        return Console.ReadLine();
    }
    
}
