<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="LoginUH.menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/menucss.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>MENU PRINCIPAL</h1>

            <nav>
                <a href="#">inicio</a>
                <a href="estudiantes.aspx">Estudiantes</a>
                <a href="profesores.aspx">Profesores</a>
                <a href="https://uh.ac.cr/">UH</a>
                <a href="#">Contactos</a>
                <div class="animation start-home"></div>
            </nav>

            <p>
                <asp:Label ID="lusuario" runat="server"></asp:Label>
            </p>

        </div>
    </form>
</body>
</html>
