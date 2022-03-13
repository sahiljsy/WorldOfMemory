using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Uri http = new Uri("http://localhost:8000/UserService");
                ServiceHost host = new ServiceHost(typeof(Services.UserService), http);
                host.Open();
                Console.WriteLine("Published");
                Console.ReadLine();
                host.Close();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
