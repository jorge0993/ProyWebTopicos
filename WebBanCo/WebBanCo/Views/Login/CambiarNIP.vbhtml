
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
    <div class="container">
        <div class="row bg-faded">
            <div class="col-4 mx-auto text-center">
                <img src="\Imagenes\bancp1.png" width="200" height="200" /> 
                
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-sm-10 offset-sm-1 text-center">
                <h3>Cambiar NIP</h3>
                <div class="info-form">
                    <form action="@Url.Action("CambiarNIP2", "Login")" method="post" class="form-inline justify-content-center">
                        <div >
                            <label >PIN Actual:</label><br /> 
                            <input type="password"  class="form-control" placeholder="NIP Actual" name="nipActual"><br />
                            <label >PIN Nuevo:</label><br /> 
                            <input type="password" class="form-control" placeholder="Nuevo NIP" name="nuevoNip"><br /> 
                            <label>Confirmar:</label><br /> 
                            <input type="password" class="form-control" placeholder="Nuevo NIP" name="confirmar"><br /> <br />
                            <button type="submit" class="btn btn-primary ">Cambiar</button>
                        </div>
                        
                    </form>
                </div>
            </div>
        </div>
    </div>
    <div class="fixed-bottom">
        <a class="pull-right" href="@Url.Action("Index", "Login")"><button name="btnSalir" class="btn btn-outline-secondary btn-lg float-right" style="margin-bottom:15px; margin-right:20px">Salir</button></a>
        <a class="pull-left" href="@Url.Action("Menu", "Login")"><button name="btnSalir" class="btn btn-outline-secondary btn-lg" style="margin-bottom:15px; margin-left:20px">Regresar</button></a>
    </div>


    <style>
        .pull-left {
            bottom: 20px;
            
        }
        .container{
            margin-bottom:50px;
        }
    </style>
</body>
</html>
