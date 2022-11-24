class Worker: Person
{
    private string Position;

    public Worker(string pronound,string name,string surname,string age,string Position) :base(pronound,name,surname,age)
    {
        this.Position = Position;
    }
    public string GetPosition()
    {
        return this.Position;
    }
}