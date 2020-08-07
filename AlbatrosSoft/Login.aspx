<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AlbatrosSoft.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="/Content/css/jQueryUICSS/redmond/jquery-ui-1.10.3.custom.css" rel="stylesheet" type="text/css" />
    <link href="/Content/css/Login/LoginStyle.css" rel="stylesheet" type="text/css" />
    <script src="/Scripts/jquery-2.1.0.js" type="text/javascript"></script>
    <script src="/Scripts/jquery-ui-1.10.4.js" type="text/javascript"></script>
    <script src="/Scripts/Login/LoginFunctions.js" type="text/javascript"></script>
</head>
<body class="body">
    <form id="form1" runat="server">
        <table align="center" class="mainTable">
            <tr>
                <td>
                    <div class="divCenter">
                        <table align="center">
                            <tr>
                                <td align="center">
                                    <br>
                                    <span class="lblUser">Ingreso de Usuario</span>
                                </td>
                            </tr>
                        </table>
                        <table align="center">
                            <tr>
                                <td style="text-align: center">
                                    <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/Login/imgColor.png"
                                        Style="text-align: right; height: 15pt; vertical-align: middle" />
                                    <asp:Image ID="imgError" runat="server" ImageUrl="~/Images/Login/imgMessage.png"
                                        Style="text-align: right; height: 20pt; vertical-align: middle" Visible="false" />
                                    <asp:Label ID="Label1" runat="server" CssClass="lblMessage" Text="" Visible="True"></asp:Label>
                                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Login/imgColor.png"
                                        Style="text-align: right; height: 15pt; vertical-align: middle" />
                                </td>
                            </tr>
                        </table>
                        <table align="center">
                            <tr>
                                <td>
                                    <span class="label">Usuario:</span><br />
                                    <asp:TextBox ID="Username" runat="server" CssClass="textBox" Rows="2" ValidationGroup="loginGroup" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="lblMessage"
                                        ControlToValidate="Username" Display="Dynamic" ValidationGroup="loginGroup"
                                        Enabled="true" SetFocusOnError="true" ErrorMessage="* Campo requerido" />
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr>
                                <td>
                                    <span class="label">Contraseña:</span><br />
                                    <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="textBox" ValidationGroup="loginGroup" />
                                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" CssClass="lblMessage"
                                        ControlToValidate="Password" Display="Dynamic" ValidationGroup="loginGroup"
                                        Enabled="true" SetFocusOnError="true" ErrorMessage="* Campo requerido" />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <br />
                                    <asp:LinkButton ID="lnkUser" runat="server" Text="" CssClass="linkButoon" OnClientClick="javascript:return rowAction(this.name);">¿Olvidó su <strong>contraseña</strong>?</asp:LinkButton>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <br />
                                    <asp:Button ID="btnLogin" runat="server" Text=" " ValidationGroup="loginGroup" CssClass="button" OnClick="btnLogin_Click" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="divFooter">
                        <table>
                            <tr>
                                <td></td>
                                <td></td>
                                <td>
                                    <br />
                                    <img alt="" src="Images/Login/azureLogo.png" height="25pt" />
                                </td>
                                <td style="text-align: right">
                                    <br />
                                    <span class="lblCopyrightWizenz">©<% =GetTime()%> albatrosSoft Technologies</span>
                                </td>
                                <td></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                          
                            <tr>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td colspan="2" style="padding-right: 50px; padding-left: 50px; text-align: center">
                                    <span class="lblCopyrightAzure">La marca Powered By Windows Azure es una marca 
                                    registrada de Microsoft Corporation en los Estados Unidos y otros países, y es 
                                    usada bajo licencia de Microsoft. </span>
                                </td>
                                <td></td>
                                <td></td>
                            </tr>
                        </table>
                    </div>
                    <div id="dialog" title="Autenticación de usuario">
                        <p>
                            Estimado usuario, favor contactar al departamento de soporte técnico de AlbatrosSoft:
                            <br />
                            E-mail:<asp:LinkButton ID="LinkButton1" runat="server" Text="" CssClass="linkDialog"> info@albatrosSoft.com</asp:LinkButton>
                            <br />
                            Tel: +57 1 779 87 53
                        </p>
                    </div>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>