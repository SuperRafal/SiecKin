<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeBehind="WyborMiejsca.aspx.cs" Inherits="SiecKin.View.Rezerwacje.WyborMiejsca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p><asp:Label ID="Label3" runat="server" Text="Wybierz miejsce"></asp:Label></p>
    <asp:PlaceHolder ID="PlaceHolderSala" runat="server"></asp:PlaceHolder>
    <br />
    <p>
        <asp:Button ID="Button1" runat="server" Text="" Height="25px" Width="25px" />
        <asp:Label ID="Label4" runat="server" Text="Zajęte miejsce"></asp:Label><br />
        <asp:Button ID="Button2" runat="server" Text="" Height="25px" Width="25px"/>
        <asp:Label ID="Label5" runat="server" Text="Wolne miejsce"></asp:Label><br />
        <asp:Button ID="Button3" runat="server" Text="" Height="25px" Width="25px" />
        <asp:Label ID="Label6" runat="server" Text="Wybrane miejsce"></asp:Label><br />
    </p>
    <asp:Button ID="ButtonDalej" runat="server" Text="Dalej" /><br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</asp:Content>
