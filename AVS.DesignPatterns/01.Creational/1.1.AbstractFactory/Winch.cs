using System;

namespace AVS.DesignPatterns.Creational.AbstractFactory
{
    //Abstract Product
    public abstract class Winch
    {
        protected Winch(Gait gait)
        {
            Gait = gait;
        }
        public abstract void Help(Vehicle vehicle);
        public Gait Gait { get; set; }
    }

    //Concrete Product
    public class SmallWinch : Winch
    {
        public SmallWinch(Gait gait) : base(gait) { }

        public override void Help(Vehicle vehicle)
        {
            Console.WriteLine("Rescuing small vehicle. Model " + vehicle.Model);
        }
    }

    //Concrete Product
    public class MiddlelWinch : Winch
    {
        public MiddlelWinch(Gait gait) : base(gait) { }

        public override void Help(Vehicle vehicle)
        {
            Console.WriteLine("Rescuing middle vehicle. Model " + vehicle.Model);
        }
    }

    //Concrete Product
    public class BigWinch : Winch
    {
        public BigWinch(Gait gait) : base(gait) { }

        public override void Help(Vehicle vehicle)
        {
            Console.WriteLine("Rescuing big vehicle. Model " + vehicle.Model);
        }
    }

    public class WinchCreator
    {
        public static Winch Create(Gait gait)
        {
            switch (gait)
            {
                case Gait.SMALL:
                    return new SmallWinch(gait);
                case Gait.MIDDLE:
                    return new MiddlelWinch(gait);
                case Gait.BIG:
                    return new BigWinch(gait);
                default:
                    throw new ApplicationException("Unknown winch size.");
            }
        }
    }
}
