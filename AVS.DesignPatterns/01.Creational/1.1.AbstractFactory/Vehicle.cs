using System;

namespace AVS.DesignPatterns.Creational.AbstractFactory
{
    //Abstract Product
    public abstract class Vehicle
    {
        public Vehicle(string model, Gait gait)
        {
            Model = model;
            Gait = gait;
        }

        public string Model { get; }
        public Gait Gait { get; }
    }

    //Concrete Product
    public class SmallVehicle : Vehicle
    {
        public SmallVehicle(string model, Gait gait) : base(model, gait)
        {
        }
    }

    //Concrete Product
    public class MiddleVehicle : Vehicle
    {
        public MiddleVehicle(string model, Gait gait) : base(model, gait)
        {
        }
    }

    //Concrete Product
    public class BigVehicle : Vehicle
    {
        public BigVehicle(string model, Gait gait) : base(model, gait)
        {
        }
    }

    public class VehicleCreator
    {
        public static Vehicle Create(string model, Gait gait)
        {
            switch (gait)
            {
                case Gait.SMALL:
                    return new SmallVehicle(model, gait);
                case Gait.MIDDLE:
                    return new MiddleVehicle(model, gait);
                case Gait.BIG:
                    return new BigVehicle(model, gait);
                default:
                    throw new ApplicationException("Unknown vehicle size.");
            }
        }
    }}
