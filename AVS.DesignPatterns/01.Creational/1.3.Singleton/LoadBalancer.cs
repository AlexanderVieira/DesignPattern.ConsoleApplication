using System;
using System.Collections.Generic;

namespace AVS.DesignPatterns.Creational.Singleton
{
    internal sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instance = new LoadBalancer();

        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        public Server NextServer {
            get {
                var rnd = _random.Next(_servers.Count);
                return _servers[rnd];
            }
        }

        public LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{Id = Guid.NewGuid(), Name = "Server01", IP = "192.168.110.10"},
                new Server{Id = Guid.NewGuid(), Name = "Server02", IP = "192.168.110.11"},
                new Server{Id = Guid.NewGuid(), Name = "Server03", IP = "192.168.110.12"},
                new Server{Id = Guid.NewGuid(), Name = "Server04", IP = "192.168.110.13"},
                new Server{Id = Guid.NewGuid(), Name = "Server05", IP = "192.168.110.14"}
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

    }
}
