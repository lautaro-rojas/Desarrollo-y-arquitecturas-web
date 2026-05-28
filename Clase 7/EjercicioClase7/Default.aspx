<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <h2>Elija un día</h2>
            <p>
                &nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="Lunes" />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Martes" />
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Miercoles" />
                <asp:CheckBox ID="CheckBox4" runat="server" Text="Jueves" />
                <asp:CheckBox ID="CheckBox5" runat="server" Text="Viernes" />
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enviar" />
            </p>
        </div>
    </div>
</asp:Content>
