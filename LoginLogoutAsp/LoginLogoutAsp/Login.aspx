<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginLogoutAsp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <table>
                <tr>
                    <td>User Name&nbsp;</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtUser"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="Enter Your Name" ControlToValidate="txtUser" ForeColor="Red"></asp:RequiredFieldValidator>&nbsp;</td>
                </tr>
                <tr>
                    <td>Password&nbsp;</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtPass"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="Enter Password" ControlToValidate="txtPass" ForeColor="Red"></asp:RequiredFieldValidator>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button runat="server" Text="Login" ID="btnLogin" OnClick="btnLogin_Click"></asp:Button>&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
