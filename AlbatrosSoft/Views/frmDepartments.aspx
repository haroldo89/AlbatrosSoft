<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmDepartments.aspx.cs" Inherits="AlbatrosSoft.Views.frmDepartments" %>

<%-- Linea para llamar el AjaxControlToolKit --%>
<%@ OutputCache Location="None" VaryByParam="None" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="act" %>

<%-- Content Estilos de La Pagina --%>
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


<asp:Content ID="Content2" ContentPlaceHolderID="contentArea" runat="server">
    
    <%-- Encabezado --%>
    <div id="spinner" style="width: 100%">
    </div>


     <%-- Script Manager Rendering --%>
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true" SupportsPartialRendering="true"
        EnableScriptGlobalization="true" EnablePartialRendering="true">
    </asp:ScriptManager>

    <%-- ------------------------------------------------------------------------------------------------------- --%>

        <%-- Div General Contiene Formulario y la Grilla --%>
    <div class="divContents" id="divGeneral" style="width: 100%;">
        <%-- Update panel, para que no se refresque la pagina cuando se realize algunaa accion --%>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <h2>Administracion de Registros de Departamentos</h2>
                <table>
                    <tr>
                        <td>
                            <%-- Etiquetas y Captura de Datos --%>
                            <table>
                                <tr>
                                    <td>
                                        <h4>Descripcion <span>:</span></h4>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtDescriptionName" runat="server" Width="100pt" CssClass="txtSearch" ClientIDMode="Static" MaxLength="50"></asp:TextBox>
                                        <br />
                                        <%--<asp:RequiredFieldValidator SetFocusOnError="true" ValidationGroup="vbtnSave" ControlToValidate="txtCodeType" Display="Dynamic"
                                            ID="rfvtxtCodeNumber" runat="server" ErrorMessage="Editar Valor">Campo Requerido</asp:RequiredFieldValidator>--%>
                                    </td>
                                   
                                </tr>
                               
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                </table>
                <%-- Botones para Acciones de Manejo de Registros --%>
                <table>
                    <tr>
                        <td style="vertical-align: middle">
                            <asp:Button ID="btnSearch" runat="server" CssClass="button" Text="Buscar ..." ClientIDMode="Static" />
                            <asp:Button ID="btnSave" ValidationGroup="vbtnSave" Text="Guardar" OnClientClick=" return CreateConfirm('txtCustomerDocument','vbtnSave');"
                                runat="server" CssClass="button" CausesValidation="true" ClientIDMode="Static" OnClick="btnSave_Click" />
                            <asp:Button ID="btnNew" runat="server" CssClass="button" Text="Nuevo" ClientIDMode="Static" />
                            <asp:Button ID="btnNewSearch" runat="server" CssClass="button" Text="Nueva Busqueda" ClientIDMode="Static" />
                            <asp:Button ID="btnDelete" runat="server" Text="Eliminar" CssClass="button" ClientIDMode="Static"
                                OnClientClick=" return CreateConfirmDel('txtCustomerDocument','Esta seguro de eliminar el tipo de mantenimiento ');" />
                        </td>
                    </tr>

                    <%-- Errores y progreso --%>
                    <tr>
                        <td>
                            <%-- Update progess --%>
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

                <%-- Vista y seleccion de registros de la grilla --%>
                <div>
                    <center>

                    <%--Grilla Con Registros del Fromulario--%>
                    <asp:GridView ID="grvDepartment" runat="server" CssClass="grid" AutoGenerateColumns="false"
                        Width="70%" AllowSorting="True" AllowPaging="True" SelectedIndex="0" PageSize="20" 
                        OnRowCommand="grvDepartment_RowCommand" >
                        <%-- Estilos para la grilla --%>
                        <AlternatingRowStyle CssClass="xDataRowAlternative" />
                        <RowStyle CssClass="xDataRow" />
                        <SelectedRowStyle CssClass="xDataRowSelected" />
                        <HeaderStyle CssClass="xHeader" />

                        <%-- Columnas Puestas Manualmente --%>
                        <Columns>
                            <asp:TemplateField HeaderText="Identificacion" SortExpression="IdDepartment">
                                <ItemStyle Width="25%" />
                                <ItemTemplate>
                                    <asp:LinkButton Text='<%# Eval("DepartmentId") %>' ID="lnkEditar" runat="server" CommandName="editar"
                                        CommandArgument='<%# Eval("DepartmentId") %>' />
                                    <asp:HiddenField ID="hfRowkey" runat="server" Value='<%#Eval("DepartmentId") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%-- Columnas Puestas Manualmente --%>
                            <asp:BoundField DataField="Description" HeaderText="Descripcion" SortExpression="DepartmentDescription" />
                           
                          
                        </Columns>

                    </asp:GridView>
                </center>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

    <%-- ------------------------------------------------------------------------------------------------------- --%>

    
   <%-- <%-- Grilla que Contiene los Registros 
    <asp:GridView ID="grvDepartment" runat="server" CssClass="grid" AutoGenerateColumns="true"
        Width="70%" AllowSorting="True" AllowPaging="True" SelectedIndex="0" PageSize="20" >
        <AlternatingRowStyle CssClass="xDataRowAlternative" />
        <RowStyle CssClass="xDataRow" />
        <SelectedRowStyle CssClass="xDataRowSelected" />
        <HeaderStyle CssClass="xHeader" />
    </asp:GridView>--%>


</asp:Content>
