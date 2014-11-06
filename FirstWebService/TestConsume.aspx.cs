using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
namespace FirstWebService
{
    public partial class TestConsume : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddNumber(object Sender, EventArgs E)
        {
            int Num1, Num2;
            int.TryParse(txtFirstNum.Value, out Num1);
            int.TryParse(txtSecondNum.Value, out Num2);

            // creating object of MyService proxy class  
            var ObjMyService = new ServiceReferenceMyService.MyServiceSoapClient();

            // Invoke service method through service proxy  
            divSum.InnerHtml = ObjMyService.SumOfNums(Num1, Num2).ToString();

            var ObjSumClass = new SumClass { First = Num1, Second = Num2 };
            var ObjSerializer = new JavaScriptSerializer();
            var JsonStr = ObjSerializer.Serialize(ObjSumClass);
            divSumThroughJson.InnerHtml = new ServiceReferenceMyService.MyServiceSoapClient().SumOfNums1(JsonStr).Sum.ToString();  
       
        }   
    }
}