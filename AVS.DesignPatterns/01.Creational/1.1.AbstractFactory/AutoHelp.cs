using System;

namespace AVS.DesignPatterns.Creational.AbstractFactory
{
    // Client Class
    public class AutoHelp
    {
        private readonly Vehicle _vehicle;
        private readonly Winch _winch;

        public AutoHelp(AutoHelpFactory autoHelpFactory, Vehicle vehicle)
        {
            _vehicle = autoHelpFactory.CreateVehicle(vehicle.Model, vehicle.Gait);
            _winch = autoHelpFactory.CreateWinch();
        }

        public void MakeAttendance()
        {
            _winch.Help(_vehicle);
        }

        public static AutoHelp CreateAutoHelp(Vehicle vehicle)
        {
            switch (vehicle.Gait)
            {
                case Gait.SMALL:
                    return new AutoHelp(new HelpVehicleSmallFactory(), vehicle);
                case Gait.MIDDLE:
                    return new AutoHelp(new HelpVehicleMeddleFactory(), vehicle);
                case Gait.BIG:
                    return new AutoHelp(new HelpVehicleBigFactory(), vehicle);
                default:
                    throw new ApplicationException("Could not identify vehicle.");
            }
        }
    }
}
