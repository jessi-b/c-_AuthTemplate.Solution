using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ProjectName {
  class Program {    public static void Main(string[] args) {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();
      host.Run();
    }
  }
}