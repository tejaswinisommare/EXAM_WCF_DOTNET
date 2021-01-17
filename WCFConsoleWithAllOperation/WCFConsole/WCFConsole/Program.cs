using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace WCFConsole
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string Hello();

        [OperationContract]
        string abc(int a);

        [OperationContract(IsOneWay = true)]
        //[OperationContract]
        void Hello2();


    }
    public class HelloService : IService
    {
        public string abc(int a)
        {
            if(a==3)
            {
                return "successfull";
            }
            else
            {
                return "failed";
            }
            
        }
        #region IService Members
        public string Hello()
        {
            return "Hello World";
        }

        public void Hello2()
        {
            Console.WriteLine("Hello2 called");
            System.Threading.Thread.Sleep(5000);
        }

        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost host = new ServiceHost(typeof(HelloService));

            /*ServiceHost host = new ServiceHost(typeof(HelloService), new Uri("http://localhost:8000/HelloService"));*/
            /*   //base address -> http://localhost:8000/HelloService

              host.AddServiceEndpoint(typeof(IService), new BasicHttpBinding(), "");
              //endpoint address -> Base Address + EndPoint Address
              //http://localhost:8000/HelloService

              ServiceMetadataBehavior behaviour = new ServiceMetadataBehavior();
              behaviour.HttpGetEnabled = true;

              host.Description.Behaviors.Add(behaviour);

              host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
              //http://localhost:8000/HelloService/mex*/

            host.Open();
            Console.WriteLine("service running...");
            Console.ReadLine();
            host.Close();
        }
    }
}
