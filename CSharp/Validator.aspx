<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Validator.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>INSERT YOUR DETAILS :</h3>
            <p>Name :&nbsp;&nbsp;
                <asp:TextBox ID="textname" runat="server"></asp:TextBox>
            &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Name" ControlToValidate="textname" ForeColor="Red">*</asp:RequiredFieldValidator>
            </p>
            <p>Family Name :&nbsp;&nbsp;
                <asp:TextBox ID="textfamname" runat="server"></asp:TextBox>
            &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="textfamname" ErrorMessage="Enter Family Name" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="textname" ControlToValidate="textfamname" ErrorMessage="Name and Family Name cannot be same." ForeColor="Red" Operator="NotEqual">*</asp:CompareValidator>
            </p>
            <p>Address :&nbsp;&nbsp;
                <asp:TextBox ID="textaddress" runat="server"></asp:TextBox>
            &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="textaddress" ErrorMessage="Enter Address" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="textaddress" ErrorMessage="Must be of 2 character" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate1">*</asp:CustomValidator>
&nbsp;&nbsp;
            </p>
            <p>City :&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="textcity" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="textcity" ErrorMessage="Enter City" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;
            </p>
            <p>Zip Code :&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="textpin" runat="server" TextMode="Number"></asp:TextBox>
            &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="textpin" ErrorMessage="Enter Zip Code" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;
            </p>
            <p>Phone :&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="textphone" runat="server" TextMode="Phone"></asp:TextBox>
            &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="textphone" ErrorMessage="Enter Phone" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="textphone" ErrorMessage="Invalid format" ForeColor="Red" ValidationExpression="[0-9]{10}">*</asp:RegularExpressionValidator>
            </p>
            <p>Email :&nbsp;
                <asp:TextBox ID="textmail" runat="server" AutoPostBack="True" TextMode="Email"></asp:TextBox>
&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="textmail" ErrorMessage="Enter Email" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="textmail" ErrorMessage="Invalid Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Check" />
            </p>
            <p>&nbsp;</p>

        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </form>
</body>
</html>
