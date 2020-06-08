using System.Collections.Generic;

namespace AVS.DesignPatterns.Creational.AbstractFactory
{
    public class ExecutionAbstractFactory
    {
        public static void Run()
        {
            var rescuedVehicles = new List<Vehicle>
            {
                VehicleCreator.Create("Onix", Gait.SMALL),
                VehicleCreator.Create("Cobalt", Gait.MIDDLE),
                VehicleCreator.Create("Hilux", Gait.BIG)
            };

            rescuedVehicles.ForEach(v => AutoHelp.CreateAutoHelp(v).MakeAttendance());
        }
    }
}
