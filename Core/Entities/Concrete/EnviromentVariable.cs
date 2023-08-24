using System;

namespace Core.Entities.Concrete
{
    public static class EnviromentVariable
    {
        
        public static string DatabaseHostName { get; set; } = Environment.GetEnvironmentVariable("DATABASE_HOSTNAME");

    }
}
