using System;
using Grpc.Core;
using MagicOnion.Server;

namespace grpc_magic_onion_server
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GrpcEnvironment.SetLogger(new Grpc.Core.Logging.ConsoleLogger());
            var service = MagicOnionEngine.BuildServerServiceDefinition(true);
            var server = new Server
            {
                Services = { service },
                Ports = { new ServerPort("localhost", 12345, ServerCredentials.Insecure) }
            };
            server.Start();
            Console.ReadLine();
        }
    }
}