﻿
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <meta name="viewport" content="width=device-width" />
    <title>LoginPIN</title>
</head>
<body class="container-fluid" style="text-align:center">
    <form action="@Url.Action("Menu", "Login")" method="post">
        <img src="" alt="" name="logo1"><br /><br />
        <h3>PIN:</h3>
        <input type="password" name="txtNIP" required><br />
        <button type="submit" name="btnEntrar">Entrar</button>
    </form>
    <div class="fixed-bottom">
        <a class="pull-right" href="@Url.Action("Index", "Login")"><button name="btnSalir">Salir</button></a>
    </div>
</body>
</html>