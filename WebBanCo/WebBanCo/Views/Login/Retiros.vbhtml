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
        <input type="button" class="btn btn-outline-primary btn-lg" value="$50" onclick="location.href='@Url.Action("Retiro", "Login", New With {.cantidad = "50"})'" />
        <input type="button" value="$100" onclick="location.href='@Url.Action("Retiro", "Login", New With {.cantidad = "100"})'" />
        <input type="button" value="$500" onclick="location.href='@Url.Action("Retiro", "Login", New With {.cantidad = "500"})'" />
        <input type="button" value="$1000" onclick="location.href='@Url.Action("Retiro", "Login", New With {.cantidad = "1000"})'" />
        <input type="button" value="$2000" onclick="location.href='@Url.Action("Retiro", "Login", New With {.cantidad = "2000"})'" />       
    </form>


    <div Class="fixed-bottom ">
        <a Class="pull-right" href="@Url.Action("Index", "Login")"><button name="btnSalir">Salir</button></a>
        <a Class="pull-right" href="@Url.Action("Menu", "Login")"><button name="btnSalir">Regresar</button></a>
    </div>
</body>
</html>