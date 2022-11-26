public class Vehicleinfo
{
    private string Model;
    private string Brand;
    private string Cartype;
    private int carvalue;

    public Vehicleinfo(string Model,string Brand,string Cartype,int carvalue)
    {
        this.Model = Model;
        this.Brand = Brand;
        this.Cartype = Cartype;
        this.carvalue = carvalue;
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