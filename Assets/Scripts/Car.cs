using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    protected float horsePower;

    public Car(string _name, float speed, float horsePower) : base(_name, speed)
    {
        this.horsePower = horsePower;
    }

    public override void Accelerate()
    {
        Debug.Log("Car is accelerating");
    }

    public override float CalculateVehicleValue()
    {
        float value = speed * 75 + horsePower * 100;
        return value;
    }
}
