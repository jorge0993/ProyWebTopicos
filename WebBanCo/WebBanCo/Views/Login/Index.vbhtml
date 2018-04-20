
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
    <title>LoginTarjeta</title>
</head>
<body class="container-fluid">
    <div style="text-align:center">
        <form action="@Url.Action("LoginPIN", "Login")" method="post">
            <label for="">Tarjeta</label><br />
            <input type="text" name="numTarjeta" required><br />
            <button type="submit" name="aceptar">Aceptar</button>
        </form>
    </div>
    
</body>
</html>
