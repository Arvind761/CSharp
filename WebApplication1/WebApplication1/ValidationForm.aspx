<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationForm.aspx.cs" Inherits="WebApplication1.ValidationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Student Registration Form

            </h1>
            <table>
                <tr>
                    <td>Student Name&nbsp;</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtName"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="Enter Your Name" ForeColor="Red" ID="reqName" ControlToValidate="txtName"></asp:RequiredFieldValidator>&nbsp;</td>
                </tr>
                <tr>
                    <td>Student Email&nbsp;</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="Enter Your Email" ControlToValidate="txtEmail" ForeColor="#FF3300"></asp:RequiredFieldValidator>&nbsp;</td>
                </tr>
                <tr>
                    <td>Student Re-Email&nbsp;</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtREmail"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="Re-Enter Your Email" ControlToValidate="txtREmail" ForeColor="Red"></asp:RequiredFieldValidator>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button runat="server" Text="Submit"></asp:Button>&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
