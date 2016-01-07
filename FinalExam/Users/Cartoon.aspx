<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true"
    CodeBehind="Cartoon.aspx.cs" Inherits="WebApplication1.Users.Cartoon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <table border="0" cellpadding="0" cellspacing="0">
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <img src='<%#Eval("CartoonImage")%>' alt="Alternate Text" />
                    </br>
                    <h3>
                        <a href='CatroonSon.aspx?id=<%#Eval("Id")%>'>
                            <%#Eval("CartoonName")%></a></h3>
                    </br>
                    <p>
                        <%#Eval("CartoonIntroduce")%></p>
                        </br> </br> </br>
                        <hr/>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
