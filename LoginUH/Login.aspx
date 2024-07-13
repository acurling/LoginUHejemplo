<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginUH.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
   
    <link href="css/logincss.css" rel="stylesheet" />
     <!-- Design by foolishdeveloper.com -->
  <title>Glassmorphism login Form Tutorial in html css</title>

  <link rel="preconnect" href="https://fonts.gstatic.com">
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css">
  <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;500;600&display=swap" rel="stylesheet">
</head>
<body>
     <div class="background">
    <div class="shape"></div>
    <div class="shape"></div>
  </div>
  <form id="form1" runat="server">
    <h3>Login Here</h3>

    <label for="username">Usuario</label>
     <asp:TextBox ID="tusuario" placeholder="Digit su correo" runat="server"></asp:TextBox>


    <label for="password">Clave</label>
      <asp:TextBox ID="tclave" placeholder="Digite su contraseña" type="password" runat="server"></asp:TextBox>

      <asp:Button ID="bingresar" class="button" OnClick="bingresar_Click" runat="server" Text="Ingresar" />
    
    <div class="social">
   <%--   <div class="go"><i class="fab fa-google"></i> Google</div>
      <div class="fb"><i class="fab fa-facebook"></i> Facebook</div>--%>
    </div>
  </form>
</body>
</html>
