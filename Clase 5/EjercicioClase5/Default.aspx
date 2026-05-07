<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EjercicioClase5._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Ejercicio clase 5</h1>
            <h2 id="aspnetTitle2">Cálculo de un presupuesto de viaje</h2>
            <h3 id="aspnetTitle3">Destino</h3>
            <div>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
                    <asp:ListItem Selected="True">Mar del plata</asp:ListItem>
                    <asp:ListItem>Niza</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <p>&nbsp;</p>
            <h3 id="aspnetTitle4">Categoría</h3>
            <div>
                <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True">
                    <asp:ListItem Selected="True">3 estrellas</asp:ListItem>
                    <asp:ListItem>4 estrellas</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <p>&nbsp;</p>
            <h3 id="aspnetTitle5">Cantidad de días</h3>
            <div>
                <asp:TextBox ID="TextBox_CantDias" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox_CantDias" ErrorMessage="Días es requerido"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox_CantDias" ErrorMessage="Los días deben ser mayor 0 y menor 16" MaximumValue="16" MinimumValue="0" Type="Integer"></asp:RangeValidator>
            </div>
            <p>&nbsp;</p>
            <h3 id="aspnetTitle6">Cantidad de personas</h3>
            <div>
                <asp:TextBox ID="TextBox_CantPers" runat="server"></asp:TextBox>
            </div>
            <p>&nbsp;</p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" />
            </p>
        </section>

    </main>

</asp:Content>
