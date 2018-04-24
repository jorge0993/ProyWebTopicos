@ModelType WebBanCo.Usuario

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <!-- jQuery library -->
    <!--<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>-->
    <!-- Latest compiled JavaScript -->
    <!-- <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script> -->


    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.0/umd/popper.min.js" integrity="sha384-cs/chFZiN24E4KMATLdqdvsezGxaGsi4hLGOzlXwp5UZB1LY//20VyM2taTB4QvJ" crossorigin="anonymous"></script>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" integrity="sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4" crossorigin="anonymous">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/js/bootstrap.min.js" integrity="sha384-uefMccjFJAIv6A+rW+L4AHf99KvxDjWSu1z9VI8SKNVmz4sk7buKt/6v9KI65qnm" crossorigin="anonymous"></script>
    <meta name="viewport" content="width=device-width" />
    <title>Usuario</title>
</head>
<body class="container-fluid">
    <div style="text-align:center">
        <h1>Agregado con exito!</h1><br />
        <br />

        <h3>Datos del usuario:</h3><br />
        <form style="margin-top:50px;margin-left:20%;margin-right:20%; margin-bottom:10% " class="form-horizontal">
            <div class="form-group">
                <label>Numero de tarjeta: @Model.numero_tarjeta</label><br />
                <label>Nombres: @Model.nombres</label><br />
                <label>Apellidos: @Model.apellidos</label><br />
                <label>Direccion: @Model.direccion</label><br />
                <label>Saldo: @Model.saldo</label><br />
                <label>Fecha de alta: @Model.fecha_alta</label><br />
            </div>
</form>
    </div>
    <div class="fixed-bottom">
        <a class="pull-right btn btn-default" href="@Url.Action("Index", "Login")"><button name="btnSalir">Salir</button></a>
        <a class="pull-right btn btn-default" href="@Url.Action("Menu", "Login")"><button name="btnSalir">Regresar</button></a>
    </div>
</body>
</html>