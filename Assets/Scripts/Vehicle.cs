using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle 
{
    protected string _name;
    protected float speed;

    protected virtual void Accelerate()
    {
        Debug.Log("Vehicle is accelerating");
    }
}
