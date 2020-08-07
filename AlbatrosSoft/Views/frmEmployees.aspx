<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmEmployees.aspx.cs" Inherits="AlbatrosSoft.Views.frmEmployees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Content/css/AdminModule/SpreadSheet.css" rel="stylesheet" type="text/css" media="screen" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentArea" runat="server">
    <asp:GridView ID="grvEmployes" runat="server" CssClass="grid" AutoGenerateColumns="true"
        Width="70%" AllowSorting="True" AllowPaging="True" SelectedIndex="0" PageSize="20" >
        <AlternatingRowStyle CssClass="xDataRowAlternative" />
        <RowStyle CssClass="xDataRow" />
        <SelectedRowStyle CssClass="xDataRowSelected" />
        <HeaderStyle CssClass="xHeader" />
    </asp:GridView>
</asp:Content>
