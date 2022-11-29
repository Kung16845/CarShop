public class Person
{
    private string pronound;
    private string name;
    private string surname;
    private string age;

    public Person(string pronound,string name,string surname,string age)
    {
        this.pronound = pronound;
        this.name = name;
        this.surname = surname;
        this.age = age;
    }
    public string GetName()
    {
        return this.name;
    }
    public string Getsurname()
    {
        return this.surname;
    }
    public string Getage()
    {
        return this.age;
    }
    public string Getpronound()
    {
        return this.pronound;
    }
   
}