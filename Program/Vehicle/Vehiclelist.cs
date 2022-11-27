using System.Collections.Generic;
using System;

public class Vehiclelist
{
    private List<Vehicleinfo>VehicleList;

    public Vehiclelist()
    {
        this.VehicleList = new List<Vehicleinfo>();
    }
    public void AddNewVehicle(Vehicleinfo vehicleinfo)
    {
        this.VehicleList.Add(vehicleinfo);
    }
    public void PrintInfoCar()
    {
        Console.WriteLine("Information of ALLCAR");
        int i = 1;
        foreach(Vehicleinfo car in this.VehicleList)
        {
             Console.WriteLine("Car number : {0} \n Brand : {1} \n Model : {2} \n Type : {3} \n Rent Price : {4} Baht per Day",i,car.GetBrand(),car.GetModel(),car.GetCartype(),car.Getcarvalye());
             Console.WriteLine("----------------------------------------");
             i++;
        }
    }
}

