public class Customer: Person
{
    private string numbercar;
    private string Model;
    private string Brand;
    private string Cartype;
    private int carvalue;

    public Customer(string pronound,string name,string surname,string age,string numbercar,string Model,string Brand,string Cartype,int carvalue) 
    :base(pronound,name,surname,age)
    {
        this.numbercar = numbercar;
        this.Model = Model;
        this.Brand = Brand;
        this.Cartype = Cartype;
        this.carvalue = carvalue;
    }
    public string Getnumbercar()
    {
        return this.numbercar;
    }
    public string GetModel()
    {
        return this.Model;
    }
    public string GetBrand()
    {
        return this.Brand;
    }
    public string GetCartype()
    {
        return this.Cartype;
    }
    public int Getcarvalye()
    {
        return this.carvalue;
    }
}