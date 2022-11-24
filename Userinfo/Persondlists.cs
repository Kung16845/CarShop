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