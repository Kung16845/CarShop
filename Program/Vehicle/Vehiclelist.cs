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
}