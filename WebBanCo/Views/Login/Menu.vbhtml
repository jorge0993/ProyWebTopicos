
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
    <title>Menu</title>
</head>

<body class="container-fluid">
    <div class="container-fluid" style="text-align:center">
        <div class="row rowMargin mh1" >
            

            <div class="col-sm-4 ">
                <a href="@Url.Action("Saldo", "Login")"><button name="btnSaldo" class="btn btn-outline-primary btn-lg">Saldo</button></a><br />   
            </div>
            <div class="col-sm-4">
                <img src="~/Views/Imagenes/bancp1.png" />
            </div>
            <div class="h-25 col-sm-4 ">
                <a href="@Url.Action("Retiros", "Login")"><button name="btnRetiro" class="btn btn-outline-primary btn-lg">Retiro</button></a><br />
            </div>
            
        </div>
        <div class="row rowMargin mh1">
            <div class="col-sm-4">
                <a href="@Url.Action("Movimientos", "Login")"><button name="btnMovimientos" class="btn btn-outline-primary btn-lg">Movimientos</button></a><br />
            </div>
            <div class="col-sm-4 offset-md-4">
                <a href="@Url.Action("Pagos", "Login")"><button name="btnPagos" class="btn btn-outline-primary btn-lg">Pagos</button></a><br />
            </div>
        </div>
        <div class="row rowMargin mh1">
            <div class="col-sm-4 ">
                <a href="@Url.Action("CambiarNIP", "Login")"><button name="btnCambiar" class="btn btn-outline-primary btn-lg">Cambiar NIP</button></a><br />

            </div>
            <div class="col-sm-4 offset-md-4">
                <a href="@Url.Action("Usuario_Nuevo", "Login")"><button name="Agregar" class="btn btn-outline-primary btn-lg">Agregar Usuarios</button></a><br />
            </div>
        </div>
    </div>
    
    
    <div class="fixed-bottom" style="position:absolute; bottom:30px; right:25px;">
        <a class="pull-right" href="@Url.Action("Index", "Login")"><button name="btnSalir" class="btn btn-outline-secondary btn-lg">Salir</button></a>
    </div>
    

    <style>
        .mh1 {
            padding-top:5%;
            margin-top: 10%; 
            margin-bottom: 10%;
        }

        .center{
            vertical-align: central;
        }

        .btn{
            width: 120px;
        }

        .image{
            display:none;
        }
    </style>
</body>
</html>
