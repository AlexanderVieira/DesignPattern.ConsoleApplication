namespace AVS.DesignPatterns.Creational.AbstractFactory
{
    public class HelpVehicleSmallFactory : AutoHelpFactory
    {
        // Concrete Factory
        public override Vehicle CreateVehicle(string model, Gait gait)
        {
            return VehicleCreator.Create(model, gait);
        }

        public override Winch CreateWinch()
        {
            return WinchCreator.Create(Gait.SMALL);
        }
    }
}
