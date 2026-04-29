<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Respuesta.aspx.cs" Inherits="Respuesta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 70px;
        }
        #TextArea2 {
            height: 77px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Usuario: "></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="Label3"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Comentario: "></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="Label4"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Edad en meses: "></asp:Label>
            <asp:Label ID="Label6" runat="server" Text="Label6"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
