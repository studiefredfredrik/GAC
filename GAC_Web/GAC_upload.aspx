<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GAC_upload.aspx.cs" Inherits="Swish1o.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Font-Size="Large" 
        Text="Upload files to server:"></asp:Label>
    <br />
    <br />
    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" />
    </asp:Content>
