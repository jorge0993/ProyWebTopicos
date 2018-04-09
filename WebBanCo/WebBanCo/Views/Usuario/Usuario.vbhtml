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
            <label>Numero de tarjeta: @Model.numero_tarjeta</label>
            <label>Nombres: @Model.nombres</label>
            <label>Apellidos: @Model.apellidos</label>
            <label>Direccion: @Model.direccion</label>
            <label>Saldo: @Model.saldo</label>
            <label>Fecha de alta: @Model.fecha_alta</label>
            <button type="button">Guardar</button>
        </form>
    </div>
</body>
</html>
