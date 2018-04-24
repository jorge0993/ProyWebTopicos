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
    <title>Pagos</title>
</head>
<body class="container-fluid">
    <div style="text-align:center">
        <img src="\Imagenes\bancp1.png" width="200" height="200" />
        <form style="margin-top:50px;margin-left:20%;margin-right:20%; margin-bottom:10% " class="form-horizontal" action="@Url.Action("RealizarPago", "Login")" method="post">
            <div class="form-group">
                <label for="servicio">Seleccione el servicio a pagar:</label>
                <select class="form-control" id="servicio" name="servicio">
                    <option value="" selected disabled>Seleccione una opcion</option>
                    <option value="Luz">Luz</option>
                    <option value="Agua">Agua</option>
                    <option value="Recarga Telcel">Recarga Telcel</option>
                    <option value="TV Cable">TV Cable</option>
                </select>
            </div>
            <div class="form-group">
                    <label for="cantidad">Ingresar cantidad a pagar</label>
                    <input type="text" class="form-control" id="cantidad" name="cantidad" placeholder="Cantidad a pagar">
            </div>
            <div class="form-group">
                <div class="">
                    <button type="submit" class="btn btn-success">Pagar</button>
                    <button type="reset" class="btn btn-warning">Cancelar</button>
                </div>
            </div>
        </form>
    </div>
    <div class="fixed-bottom">
        <button class="btn btn-default pull-right"  name="btnSalir"><a href="@Url.Action("Index", "Login")">Salir</a></button>
        <button class="btn btn-default pull-right"  name="btnSalir"><a href="@Url.Action("Menu", "Login")">Regresar</a></button>
    </div>
</body>
</html>