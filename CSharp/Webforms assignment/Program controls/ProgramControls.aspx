<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProgramControls.aspx.cs" Inherits="ProgramControls.ProgramControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="33px" Width="212px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="Apple Ipad">Apple Ipad</asp:ListItem>
                <asp:ListItem Value="Apple Iphone">Apple Iphone</asp:ListItem>
                <asp:ListItem Value="Apple Macbook">Apple Macbook</asp:ListItem>
                <asp:ListItem Value="Apple Watch">Apple Watch</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Image ID="image" runat="server" Width="106px" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="mrp" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="See Price" OnClick="Button1_Click" />

    </form>
    </body>
</html>
