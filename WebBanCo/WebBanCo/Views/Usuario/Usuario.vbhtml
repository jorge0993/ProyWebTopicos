@ModelType WebBanCo.Usuario

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Usuario</title>
</head>
<body>
    <div style="text-align:center">
        <h1>Titulo</h1><br />
        <br />
        
        <h3>Datos del usuario:</h3><br />
        <form>
            <label>Numero de tarjeta: @Model.numero_tarjeta</label><br />
            <label>Nombres: @Model.nombres</label><br />
            <label>Apellidos: @Model.apellidos</label><br />
            <label>Direccion: @Model.direccion</label><br />
            <label>Saldo: @Model.saldo</label><br />
            <label>Fecha de alta: @Model.fecha_alta</label><br />
            <button type="button">Guardar</button>
        </form>
    </div>
</body>
</html>
