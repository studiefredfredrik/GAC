<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Swish1o._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p>
        <asp:ImageButton ID="imgBtnSunny" runat="server" Height="80px" 
            ImageUrl="~/sunny.png" onclick="ImageButton1_Click" Width="500px" />
    </p>
<p>
        <asp:ImageButton ID="imgBtnMoony" runat="server" Height="80px" 
            ImageUrl="~/moony.png" onclick="ImageButton2_Click" Width="500px" />
    </p>
</asp:Content>
