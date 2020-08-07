
<%-- Precedentes para Cargar la Pagina --%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCustomer.aspx.cs" Inherits="AlbatrosSoft.Views.frmCustomer" %>

<%-- Linea para llamar el AjaxControlToolKit --%>
<%@ OutputCache Location="None" VaryByParam="None" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="act" %>


<%-- Content, Carga de la Pagina, Hoja de Estilos  --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE9" xml:lang="es-us" />
    <link href="../Content/css/AdminModule/Default.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="../Content/css/AdminModule/SpreadSheet.css" rel="stylesheet" type="text/css" media="screen" />
    <script src="../Scripts/jquery-2.1.0.js" type="text/javascript"></script>
    <script src="../Scripts/jquery-ui-1.10.4.js" type="text/javascript"></script>
    <script type="text/javascript">
        //linea para llamar al procedimiento que hace la transicion al cargar la pagina
        $(window).load(function () { $("#spinner").fadeOut("slow"); })
    </script>
</asp:Content>
<%--  --%>


<asp:Content ID="Content2" ContentPlaceHolderID="contentArea" runat="server">
    
    <%-- Div Encabezado --%>
    <div id="spinner" style="width: 100%">
    </div>

    <%-- Script Manager Rendering --%>
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true" SupportsPartialRendering="true"
        EnableScriptGlobalization="true" EnablePartialRendering="true">
    </asp:ScriptManager>

    <%-- Div General Contiene Formulario y la Grilla --%>
    <div class="divContents" id="divGeneral" style="width: 100%;">
        <%-- Update panel, para q no se refresque la pagina cuando se realize algunaa accion --%>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <h2>Administracion de Tipos de Clientes</h2>
                <table>
                    <tr>
                        <td>
                            <table>
                                <tr>
                                    <td>
                                        <h4>Documento <span>:</span></h4>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtCustomerDocument" runat="server" Width="100pt" CssClass="txtSearch" ClientIDMode="Static" MaxLength="50"></asp:TextBox>
                                        <br />
                                        <act:FilteredTextBoxExtender runat="server" FilterType="Numbers" ID="ftbTxtCustomerDocument" TargetControlID="txtCustomerDocument"></act:FilteredTextBoxExtender>
                                        <%--<asp:RequiredFieldValidator SetFocusOnError="true" ValidationGroup="vbtnSave" ControlToValidate="txtMaintenanceTypeName"
                                            Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Editar Valor">Campo Requerido</asp:RequiredFieldValidator>--%>
                                    </td>
                                    <td>
                                        <h4>Nombre <span>:</span></h4>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtCustomerName" runat="server" Width="100pt" CssClass="txtSearch" ClientIDMode="Static" MaxLength="50"></asp:TextBox>
                                        <br />
                                        <%--<asp:RequiredFieldValidator SetFocusOnError="true" ValidationGroup="vbtnSave" ControlToValidate="txtCodeType" Display="Dynamic"
                                            ID="rfvtxtCodeNumber" runat="server" ErrorMessage="Editar Valor">Campo Requerido</asp:RequiredFieldValidator>--%>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <h4>Apellido <span>:</span></h4>
                                        <td>
                                            <asp:TextBox ID="txtCustomerLastName" runat="server" Width="100pt" CssClass="txtSearch" ClientIDMode="Static" MaxLength="50"></asp:TextBox>
                                            <br />
                                        </td>
                                        <td>
                                            <h4>Direccion <span>:</span></h4>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtCustomerAdress" runat="server" Width="100pt" CssClass="txtSearch" ClientIDMode="Static"></asp:TextBox>
                                            <br />
                                            <%--<act:FilteredTextBoxExtender runat="server" FilterType="Numbers" ID="ftbTxtQuantity" TargetControlID="txtQuantity"></act:FilteredTextBoxExtender>
                                            <asp:RequiredFieldValidator SetFocusOnError="true" ValidationGroup="vbtnSave" ControlToValidate="txtQuantity"
                                                Display="Dynamic" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Editar Valor">Campo Requerido</asp:RequiredFieldValidator>--%>
                                        </td>
                                        <td>
                                            <h4>Celular 1 <span>:</span></h4>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtCellPhone1" runat="server" Width="100pt" CssClass="txtSearch" ClientIDMode="Static"></asp:TextBox>
                                            <br />
                                            <%-- <act:FilteredTextBoxExtender runat="server" FilterType="Numbers" ID="FilteredTextBoxExtender2" TargetControlID="txtAlertLevel2"></act:FilteredTextBoxExtender>
                                            <asp:RequiredFieldValidator SetFocusOnError="true" ValidationGroup="vbtnSave" ControlToValidate="txtAlertLevel2" Display="Dynamic"
                                                ID="RequiredFieldValidator4" runat="server" ErrorMessage="Editar Valor">Campo Requerido</asp:RequiredFieldValidator>
                                            <asp:CompareValidator runat="server" ID="CompareValidator2" ValidationGroup="vbtnSave" Operator="LessThan" ControlToValidate="txtAlertLevel2" Display="Dynamic"
                                                ControlToCompare="txtAlertLevel1" Type="Integer" ErrorMessage="Valor de alerta 1 debe ser mayor a valor alerta 2"></asp:CompareValidator>--%>
                                        </td>
                                </tr>
                                <tr>
                                    <td>
                                        <h4>Telefono 1 <span>:</span></h4>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtTelephone1" runat="server" Width="100pt" CssClass="txtSearch" ClientIDMode="Static"></asp:TextBox>
                                        <br />
                                        <%--<act:FilteredTextBoxExtender runat="server" FilterType="Numbers" ID="ftbTxtAlertLevel1" TargetControlID="txtAlertLevel1"></act:FilteredTextBoxExtender>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ValidationGroup="vbtnSave" ControlToValidate="txtAlertLevel1" Display="Dynamic"
                                            ID="rfvTxtAlertLevel1" runat="server" ErrorMessage="Editar Valor">Campo Requerido</asp:RequiredFieldValidator>--%>
                                    </td>
                                    <td>
                                        <h4>Telefono 2 <span>:</span></h4>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtTelephone2" runat="server" Width="100pt" CssClass="txtSearch" ClientIDMode="Static"></asp:TextBox>
                                        <br />
                                        <%--<act:FilteredTextBoxExtender runat="server" FilterType="Numbers" ID="ftbTxtAlertLevel2" TargetControlID="txtAlertLevel2"></act:FilteredTextBoxExtender>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ValidationGroup="vbtnSave" ControlToValidate="txtAlertLevel2" Display="Dynamic"
                                            ID="rfvTxtAlertLevel2" runat="server" ErrorMessage="Editar Valor">Campo Requerido</asp:RequiredFieldValidator>
                                        <asp:CompareValidator runat="server" ID="cvtxtAlertLevel2" ValidationGroup="vbtnSave" Operator="LessThan" ControlToValidate="txtAlertLevel2" Display="Dynamic"
                                            ControlToCompare="txtAlertLevel1" Type="Integer" ErrorMessage="Valor de alerta 1 debe ser mayor a valor alerta 2"></asp:CompareValidator>--%>
                                    </td>
                                    <td>
                                        <h4>Celular 2 <span>:</span></h4>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtCellPhone2" runat="server" Width="100pt" CssClass="txtSearch" ClientIDMode="Static"></asp:TextBox>
                                        <br />
                                        <%--<act:FilteredTextBoxExtender runat="server" FilterType="Numbers" ID="FilteredTextBoxExtender1" TargetControlID="txtAlertLevel2"></act:FilteredTextBoxExtender>
                                        <asp:RequiredFieldValidator SetFocusOnError="true" ValidationGroup="vbtnSave" ControlToValidate="txtAlertLevel2" Display="Dynamic"
                                            ID="RequiredFieldValidator2" runat="server" ErrorMessage="Editar Valor">Campo Requerido</asp:RequiredFieldValidator>
                                        <asp:CompareValidator runat="server" ID="CompareValidator1" ValidationGroup="vbtnSave" Operator="LessThan" ControlToValidate="txtAlertLevel2" Display="Dynamic"
                                            ControlToCompare="txtAlertLevel1" Type="Integer" ErrorMessage="Valor de alerta 1 debe ser mayor a valor alerta 2"></asp:CompareValidator>--%>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                </table>
                <table>
                    <tr>
                        <td style="vertical-align: middle">
                            <asp:Button ID="btnSearch" runat="server" CssClass="button" Text="Buscar ..." ClientIDMode="Static" OnClick="btnSearch_Click" />
                            <asp:Button ID="btnSave" ValidationGroup="vbtnSave" Text="Guardar" OnClientClick=" return CreateConfirm('txtCustomerDocument','vbtnSave');"
                                runat="server" CssClass="button" CausesValidation="true" ClientIDMode="Static" OnClick="btnSave_Click" />
                            <asp:Button ID="btnNew" runat="server" CssClass="button" Text="Nuevo" ClientIDMode="Static" OnClick="btnNew_Click" />
                            <asp:Button ID="btnNewSearch" runat="server" CssClass="button" Text="Nueva Busqueda" ClientIDMode="Static" OnClick="btnNewSearch_Click" />
                            <asp:Button ID="btnDelete" runat="server" Text="Eliminar" CssClass="button" ClientIDMode="Static"
                                OnClientClick=" return CreateConfirmDel('txtCustomerDocument','Esta seguro de eliminar el cliente ');" OnClick="btnDelete_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblMessageError" runat="server" Text="" ClientIDMode="Static"></asp:Label>
                            <asp:UpdateProgress ID="UpProgres" runat="server" DynamicLayout="true">
                                <ProgressTemplate>
                                    <table cellpadding="0" cellspacing="0" border="0">
                                        <tr>
                                            <td>
                                                <asp:Image ID="ImgLoader" runat="server" ImageUrl="~/Images/ModAdmin/loader.gif" ImageAlign="AbsMiddle" Height="16" Style="margin-right: 4px" />
                                                <asp:Label ID="lblCargando" runat="server" Width="78px" Font-Size="8pt">Procesando...</asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                </table>
                <div>
                    <center>

                    <%--Grilla Con Registros del Fromulario--%>
                    <asp:GridView ID="grvCustomer" runat="server" CssClass="grid" AutoGenerateColumns="false"
                        Width="70%" AllowSorting="True" AllowPaging="True" SelectedIndex="0" PageSize="20" 
                        OnRowCommand="grvCustomer_RowCommand" OnPageIndexChanging="grvCustomer_PageIndexChanging" OnSorting="grvCustomer_Sorting"  >
                        <AlternatingRowStyle CssClass="xDataRowAlternative" />
                        <RowStyle CssClass="xDataRow" />
                        <SelectedRowStyle CssClass="xDataRowSelected" />
                        <HeaderStyle CssClass="xHeader" />
                        <%-- Columnas Puestas Manualmente --%>
                        <Columns>
                            <asp:TemplateField HeaderText="Documento" SortExpression="Document">
                                <ItemStyle Width="25%" />
                                <ItemTemplate>
                                    <asp:LinkButton Text='<%# Eval("Document") %>' ID="lnkEditar" runat="server" CommandName="editar"
                                        CommandArgument='<%# Eval("Document") %>' />
                                    <asp:HiddenField ID="hfRowkey" runat="server" Value='<%#Eval("Document") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%-- Columnas Puestas Manualmente --%>
                            <asp:BoundField DataField="Name" HeaderText="Nombre" SortExpression="NombreTipoMantenimiento" />
                            <asp:BoundField DataField="Lastname" HeaderText="Apellido" SortExpression="NombreFrecuencia" />
                            <asp:BoundField DataField="Address" HeaderText="Direccion" SortExpression="ValorFrecuencia" />
                            <asp:BoundField DataField="Telephone1" HeaderText="Telefono" SortExpression="ValorAlertaNivel1" />
                            <asp:BoundField DataField="Telephone2" HeaderText="Telefono" SortExpression="ValorAlertaNivel2" />
                            <asp:BoundField DataField="MobilePhone1" HeaderText="Celular 1" SortExpression="ValorAlertaNivel2" />
                            <asp:BoundField DataField="MobilePhone2" HeaderText="Celular 2" SortExpression="ValorAlertaNivel2" />
                        </Columns>
                    </asp:GridView>
                </center>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
<%--  --%>