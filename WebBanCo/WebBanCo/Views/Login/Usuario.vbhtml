@ModelType WebBanCo.Usuario

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
    <title>Usuario</title>
</head>
<body class="container-fluid">
    <div style="text-align:center">
        <h1>Titulo</h1><br />
        <br />

        <h3>Datos del usuario:</h3><br />
        <form>
            <label>Numero de tarjeta: @Model.numero_tarjeta</label><br />
            <label>Nombres: @Model.nombres</label><br />
            <label>Apellidos: @Model.apellidos</label><br />
            <label>Direccion: @Model.direccion</label><br />
            <label>Saldo: @Model.saldo</label><br />
            <label>Fecha de alta: @Model.fecha_alta</label><br />
            <button type="button">Guardar</button>
        </form>
    </div>
    <div class="fixed-bottom">
        <a class="pull-right" href="@Url.Action("Menu", "Login")"><button name="btnSalir">Regresar</button></a>
        <a class="pull-right" href="@Url.Action("Index", "Login")"><button name="btnSalir">Salir</button></a>
    </div>
</body>
</html>
