<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SiecKin.View.Registration.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
  <p><asp:Label ID="Label1" runat="server" Text="Uzupełnij dane: " Font-Bold="True" Font-Italic="False" Font-Size="X-Large"></asp:Label></p> 
  <p><asp:Label ID="Label2" runat="server" Text="Login:"></asp:Label>
      <asp:TextBox ID="TextBox1" runat="server" Height="20px"></asp:TextBox>
      </p>
    <p><asp:Label ID="Label5" runat="server" Text="Imię:"></asp:Label>
      <asp:TextBox ID="TextBox4" runat="server" Height="20px"></asp:TextBox>
      </p>
    <p><asp:Label ID="Label6" runat="server" Text="Nazwisko:"></asp:Label>
      <asp:TextBox ID="TextBox5" runat="server" Height="20px"></asp:TextBox>
      </p>
  <p><asp:Label ID="Label3" runat="server" Text="E-mail:"></asp:Label>
      <asp:TextBox ID="TextBox2" runat="server" TextMode="Email" Height="20px"></asp:TextBox>
      </p>
    <p><asp:Label ID="Label4" runat="server" Text="Hasło:"></asp:Label>
      <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Height="20px"></asp:TextBox>
      </p>
    <p><asp:Label ID="Label7" runat="server" Text="Regulamin:"></asp:Label>
       <asp:CheckBox ID="CheckBox1" runat="server" Text="Akceptuję" />
        
       </p>
   <p><asp:Button ID="Button1" runat="server" Text="Rejestruj" Height="30px" Width="118px" /></p> 
</asp:Content>
