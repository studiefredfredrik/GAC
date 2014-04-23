<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GAC_media.aspx.cs" Inherits="Swish1o.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    Files / folders on LANRW:<br />
    <asp:ListBox ID="ListBox1" runat="server" Height="111px"  Width="390px">
    </asp:ListBox>
    <asp:Button ID="btnOpen" runat="server" onclick="btnOpen_Click" Text="Open" />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Vol+" 
        Width="53px" />
&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Vol-" 
        Width="60px" />
&nbsp;&nbsp;
    <asp:Button ID="btnMute" runat="server" Text="Mute" Width="67px" />
&nbsp;&nbsp;
    <asp:Button ID="btnPause" runat="server" onclick="btnPause_Click" 
        Text="Pause" />
&nbsp;&nbsp;
    <asp:Button ID="btnClose" runat="server" onclick="btnClose_Click" 
        Text="Close" />
&nbsp;&nbsp;&nbsp; 
</asp:Content>
