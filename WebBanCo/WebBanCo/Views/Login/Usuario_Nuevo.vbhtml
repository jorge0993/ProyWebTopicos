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
    <title>Index</title>
</head>
<body class="container">
    <div class="container">
        <div class="row bg-faded">
            <div class="col-4 mx-auto text-center">
                <img src="\Imagenes\bancp1.png" width="170" height="170" />
            </div>
        </div>
    </div>
    <div style="text-align:center; margin-top:40px; width:250px; " class="container">
        <h2>Agregar Usuarios</h2><br />

        <form action="@Url.Action("Usuario", "Login")" method="post" id="formu">
            <label>Numero de tarjeta:</label><br />
            <input class="form-control" type="text" name="numero_tarjeta" value="" /><br /><br />
            <label>PIN:</label><br />
            <input class="form-control" type="password" name="pin" value="" /><br /><br />
            <label>Nombres: </label><br />
            <input class="form-control" type="text" name="nombres" value="" /><br /><br />
            <label>Apellidos:</label><br />
            <input class="form-control" type="text" name="apellidos" value="" /><br /><br />
            <label>Direccion: </label><br />
            <input class="form-control" type="text" name="direccion" value="" /><br /><br />
            @*<label>Saldo:</label><br />
                <input type="number" name="saldo" value="" /><br /><br />*@
            <label>Fecha de alta: </label><br />
            <input type="date" name="fecha_alta" value="" /><br /><br />
            <label>Tipo:</label><br />
            <select name="tipo_usuario">
                <option value="0">Admin</option>
                <option value="1">Cliente</option>
            </select><br /><br />
            <button type="submit" name="guardar" class="btn btn-info">Guardar</button>
        </form>
    </div>
    <div class="fixed-bottom">
        <a class="pull-right" href="@Url.Action("Index", "Login")"><button name="btnSalir" class="btn btn-outline-secondary btn-lg" style="margin-bottom:15px; margin-right:20px">Salir</button></a>
        <a class="pull-left" href="@Url.Action("Menu", "Login")"><button name="btnSalir" class="btn btn-outline-secondary btn-lg" style="margin-bottom:15px; margin-left:20px">Regresar</button></a>
    </div>
    <style>
        .pull-left {
            bottom: 20px;
        }

        .btn {
            margin: 5px;
            width: 120px;
            height: 50px;
            font-size: 15px;
        }

        #formu {
        }
    </style>
</body>
</html>