<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestDotNetFrameWork.Default" %>

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
                    <td>Server :</td>
                    <td>
                        <asp:TextBox runat="server" ID="TebDataSource"  /></td>
                </tr>
                <tr>
                    <td>User Name :</td>
                    <td>
                        <asp:TextBox runat="server" ID="TebUserID" /></td>
                </tr>
                <tr>
                    <td>Password :</td>
                    <td>
                        <asp:TextBox runat="server" ID="TebPassword"  /></td>
                </tr>
                <tr>
                    <td>Data Base :</td>
                    <td>
                        <asp:TextBox runat="server" ID="TebInitialCatalog" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button runat="server" ID="ButTest" Text="Test Connection" OnClick="ButTest_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="LabMessage" runat="server" />
                    </td>
                </tr>
            </table>


        </div>
    </form>
</body>
</html>
