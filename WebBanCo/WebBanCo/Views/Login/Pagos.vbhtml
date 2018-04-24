@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.0/umd/popper.min.js" integrity="sha384-cs/chFZiN24E4KMATLdqdvsezGxaGsi4hLGOzlXwp5UZB1LY//20VyM2taTB4QvJ" crossorigin="anonymous"></script>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" integrity="sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4" crossorigin="anonymous">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/js/bootstrap.min.js" integrity="sha384-uefMccjFJAIv6A+rW+L4AHf99KvxDjWSu1z9VI8SKNVmz4sk7buKt/6v9KI65qnm" crossorigin="anonymous"></script>
    <meta name="viewport" content="width=device-width" />
    <title>Pagos</title>
</head>
<body class="">
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
        <a class="pull-right" href="@Url.Action("Index", "Login")"><button name="btnSalir" class="btn btn-outline-secondary btn-lg" style="margin-bottom:15px; margin-right:20px">Salir</button></a>
        <a class="pull-left" href="@Url.Action("Menu", "Login")"><button name="btnSalir" class="btn btn-outline-secondary btn-lg" style="margin-bottom:15px; margin-left:20px">Regresar</button></a>
    </div>

    <style>
        label{
            font-size:14px;
        }
        .form-control{
            height:40px;
            font-size12px;
        }
        #servicio{
            height:40px;
            font-size12px;
        }
        .pull-left {
            bottom: 20px;
        }
        .btn{
            margin: 5px;
            width: 120px;
            height: 50px;
            font-size: 15px;
        }
    </style>
</body>
</html>