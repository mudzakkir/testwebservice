using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;

namespace FirstWebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class MyService
    {
        // Takes 2 int values & returns their summation  
        [WebMethod]
        public int SumOfNums(int First, int Second)
        {
            return First + Second;
        }

        // Takes a stringified JSON object & returns an object of SumClass  
        [WebMethod(MessageName = "GetSumThroughObject")]
        public SumClass SumOfNums(string JsonStr)
        {
            var ObjSerializer = new JavaScriptSerializer();
            var ObjSumClass = ObjSerializer.Deserialize<SumClass>(JsonStr);
            return new SumClass().GetSumClass(ObjSumClass.First, ObjSumClass.Second);
        }
    }

    // Normal class, an instance of which will be returned by service  
    public class SumClass
    {
        public int First, Second, Sum;

        public SumClass GetSumClass(int Num1, int Num2)
        {
            var ObjSum = new SumClass
            {
                Sum = Num1 + Num2,
            };
            return ObjSum;
        }
    }
}