<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GAC_upload.aspx.cs" Inherits="Swish1o.WebForm2" %>
<%@ Register assembly="Brettle.Web.NeatUpload" namespace="Brettle.Web.NeatUpload" tagprefix="Upload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Font-Size="Large" 
        Text="Upload file to server:"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblProgress" runat="server" Text="Select file:"></asp:Label>
    <br />
    <Upload:InputFile ID="InputFile1" runat="server" />
    <asp:Button ID="btnUpload" runat="server" onclick="btnUpload_Click" 
    Text="Upload" Height="22px" style="margin-top: 1px" Width="65px" />

    <Upload:ProgressBar id="UploadProgress" Url="~/NeatUpload/Progress.aspx" Triggers="btnUpload" Inline="true" runat="server" />
    
    </asp:Content>

