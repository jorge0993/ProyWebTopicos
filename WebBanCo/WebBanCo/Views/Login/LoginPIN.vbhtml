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
    <title>LoginPIN</title>
</head>
<body class="container-fluid" style="text-align:center">


    <div style="text-align:center" class="container center_div ">
        <img src="\Imagenes\bancp1.png" width="200" height="200" />
        <form action="@Url.Action("Menu", "Login")" method="post">
            <div class="form-group">
                <label class="lbl">PIN:</label>
                <input type="password" class="form-control" placeholder="Introduzca PIN" name="txtNIP" required>

            </div>
            <button type="submit" name="btnEntrar" class="btn btn-primary">Entrar</button>
        </form>

    </div>



    <style>
        .lbl {
            font-size: 20px;
        }

        .btn {
            width: 120px;
        }

        .center_div {
            margin: 0 auto;
            width: 50%; /* value of your choice which suits your alignment */
            margin-top: 25%;
        }
    </style>

</body>
</html>