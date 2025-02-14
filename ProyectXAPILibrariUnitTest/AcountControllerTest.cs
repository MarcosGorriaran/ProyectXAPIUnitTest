using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectXAPI.Models;
using ProyectXAPILibrary.Controller;
using System;
using System.Net.Http;

namespace ProyectXAPILibrariUnitTest
{
    [TestClass]
    public class AcountControllerTest
    {
        const string APIAddress = "http://localhost:5000";
        [TestMethod]
        public void SuccesfulCheckLogin()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(APIAddress);
            AcountController controller = new AcountController(client);
            Acount acount = new Acount()
            {
                Username = "ME",
                Password = "ME"
            };

            controller.CheckLoginRequest(acount);
        }
    }
}
