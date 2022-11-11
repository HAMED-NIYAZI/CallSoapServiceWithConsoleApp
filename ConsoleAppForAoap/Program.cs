using ConsoleAppForAoap.ServiceReferenceadd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForAoap
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Send();
        }




        public static void Send()
        {
 
            //parameters
            ServiceReferenceBANADER.ApiServiceParameterModel[] pmodel =
                {
          //  new ServiceReferenceBANADER.ApiServiceParameterModel() { ParameterName = "cUserName", ParameterValue = "nodak" },
           // new ServiceReferenceBANADER.ApiServiceParameterModel() { ParameterName = "cPassword", ParameterValue = "N0d@k123" },
            new ServiceReferenceBANADER.ApiServiceParameterModel() { ParameterName = "cBody", ParameterValue = "Hello world" },
            new ServiceReferenceBANADER.ApiServiceParameterModel() { ParameterName = "cSmsnumber", ParameterValue = "09120171198" } };

            //credential
            var myCredential =  new ServiceReferenceBANADER.CallerCredential();
            myCredential.Code = "nodak";
            myCredential.Password = "N0d@k123";



            var model = new ServiceReferenceBANADER.ApiRequestModel();
            model.Parameters = pmodel;
            model.Service = "mehrafzar-smssend";
            model.Credential = myCredential;


            var s =new ServiceReferenceBANADER.MassanSoapServiceProviderClient();
            try
            {
           s.Invoke(model);
                

            }
            catch (Exception ex)
            {

                throw;
            }


      

            

        }

 



    }
 
}
