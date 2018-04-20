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
    <title>Index</title>
</head>
<body class="container-fluid">
    <div style="text-align:center">
        <h1>Agregar Usuarios</h1><br />
        <br />
        <h3>Datos del usuario:</h3><br />
        <form action="@Url.Action("Usuario", "Login")" method="post">
            <label>Numero de tarjeta:</label><br />
            <input type="text" name="numero_tarjeta" value="" /><br /><br />
            <label>PIN:</label><br />
            <input type="password" name="pin" value="" /><br /><br />
            <label>Nombres: </label><br />
            <input type="text" name="nombres" value="" /><br /><br />
            <label>Apellidos:</label><br />
            <input type="text" name="apellidos" value="" /><br /><br />
            <label>Direccion: </label><br />
            <input type="text" name="direccion" value="" /><br /><br />
            <label>Saldo:</label><br />
            <input type="number" name="saldo" value="" /><br /><br />
            <label>Fecha de alta: </label><br />
            <input type="date" name="fecha_alta" value="" /><br /><br />
            <label>Tipo:</label><br />
            <select>
                <option value="0">Admin</option>
                <option value="1">Cliente</option>
            </select><br /><br />
            <button type="submit" name="guardar">Guardar</button>
        </form>
    </div>
    <div class="fixed-bottom">
        <a class="pull-right" href="@Url.Action("Menu", "Login")"><button name="btnSalir">Regresar</button></a>
        <a class="pull-right" href="@Url.Action("Index", "Login")"><button name="btnSalir">Salir</button></a>
    </div>
</body>
</html>