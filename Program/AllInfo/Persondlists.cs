using System.Collections.Generic;
using System;

public class Persondlist
{
    private List<Person>personList;

    public Persondlist()
    {
        this.personList = new List<Person>();
    }
    public void AddNewPerson(Person person)
    {
        this.personList.Add(person);
    }

    public void Showworker()
        {
        Console.WriteLine("Information of Every customer.");
        foreach (Worker worker in this.personList)
        {
            Console.WriteLine("--------------------------------------------------");   
            Console.WriteLine("Type Worker \n {0}.{1} {2} Age : {3} Years Position : {4} "
            ,worker.Getpronound(),worker.GetName(),worker.Getsurname(),worker.Getage(),worker.GetPosition()); 
            Console.WriteLine("Email:{0} \nPasswrod: {1}",worker.GetEmail(),worker.Getpassword());
            Console.WriteLine("--------------------------------------------------");   
        }
        }

    public string checkname(string pronound,string name,string surname)
    {
        string checker = "0";
        string Pronounds = pronound;
        string Names = name;
        string Surnames = surname;
        foreach (Person persons in personList) 
        {
            if (Pronounds != persons.Getpronound() && Names != persons.GetName() && Surnames != persons.Getsurname()) 
            {
                return checker = "passed";
            }
        }
        foreach (Person persons in personList) 
        {
            if (Pronounds == persons.Getpronound() && Names == persons.GetName() && Surnames == persons.Getsurname())
            {
                return checker = "Alreadytaken";
            }
        }
        return checker;
    }
}