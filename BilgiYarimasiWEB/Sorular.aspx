<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Sorular.aspx.cs" Inherits="BilgiYarimasiWEB.ListUye" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
            <ItemTemplate>
                <table class="nav-justified">
                    <tr>
                        <td>
                            <asp:Label ID="Label9" runat="server" Text="Dogru :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label11" runat="server" Text='<%# Eval("true") %>'></asp:Label>
                            <asp:Label ID="LBLTrue" runat="server" Text="0"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label12" runat="server" Text="Yanlış :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label13" runat="server" Text='<%# Eval("false") %>'></asp:Label>
                            <asp:Label ID="LBLFalse" runat="server" Text="0"></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
&nbsp;<asp:DataList ID="DataList2" runat="server" Width="554px">
            <ItemTemplate>
                <table class="nav-justified">
                    <tr>
                        <td>
                            <asp:Label ID="QuestionText" runat="server" Text='<%# Eval("QuestionText") %>'/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                                    <asp:Button runat="server" Text='<%# Eval("OptionA") %>' OnClick="Button_Click" />

                        </td>
                    </tr>
                    <tr>
                        <td>
                                    <asp:Button runat="server"  Text='<%# Eval("OptionB")  %>' OnClick="Button_Click"/>

                         
                        </td>
                    </tr>
                    <tr>
                        <td>
                                    <asp:Button runat="server" Text='<%# Eval("OptionC") %>' OnClick="Button_Click"/>

                        
                        </td>
                    </tr>
                    <tr>
                        <td>
                                    <asp:Button runat="server" Text='<%# Eval("OptionD") %>' OnClick="Button_Click" />

                       
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </form>
</asp:Content>
