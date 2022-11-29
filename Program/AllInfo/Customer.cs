public class Customer: Person
{
    private string numbercar;
    private string Model;
    private string Brand;
    private string Cartype;
    private int carvalue;
    private long dayreturn;
    private int serialnumber;


    public Customer(string pronound,string name,string surname,string age,string numbercar,string Model,
    string Brand,string Cartype,int carvalue,long dayreturn,int serialnumber) 
    :base(pronound,name,surname,age)
    {
        this.numbercar = numbercar;
        this.Model = Model;
        this.Brand = Brand;
        this.Cartype = Cartype;
        this.carvalue = carvalue;
        this.dayreturn = dayreturn;
        this.serialnumber = serialnumber;
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
    public long GetDayreturn()
    {
        return this.dayreturn;
    }
     public int Getserialnumber()
    {
        return this.serialnumber;
    }

}