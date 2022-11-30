
public class Worker : Person
{
    private string Position;
    private string email;
    private string password;
    public Worker(string pronound,string name,string surname,string age,string Position,string email,string password) :base(pronound,name,surname,age)
    {
        this.Position = Position;
        this.email = email;
        this.password = password;
    }
    public string GetPosition()
    {
        return this.Position;
    }
    public string GetEmail()
    {
        return this.email;
    }
    public string Getpassword()
    {
        return this.password;
    }
}