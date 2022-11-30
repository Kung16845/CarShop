using System.Collections.Generic;
using System;
    public class Customerlist
    {
        public List<Customer>customerlist;

        public Customerlist()
        {
            this.customerlist = new List<Customer>();
        }
        public void Addnewcustomer(Customer customer)
        {
            this.customerlist.Add(customer);
        }
        public void ShowCustomerclass()
        {
        string check = "Noinfoinsystem";
        foreach (Customer customer in this.customerlist)
            {                  
            Console.WriteLine("--------------------------------------------------");   
            Console.WriteLine("Type Customer \n {0}.{1} {2} Age : {3} Years\n Number Car : {4} Brand : {5} Model : {6} Type : {7}"
            ,customer.Getpronound(),customer.GetName(),customer.Getsurname(),customer.Getage()
            ,customer.Getnumbercar(),customer.GetBrand(),customer.GetModel(),customer.GetCartype()); 
            Console.WriteLine(" Return day : {0}",new DateTime(customer.GetDayreturn()));
            Console.WriteLine(" Serialnumber :{0}",customer.Getserialnumber());
            Console.WriteLine("--------------------------------------------------");         
            check = "Infoadded"; 
            }
            if(check == "Noinfoinsystem")
            {
                Console.WriteLine("There is no info in systems");
            }
        }
        public void SearchStatusYourBookCar(int code)
        {
            string check = "Noinfoinsystem";
            foreach (Customer customer in this.customerlist)
            { 
                if(code == customer.Getserialnumber())
                {
                    Console.WriteLine("--------------------------------------------------");   
                    Console.WriteLine("{0}.{1} {2} \n Model : {3} Type : {4}",
                    customer.Getpronound(),customer.GetName(),customer.Getsurname()
                    ,customer.GetModel(),customer.GetCartype());
                    Console.WriteLine(" Your return day : {0}",new DateTime(customer.GetDayreturn()));
                    Console.WriteLine(" Serialnumber : {0}",customer.Getserialnumber());
                    Console.WriteLine("--------------------------------------------------");   
                    check = "Infoadded";
                }
                else 
                {
                    check = "invalid";
                }
            }
            if(check == "Noinfoinsystem")
            {
                Console.WriteLine("There is no info in systems");
            }
            else if(check == "invalid"){Console.WriteLine("Invalid code");}
        } 
    }

    
