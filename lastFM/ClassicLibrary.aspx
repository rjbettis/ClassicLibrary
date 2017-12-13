<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClassicLibrary.aspx.cs" Inherits="lastFM.ClassicLibrary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label21" runat="server" Font-Names="Arial" Text="Last.fm Username"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Font-Names="Arial" OnClick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label19" runat="server" Font-Names="Arial"></asp:Label>
&nbsp;<asp:Label ID="Label20" runat="server" Font-Names="Arial"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;<br />
        <br />
        <asp:Image ID="Image1" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image2" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image3" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image4" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image5" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image6" runat="server" />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Image ID="Image7" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image8" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image9" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image10" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image11" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image12" runat="server" />
        <br />
        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Image ID="Image13" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image14" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image15" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image16" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image17" runat="server" />
&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image18" runat="server" />
        <br />
        <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="prevButton" runat="server" Font-Names="Arial" OnClick="prevButton_Click"></asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="nextButton" runat="server" Font-Names="Arial" OnClick="nextButton_Click"></asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
