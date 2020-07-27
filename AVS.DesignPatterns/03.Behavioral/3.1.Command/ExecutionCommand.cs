using System;

namespace AVS.DesignPatterns.Behavioral.Command
{
    public class ExecutionCommand
    {
        public static void Run()
        {
            var appUser = new AppUser();

            appUser.Add('+', 1000);
            Console.ReadKey();

            appUser.Add('-', 100);
            Console.ReadKey();

            appUser.Add('*', 10);
            Console.ReadKey();

            appUser.Add('/', 2);
            Console.ReadKey();

            appUser.UnMake(4);
            Console.ReadKey();

            appUser.Return(3);
        }
    }
}
