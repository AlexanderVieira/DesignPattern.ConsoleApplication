using AVS.DesignPatterns.Creational.MethodFactory;
using AVS.DesignPatterns.Creational.AbstractFactory;
using System;
using AVS.DesignPatterns.Creational.Singleton;
using AVS.DesignPatterns.Structural.Adapter;
using AVS.DesignPatterns._02.Structural._2._2.Facade;
using AVS.DesignPatterns.Structural.Composite;

namespace AVS.DesignPatterns
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Method Factory");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("------------------------");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("6 - Composite");
            Console.WriteLine("------------------------");

            var option = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            switch (option.KeyChar)
            {
                case '1':
                    ExecutionAbstractFactory.Run();
                    break;
                case '2':
                    ExecutionFactoryMethod.Run();
                    break;
                case '3':
                    ExecutionSingleton.Run();
                    break;
                case '4':
                    ExecutionAdapter.Run();
                    break;
                case '5':
                    ExecutionFacade.Run();
                    break;
                case '6':
                    ExecutionCompoiste.Run();
                    break;
                default:
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
