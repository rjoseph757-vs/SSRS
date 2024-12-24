<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportRunner.aspx.cs" Inherits="MyHybridSite.Admin.ReportRunner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" ProcessingMode="Remote" Width="100%" Height="100%" SizeToReportContent="True" ZoomMode="FullPage">
        <ServerReport ReportServerUrl="" ReportPath="" />
    </rsweb:ReportViewer>
</asp:Content>
