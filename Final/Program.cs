using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;   
using System.IO;
using System.Security.AccessControl;

namespace final;
    {
    class program
    {
        static void main(string[] args)
        {
        var builder = new ConfigurationBuilder()
        buildcondig(builder);

        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Build())
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .CreateLogger();

        log.logger.information("Application Starting");

        var host = host.Createdefaultbuilder()
            .ConfigureServise(builder.Services) =>
            {
                Servise.addtransient<greentingservise> ();

            })
            .useserilog()
            .Build();

        }

        static void buildconfig(IConfigurationBuilder builder
        }
    public class greentingservise
    {
        private readonly ILogger<greeentingservise> _log;
        private readonly IConfiguratio _config;
        
        public greentingservise(ILogger<greentingservise> log, IConfiguration config)
        {
            _log = log;
            _config = config;

        }

        public void run()
        {
            for (int i = 0; i < _config.gatvalue<int>("LoopTimes"); i++)
            {
                _log.loginformation("Run number { runumber }", i);
            }
            {


            }
        }
    }
    }