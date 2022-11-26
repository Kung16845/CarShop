using System.Collections.Generic;
using System;

public class Vehiclelist
{
    private List<Vehicleinfo>VehicleList;

    public VehicleList()
    {
        this.VehicleList = new List<Vehicleinfo>();
    }
    public void AddNewVehicle(Vehicleinfo vehicleinfo)
    {
        this.VehicleList.Add(vehicleinfo);
    }
}