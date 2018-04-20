
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
    <title>Menu</title>
</head>
<body class="container-fluid">
    <div class="container-fluid" style="text-align:center">
        <div class="row" >
            
            <div class="col-sm-6">
                <a href="@Url.Action("Saldo", "Login")"><button name="btnSaldo">Saldo</button></a><br />   
            </div>
            <div class="col-sm-6">
                <a href="@Url.Action("Retiros", "Login")"><button name="btnRetiro">Retiro</button></a><br />
            </div>
            
        </div>
        <div class="row">
            <div class="col-sm-6">
                <a href="@Url.Action("Movimientos", "Login")"><button name="btnMovimientos">Movimientos</button></a><br />

            </div>
            <div class="col-sm-6">
                <a href="@Url.Action("Pagos", "Login")"><button name="btnPagos">Pagos</button></a><br />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <a href="@Url.Action("CambiarNIP", "Login")"><button name="btnCambiar">Cambiar NIP</button></a><br />

            </div>
            <div class="col-sm-6">
                <a href="@Url.Action("Usuario_Nuevo", "Login")"><button name="Agregar">Agregar Usuarios</button></a><br />
            </div>
        </div>
    </div>
    
    
    <div class="fixed-bottom">
        <a class="pull-right" href="@Url.Action("Index", "Login")"><button name="btnSalir">Salir</button></a>
    </div>
    
</body>
</html>
