﻿using Microsoft.Extensions.Configuration;

namespace CryptoNewBlazorWasm.Controller
{
    public class SecretReader
    {
        public T ReadSection<T>(string sectionName)
        {
            //var environment = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT");
            var builder = new ConfigurationBuilder()
                //.AddJsonFile("appsettings.json")
                //.AddJsonFile($"appsettings.{environment}.json", optional: true)
                .AddUserSecrets<Program>();
                //.AddEnvironmentVariables();
            var configurationRoot = builder.Build();

            return configurationRoot.GetSection(sectionName).Get<T>();
        }
    }
}
