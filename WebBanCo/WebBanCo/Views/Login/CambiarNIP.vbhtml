
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.0/umd/popper.min.js" integrity="sha384-cs/chFZiN24E4KMATLdqdvsezGxaGsi4hLGOzlXwp5UZB1LY//20VyM2taTB4QvJ" crossorigin="anonymous"></script>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" integrity="sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4" crossorigin="anonymous">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/js/bootstrap.min.js" integrity="sha384-uefMccjFJAIv6A+rW+L4AHf99KvxDjWSu1z9VI8SKNVmz4sk7buKt/6v9KI65qnm" crossorigin="anonymous"></script>
    
    <meta name="viewport" content="width=device-width" />
    <title>CambiarNIP</title>
</head>
<body class="container-fluid">
    <div style="text-align:center">
    </div>

    <div id="container" class="container">
        <div class="row">
            <div class="col-sm-10 offset-sm-1 text-center">
                <div class="info-form">
                    <form action="@Url.Action("CambiarNIP2", "Login")" method="post" class="form-inline justify-content-center">
                        <div class="form-group">
                            <label >PIN Actual:</label><br />
                            <input type="text" class="form-control" placeholder="NIP Actual" name="nipActual"><br />
                            <label >PIN Nuevo:</label><br />
                            <input type="text" class="form-control" placeholder="Nuevo NIP" name="nuevoNip"><br />
                            <label>Confirmar:</label><br />
                            <input type="text" class="form-control" placeholder="Nuevo NIP" name="confirmar"><br />
                        </div>
                        <button type="submit" class="btn btn-success ">Cambiar</button>
                    </form>
                </div>
            </div>
    </div>
    <div class="fixed-bottom">
        <a class="pull-right" href="@Url.Action("Index", "Login")"><button name="btnSalir">Salir</button></a>
        <a class="pull-right" href="@Url.Action("Menu", "Login")"><button name="btnSalir">Regresar</button></a>
    </div>

</body>
</html>
