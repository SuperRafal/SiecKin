<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SiecKin.View.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>No to zaczynamy! :D</p><br />
    <asp:Button ID="Button1" runat="server" Text="Zrobimy na czas?" OnClick="Button1_Click" /><br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
