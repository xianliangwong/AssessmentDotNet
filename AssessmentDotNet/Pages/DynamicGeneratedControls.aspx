<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicGeneratedControls.aspx.cs" Inherits="AssessmentDotNet.Pages.DynamicGeneratedControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="dynamicControls" runat="server">
        <div>
            <asp:DropDownList ID="ddlControlType" runat="server">
                <asp:ListItem Text="TextBox" Value="TextBox"></asp:ListItem>
                <asp:ListItem Text="CheckBox" Value="CheckBox"></asp:ListItem>
                <asp:ListItem Text="Button" Value="Button"></asp:ListItem>
            </asp:DropDownList>

            <asp:TextBox ID="txtNumber" runat="server" placeholder="Enter number of controls"></asp:TextBox>
            <asp:Button ID="btnGenerate" runat="server" Text="Generate Controls" OnClick="btnGenerate_Click" />

            <hr />
            <asp:PlaceHolder ID="dynamicContentControls" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
