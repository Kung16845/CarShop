class Customer: Person
{
    private string customer;

    public Customer(string pronound,string name,string surname,string age,string customer) :base(pronound,name,surname,age)
    {
        this.customer = customer;
    }
    public string Getcustomer()
    {
        return this.customer;
    }
}