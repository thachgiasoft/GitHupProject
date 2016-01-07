<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="AnnounceList.aspx.cs" Inherits="WebApplication1.Users.AnnounceList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <ul>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li><a href='Atricle.aspx?id=<%#Eval("Id") %>'>
                    <%#Eval("Title")%></a>
                    <p style="float: right;">
                        <%#Eval("AddTime")%></p>
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</asp:Content>
