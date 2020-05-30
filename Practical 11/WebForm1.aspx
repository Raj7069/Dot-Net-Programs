<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical_11.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="Orange">
    <form id="form1" runat="server">
        <div>
            You can enable and disable this textbox:
            <asp:TextBox ID="txtEnableDisable" runat="server"></asp:TextBox>
            <br /><br/>
            <asp:Button ID="btnEnableDisable" runat="server" OnClick="btnEnableDisable_Click" Text="Enable/Disable" />
            <br /><br />
            <asp:TextBox ID="TextBox1" runat="server" Width="117px"></asp:TextBox>
            <asp:Button ID="btnChangeWidth" runat="server" OnClick="btnChangeWidth_Click" Text="Change Width" />
        </div>
    </form>
</body>
</html>
