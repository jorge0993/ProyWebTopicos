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
    <title>Retiros</title>
</head>
<body class="container-fluid">
    <form action="">
        <button name="btn50">$50</button><br />
        <button name="btn100">$100</button><br />
        <button name="btn500">$500</button><br />
        <button name="btn1000">$1000</button><br />
        <button name="btn2000">$2000</button><br />
        <button name="btnOtraCantidad">Otra Cantidad</button>
    </form>
    <div class="fixed-bottom ">
        <a class="pull-right" href="@Url.Action("Menu", "Login")"><button name="btnSalir">Regresar</button></a>
        <a class="pull-right" href="@Url.Action("Index", "Login")"><button name="btnSalir">Salir</button></a>
    </div>
</body>
</html>