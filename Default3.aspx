<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
        div{
            text-align:center;
        }
    </style>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbluser" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="lblpass" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
       <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
