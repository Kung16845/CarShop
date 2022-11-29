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
        Console.WriteLine("Welcome To Car Rental Office");
        Console.WriteLine(" 1 : MenuLogin \n 2 : MenuListCar \n 3 : Rent Status" );
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
        Console.Write("Please Input Your Name :");
        customerlist.SearchStatusYourBookCar(Console.ReadLine());
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
            Customer customer = new Customer(InputPronoun(),InputName(),InputSurName(),InputAge(),
            "000001","Fortuner","Toyota","SUV",5000);
            customerlist.Addnewcustomer(customer);
            Console.WriteLine("Recived Order!!!");           
        }
        else if (numbercar == 2)
        {
            Customer customer = new Customer(InputPronoun(),InputName(),InputSurName(),InputAge(),
            "000002","Pajero Sports","Mitsubishi","SUV",5000);
            customerlist.Addnewcustomer(customer);
            Console.WriteLine("Recived Order!!!");            
        }
        else if (numbercar == 3)
        {
            Customer customer = new Customer(InputPronoun(),InputName(),InputSurName(),InputAge(),
            "000003","City 1.5","Honda","SUV",5000);
            customerlist.Addnewcustomer(customer);
            Console.WriteLine("Recived Order!!!");          
        }
        else if (numbercar == 4)
        {
            Customer customer = new Customer(InputPronoun(),InputName(),InputSurName(),InputAge(),
            "000004","Almera 1.2","Nissan","SUV",5000);
            customerlist.Addnewcustomer(customer);
            Console.WriteLine("Recived Order!!!"); 
        }
        else if (numbercar == 5)
        {
            Customer customer = new Customer(InputPronoun(),InputName(),InputSurName(),InputAge(),
            "000005","Mu-X","ISUZU ","SUV",5000);
            customerlist.Addnewcustomer(customer);
            Console.WriteLine("Recived Order!!!");      
        } // เลือกรถจอง 
        MenuCar();
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
            OutputDataCustomerAdmin();
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
        persondlist.AddNewPerson(new Worker(InputPronoun(),InputName(),InputSurName(),InputAge(),InputPosition()));     
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
        MenuCar();
    }
    static string InputPronoun()
    {
        Console.WriteLine("Type in Pronouns is Mr press 1, Mrs press 2 ,Miss press 3");
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
