namespace AVS.DesignPatterns.Creational.AbstractFactory
{
    // Concrete Factory
    public class HelpVehicleMeddleFactory : AutoHelpFactory
    {
        public override Vehicle CreateVehicle(string model, Gait gait)
        {
            return VehicleCreator.Create(model, gait);
        }

        public override Winch CreateWinch()
        {
            return WinchCreator.Create(Gait.MIDDLE);
        }
    }
}
