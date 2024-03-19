using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    protected float horsePower;

    public Car(string _name, float speed, float horsePower)
    {
        this._name = _name;
        this.speed = speed;
        this.horsePower = horsePower;
    }

    protected override void Accelerate()
    {
        Debug.Log("Car is accelerating");
    }
}
