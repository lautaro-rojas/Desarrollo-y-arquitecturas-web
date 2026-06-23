<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p class="lead">Giraldes - TP 5</p>
        <p class="lead">
            <asp:Label ID="Label1" runat="server" Text="Apellido"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtApe" runat="server"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Label ID="Label2" runat="server" Text="Cuota"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtCuota" runat="server"></asp:TextBox>
        </p>
        <p class="lead">&nbsp;&nbsp;
            <asp:RadioButton ID="rbBecado" runat="server" Text="Becado" GroupName="persona"/>
        </p>
        <p class="lead">&nbsp;&nbsp;
            <asp:RadioButton ID="rbArancelado" runat="server" Text="Arancelado" GroupName="persona" />
        </p>
        <p class="lead">
            <asp:DropDownList ID="DDListLenguaje" runat="server" Width="161px">
                <asp:ListItem Value="1">C#</asp:ListItem>
                <asp:ListItem Value="2">Python</asp:ListItem>
                <asp:ListItem Value="3">Java</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p class="lead">
            <asp:CheckBox ID="chLunes" runat="server" Text="Lunes" />
        </p>
        <p class="lead">
            <asp:CheckBox ID="chMiercoles" runat="server" Text="Miércoles" />
        </p>
        <p class="lead">
            <asp:CheckBox ID="chViernes" runat="server" Text="Viernes" />
        </p>
        <p class="lead">
            <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
        </p>
    </div>

    </asp:Content>
