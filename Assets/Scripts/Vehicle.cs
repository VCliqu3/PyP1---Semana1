using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle 
{
    protected string _name;
    protected float speed;

    public Vehicle(string _name, float speed)
    {
        this._name = _name;
        this.speed = speed;
    }

    public virtual void Accelerate()
    {
        Debug.Log("Vehicle is accelerating");
    }

    public virtual float CalculateVehicleValue()
    {
        float value = speed * 100;
        return speed;
    }
}
