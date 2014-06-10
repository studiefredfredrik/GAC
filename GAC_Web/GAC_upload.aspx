<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GAC_upload.aspx.cs" Inherits="Swish1o.WebForm2" %>
<%@ Register assembly="Brettle.Web.NeatUpload" namespace="Brettle.Web.NeatUpload" tagprefix="Upload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <ajaxToolkit:ToolkitScriptManager runat="server" />
     <ajaxToolkit:AjaxFileUpload
        ID="AjaxFileUpload1"
        OnUploadComplete="AjaxFileUpload1_UploadComplete"
        runat="server" />
</asp:Content>




