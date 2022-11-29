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
        Console.WriteLine("Information of Every customer.");
        foreach (Customer customer in this.customerlist)
            {                  
            Console.WriteLine("--------------------------------------------------");   
            Console.WriteLine("Type Customer \n {0}.{1} {2} Age : {3} Years\n Number Car : {4} Brand : {5} Model : {6} Type : {7}"
            ,customer.Getpronound(),customer.GetName(),customer.Getsurname(),customer.Getage()
            ,customer.Getnumbercar(),customer.GetBrand(),customer.GetModel(),customer.GetCartype()); 
            Console.WriteLine("Return day : {0}",new DateTime(customer.GetDayreturn()));
            Console.WriteLine("Serialnumber :{0}",customer.Getserialnumber());
            Console.WriteLine("--------------------------------------------------");          
            }
        }
        public void SearchStatusYourBookCar(int code)
        {
            foreach (Customer customer in this.customerlist)
            { 
                if(code == customer.Getserialnumber())
                {
                    Console.WriteLine("--------------------------------------------------");   
                    Console.WriteLine("{0}.{1} {2} \n Model : {3} Type : {4}",
                    customer.Getpronound(),customer.GetName(),customer.Getsurname()
                    ,customer.GetModel(),customer.GetCartype());
                    Console.WriteLine("Your return day : {0}",new DateTime(customer.GetDayreturn()));
                    Console.WriteLine("Serialnumber : {0}",customer.Getserialnumber());
                    Console.WriteLine("--------------------------------------------------");   
                }
                else Console.WriteLine("Invalid code");
            }
        } 
    }

    
