using SMI_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SMI_Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(StudentService);
            Uri http = new Uri("http://localhost:9000/StudentService");
            ServiceHost host = new ServiceHost(t, http);
            host.Open();
            Console.WriteLine("server is running");
            Console.ReadLine();
            host.Close();
        }
    }
}
