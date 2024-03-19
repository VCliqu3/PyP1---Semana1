using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Vehicle
{
    protected float maxFlightHeight;

    public Plane(string _name, float speed, float maxFlightHeight) : base(_name, speed)
    {
        this.maxFlightHeight = maxFlightHeight;
    }

    protected override void Accelerate()
    {
        Debug.Log("Plane is accelerating");
    }
}
