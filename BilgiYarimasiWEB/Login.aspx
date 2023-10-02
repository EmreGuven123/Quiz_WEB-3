<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BilgiYarimasiWEB.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form id="form1" runat="server">
          <asp:TextBox ID="tboxName" runat="server"></asp:TextBox>
        <br />
        <br />
      <asp:TextBox ID="tboxSurname" runat="server"></asp:TextBox>

        <br />
        <br />
        <asp:Button ID="btnlogin" runat="server"  Text="Giriş Yap" Width="108px" OnClick="btnlogin_Click" />
    </form>

</asp:Content>
