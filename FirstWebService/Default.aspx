<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="FirstWebService._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Label ID="Label1" runat="server" Text="Random Number"></asp:Label>
    <asp:Label ID="lblRandom" runat="server" Text="0"></asp:Label>
    <asp:Button ID="Button1" runat="server" Text="Get" onclick="Button1_Click" />
</asp:Content>
