namespace AVS.DesignPatterns.Creational.AbstractFactory
{
    //Abstract Factory
    public abstract class AutoHelpFactory
    {
        public abstract Winch CreateWinch();
        public abstract Vehicle CreateVehicle(string model, Gait gait);
    }
}
