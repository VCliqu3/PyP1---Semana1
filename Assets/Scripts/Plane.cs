using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Vehicle
{
    protected float maxFlightHeight;

    public Plane(string _name, float speed, float maxFlightHeight)
    {
        this._name = _name;
        this.speed = speed;
        this.maxFlightHeight = maxFlightHeight;
    }
}
