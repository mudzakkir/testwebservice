<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestConsume.aspx.cs" Inherits="FirstWebService.TestConsume" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    <asp:ScriptManager ID="ScriptManager1" runat="server">  
         <Services>  
              <asp:ServiceReference Path="http://localhost/WebServiceForBlog/MyService.asmx"/>  
          </Services>  
    </asp:ScriptManager>  
    <div>
    <table>  
    <tr>  
        <td>First Number:</td>  
        <td><input type="text" id="txtFirstNum" runat="server" /></td>  
    </tr>  
    <tr>  
        <td>Second Number:</td>  
        <td><input type="text" id="txtSecondNum" runat="server" /></td>  
    </tr>  
    <tr>  
        <td><input id="Button1" type="button" onserverclick="AddNumber" value="Add" runat="server" /></td>  
        <td><div id="divSum" runat="server"></div>  
        <div id="divSumThroughJson" runat="server"></div></td>  
    </tr>  
</table> 
    </div>
    </form>
</body>
</html>
