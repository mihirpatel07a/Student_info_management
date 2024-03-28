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
            Type t2 = typeof(BranchService);
            
            
            Uri http = new Uri("http://localhost:9000/SMI/StudentService");
            Uri http2 = new Uri("http://localhost:9000/SMI/BranchService");

            ServiceHost host = new ServiceHost(t, http );
            ServiceHost host2 = new ServiceHost(t2, http2);
            host.Open();
            host2.Open();
            Console.WriteLine("server is running");
            Console.ReadLine();
            host.Close();
            host2.Close();
        }
    }
}
