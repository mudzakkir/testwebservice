using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace FirstWebService
{
    /// <summary>
    /// Summary description for MyWebServiceDemo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class MyWebServiceDemo : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int SumOfNums(int First, int Second) {
            return First + Second;
        }

        [WebMethod(MessageName="SumOfFloats")]
        public float SumOfNums(float First, float Second) {
            return First + Second;
        }
    }
}
