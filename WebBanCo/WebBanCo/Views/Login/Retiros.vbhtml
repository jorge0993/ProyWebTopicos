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
    <title>Retiros</title>
</head>
<body class="container-fluid">
    <div class="container">
        <div class="row bg-faded">
            <div class="col-4 mx-auto text-center">
                <img src="\Imagenes\bancp1.png" width="200" height="200" />
            </div>
        </div>
    </div>
    <div class="container" style="margin-top:40px;">
        <div class="row bg-faded">
            <div class="col-4 mx-auto text-center">
                <h3>Retiros:</h3>
                <form action="">
                    <input type="button" class="btn btn-secondary" value="$50" onclick="location.href='@Url.Action("Retiro", "Login", New With {.cantidad = "50"})'" /><br />
                    <input type="button" class="btn btn-secondary" value="$100" onclick="location.href='@Url.Action("Retiro", "Login", New With {.cantidad = "100"})'" /><br />
                    <input type="button" class="btn btn-secondary" value="$500" onclick="location.href='@Url.Action("Retiro", "Login", New With {.cantidad = "500"})'" /><br />
                    <input type="button" class="btn btn-secondary" value="$1000" onclick="location.href='@Url.Action("Retiro", "Login", New With {.cantidad = "1000"})'" /><br />
                    <input type="button" class="btn btn-secondary" value="$2000" onclick="location.href='@Url.Action("Retiro", "Login", New With {.cantidad = "2000"})'" />
                </form>
            </div>
        </div>
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
    </style>
</body>
</html>