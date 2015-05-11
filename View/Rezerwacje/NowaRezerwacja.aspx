<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeBehind="NowaRezerwacja.aspx.cs" Inherits="SiecKin.View.Rezerwacje.NowaRezerwacja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p><asp:Label ID="Label1" runat="server" Text="Wybierz kino"></asp:Label></p>
    <p><asp:Label ID="Label2" runat="server" Text="Miasto:"></asp:Label>
    <asp:DropDownList ID="DropDownListMiasta" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListMiasta_SelectedIndexChanged" BackColor="#F6F1DB" ForeColor="#7d6754" Font-Names="Andalus" CssClass="ddl">
    </asp:DropDownList></p>
    <p><asp:Label ID="Label3" runat="server" Text="Kino:"></asp:Label>
    <asp:DropDownList ID="DropDownListKina" runat="server" BackColor="#F6F1DB" ForeColor="#7d6754" Font-Names="Andalus" CssClass="ddl">
    </asp:DropDownList></p>
    <asp:PlaceHolder ID="PlaceHolderDaty" runat="server" >
        <asp:Button ID="Button2" runat="server" Text=""  OnClick="DataClick" BackColor="#F6F1DB" ForeColor="#7d6754" Font-Names="Andalus" CssClass="ddl"/>       
        <asp:Button ID="Button3" runat="server" Text="Button" OnClick="DataClick" BackColor="#F6F1DB" ForeColor="#7d6754" Font-Names="Andalus" CssClass="ddl"/>
        <asp:Button ID="Button4" runat="server" Text="Button" OnClick="DataClick" BackColor="#F6F1DB" ForeColor="#7d6754" Font-Names="Andalus" CssClass="ddl"/>
        <asp:Button ID="Button5" runat="server" Text="Button" OnClick="DataClick" BackColor="#F6F1DB" ForeColor="#7d6754" Font-Names="Andalus" CssClass="ddl"/>
        <asp:Button ID="Button6" runat="server" Text="Button" OnClick="DataClick" BackColor="#F6F1DB" ForeColor="#7d6754" Font-Names="Andalus" CssClass="ddl"/>
        <asp:Button ID="Button7" runat="server" Text="Button" OnClick="DataClick" BackColor="#F6F1DB" ForeColor="#7d6754" Font-Names="Andalus" CssClass="ddl"/>
        <asp:Button ID="Button8" runat="server" Text="Button" OnClick="DataClick" BackColor="#F6F1DB" ForeColor="#7d6754" Font-Names="Andalus" CssClass="ddl"/>
    </asp:PlaceHolder>
    <br />
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    <br />
    <asp:PlaceHolder ID="PlaceHolderSeanse" runat="server"></asp:PlaceHolder>
    <br />
    <p>
        <asp:Button ID="ButtonDalej" runat="server" Text="Dalej" OnClick="ButtonDalej_Click" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" AutoPostBack ="True" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        
    
            
        </asp:GridView>
    </p>
</asp:Content>
