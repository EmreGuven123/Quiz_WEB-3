<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="UyeKayit.aspx.cs" Inherits="BilgiYarimasiWEB.UyeKayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:TextBox ID="tboxName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="tboxSurname" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Kayıt ol" Width="108px" />
    </form>
</asp:Content>
