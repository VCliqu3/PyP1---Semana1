using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleManager : MonoBehaviour
{
    [SerializeField] private Type type;
    [SerializeField] private string _name;
    [SerializeField] private float speed;

    private const float DEFAULT_HORSEPOWER = 300f;
    private const float DEFAULT_MAXHEIGHT = 1000f;

    private enum Type 
    {
        Car, 
        Plane
    }

    private Vehicle vehicle;

    private void Start()
    {
        ChooseVehicle();
        ShowVehicleValue();
    }

    private void ChooseVehicle()
    {
        switch (type)
        {
            case Type.Car:
                vehicle = new Car(_name, speed, DEFAULT_HORSEPOWER);
                break;
            case Type.Plane:
                vehicle = new Plane(_name, speed, DEFAULT_MAXHEIGHT);
                break;
        }
    }

    private void ShowVehicleValue()
    {
        float value = vehicle.CalculateVehicleValue();
        Debug.Log($"The vehicle {_name} has a value of ${value}");
    }
}
