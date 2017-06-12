using Autofac;
using Autofac.Features.Metadata;
using System;

namespace IOC
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            
            builder.RegisterType<TodayWriter>().As<IDateWriter>().WithMetadata("Name", "2");
            builder.RegisterType<YesterdayWriter>().As<IDateWriter>().WithMetadata("Name", "1");
            builder.RegisterAdapter<Meta<IDateWriter>, IDateWriter>(
            cmd =>
            {
                var data = (string)cmd.Metadata["Name"];
                if (data == "1")
                {
                    return new TodayWriter(new ConsoleOutput());
                }
                else
                {
                    return new YesterdayWriter(new ConsoleOutput());
                }
            });

            Container = builder.Build();

            // The WriteDate method is where we'll make use
            // of our dependency injection. We'll define that
            // in a bit.
            WriteDate();
        }

        public static void WriteDate()
        {
            // Create the scope, resolve your IDateWriter,
            // use it, then dispose of the scope.
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDateWriter>();
                writer.WriteDate();
            }
        }
    }
}