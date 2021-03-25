using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TeamThree.Models;

namespace TeamThree
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            App app = new App();
            
            app.Run();
        }
    }
}