<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BilgiYarimasiWEB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sonuçlar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h2>Sonuçlar</h2>
        <p>Doğru Sayısı: <asp:Label ID="LBLTrueCount" runat="server" Text="0" /></p>
 
        </div>
        <p>Yanlış Sayısı: <asp:Label ID="LBLFalseCount" runat="server" Text="0" /></p>
 
        <asp:Button ID="Button1" runat="server" Text="Tekrar Dene" Width="98px" OnClick="Button1_Click" />
    </form>
</body>
</html>
