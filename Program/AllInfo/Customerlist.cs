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
        Console.WriteLine("Information of Everyone");
        foreach (Customer customer in this.customerlist)
            {                  
            Console.WriteLine("Type Customer \n {0}{1} {2} Age : {3} Years\n Number Car : {4} Brand : {5} Model : {6} Type : {7}"
            ,customer.Getpronound(),customer.GetName(),customer.Getsurname(),customer.Getage()
            ,customer.Getnumbercar(),customer.GetBrand(),customer.GetModel(),customer.GetCartype());           
            }
        }
        public void SearchStatusYourBookCar(string name)
        {
            foreach (Customer customer in this.customerlist)
            { 
                if(name == customer.GetName())
                {
                    Console.WriteLine("{0}{1} {2} \n Model : {3} Type : {4}",
                    customer.Getpronound(),customer.GetName(),customer.Getsurname()
                    ,customer.GetModel(),customer.GetCartype());
                }
            }
        } 
    }
    
