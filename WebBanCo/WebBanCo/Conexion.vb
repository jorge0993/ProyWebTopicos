Imports System.Data.SqlClient

Public Class Conexion
    Private cn As SqlConnection
    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()
        Try
            Me.cn = New SqlConnection(My.Settings.Conexion)
            Me.cn.Open()
        Catch e As Exception

        End Try

    End Sub

    'metodos a agregar   :)

    Public Sub mostrarUsuarios(lista As List(Of Usuario))
        Dim sql As String = "Select Numero_tarjeta, Nombres, Apellidos, Direccion, TipoUsuario from Usuarios"
        Dim cmd As New SqlCommand(sql, cn)
        Dim objUsuario As New Usuario
        Try
            dr = cmd.ExecuteReader()

            While dr.Read()
                objUsuario.numero_tarjeta = Convert.ToString(dr("Numero_tarjeta"))
                objUsuario.pin = Convert.ToString(dr("PIN"))
                objUsuario.nombres = Convert.ToString(dr("Saldo"))
                objUsuario.apellidos = Convert.ToString(dr("Nombres"))
                objUsuario.direccion = Convert.ToString(dr("Apellidos"))
                objUsuario.saldo = Convert.ToDouble(dr("Direccion"))
                objUsuario.fecha_alta = Convert.ToDateTime(dr("FechaAlta"))
                objUsuario.tipo_usuario = Convert.ToInt16(dr("TipoUsuario"))
                lista.Add(objUsuario)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Public Sub EliminarUsuario(ByVal NumTarjeta As String)
    '    Dim Sql As String = "Delete from Usuarios where Numero_tarjeta=" + NumTarjeta
    '    Dim cmd As New SqlCommand(Sql, cn)

    '    Try
    '        Dim da As New SqlDataAdapter(cmd)
    '        Dim ds As New DataSet

    '        da.Fill(ds, "Usuarios")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Public Function agregarUsuario(Tarjeta As String, PIN As String, Nombres As String, Apellidos As String, Direccion As String, Fecha As Date, TipoUsuario As Integer)
        Dim Resultado As Boolean = False
        Dim SaldoUsuario As Integer = 0
        Dim FechaAlta As String
        FechaAlta = Convert.ToString(Fecha.ToString("MM/dd/yyyy"))
        Try
            Dim Sql As String = "Select Numero_tarjeta from Usuarios where Numero_tarjeta='" & Tarjeta & "'"
            Me.cmd = New SqlCommand(Sql, Me.cn)
            If Me.cmd.ExecuteNonQuery() = 1 Then
                Resultado = False
            Else
                Sql = "Insert Into Usuarios(Numero_tarjeta,PIN,Saldo,Nombres,Apellidos,Direccion,FechaAlta,TipoUsuario) values('" & Tarjeta & "','" & PIN & "'," & SaldoUsuario & ",'" & Nombres & "','" & Apellidos & "','" & Direccion & "','" & FechaAlta & "'," & TipoUsuario & ")"
                Me.cmd = New SqlCommand(Sql, Me.cn)
                If Me.cmd.ExecuteNonQuery() = 1 Then
                    Resultado = True
                End If
            End If
        Catch ex As Exception
        End Try
        Return Resultado
    End Function

    'Public Sub ModificarPin(nuevoPin As Int16, numeroTarjeta As String)
    '    Try
    '        cmd = New SqlCommand("update Usuarios set PIN = " & nuevoPin & "where Numero_tarjeta = " & numeroTarjeta, cn)
    '        If cmd.ExecuteNonQuery() Then
    '            MessageBox.Show("PIN ha sido modificado")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error al modificar PIN: " & ex.Message)
    '    End Try
    'End Sub

    'Modifica los datos en la tabla usuario segun el numero de tarjeta
    'Public Sub ModificarUsuario(nombre As String, apellidos As String, direccion As String, numeroTarjeta As String, tipoUsuario As String)
    '    Try
    '        cmd = New SqlCommand("Update Usuarios set Nombres='" & nombre & "', Apellidos= '" & apellidos & "', Direccion= '" & direccion & "', TipoUsuario='" & tipoUsuario & "' where Numero_tarjeta= '" & numeroTarjeta & "'", cn)
    '        If cmd.ExecuteNonQuery() Then
    '            MessageBox.Show("Usuario modificado.")
    '        Else
    '            MessageBox.Show("Usuario no modificado")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error al modificar usuario: " & ex.Message)
    '    End Try
    'End Sub



    Public Function ConsultarSaldo()
        Dim SaldoDisponible As String = ""
        Dim Tarjeta As String
        Tarjeta = System.Configuration.ConfigurationManager.AppSettings("tarjeta")
        cmd = New SqlCommand("Select Saldo from Usuarios where Numero_tarjeta='" & Tarjeta & "'", cn)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            SaldoDisponible = dr("Saldo").ToString()
        End While
        dr.Close()
        Return SaldoDisponible
    End Function

    Public Function VerificarUsuario(Tarjeta As String)
        Dim tipo As String = "-1"
        Try
            cmd = New SqlCommand("Select * from Usuarios where Numero_tarjeta='" & Tarjeta & "'", cn)
            dr = cmd.ExecuteReader()
            If (dr.Read()) Then
                tipo = dr("TipoUsuario").ToString()
            End If
        Catch ex As Exception
            dr.Close()
        End Try
        dr.Close()
        Return tipo

    End Function

    'Public Function ValidarRetiro(cantidad As Integer)
    '    Dim Validar As Boolean = True
    '    cmd = New SqlCommand("Select * from Usuarios where Numero_tarjeta='" & Tarjeta & "'", cn)
    '    dr = cmd.ExecuteReader()
    '    While (dr.Read())
    '        If (Convert.ToInt32(dr("Saldo").ToString()) < cantidad) Then
    '            Validar = False
    '        End If
    '    End While
    '    dr.Close()
    '    Return Validar

    'End Function




    'Public Function RealizarMovimiento(NombreMov As String, CantidadRetirada As Integer, movimiento As String)

    '    Dim TipoMov As String = ""
    '    If (ValidarRetiro(CantidadRetirada) = True) Then

    '        Dim idultimo As Integer = 0
    '        cmd = New SqlCommand("Select * from Movimientos order by IdMovimientos desc", cn)
    '        dr = cmd.ExecuteReader()
    '        dr.Read()

    '        idultimo = Convert.ToInt32(dr(0))

    '        dr.Close()
    '        idultimo = idultimo + 1



    '        cmd = New SqlCommand("Insert Into Movimientos(IdMovimientos,TipoMovimiento,Tarjeta,CantidadMovimiento) values (" & idultimo & ",'" & NombreMov & "','" & Tarjeta & "'," & CantidadRetirada & ")", cn)
    '        cmd.ExecuteNonQuery()
    '        RestarSaldo(CantidadRetirada)
    '        If (movimiento = "Retiro") Then

    '            TipoMov = "Retiro realizado correctamente"

    '        ElseIf (movimiento = "Pago") Then

    '            TipoMov = "El pago se realizado correctamente"

    '        ElseIf (movimiento = "Recarga") Then

    '            TipoMov = "La recarga se realizado correctamente"
    '        End If

    '    Else

    '        TipoMov = "No cuenta con el saldo suficiente"
    '    End If
    '    Return TipoMov

    'End Function

    'Public Sub RestarSaldo(Cantidad As Integer)
    '    Dim SaldoNuevo As Integer = 0

    '    cmd = New SqlCommand("Select * from Usuarios where Numero_tarjeta = '" & Tarjeta & "'", cn)
    '    dr = cmd.ExecuteReader()
    '    While (dr.Read())
    '        SaldoNuevo = Convert.ToInt32(dr("Saldo").ToString()) - Cantidad
    '    End While
    '    dr.Close()

    '    cmd = New SqlCommand("update Usuarios set Saldo=@Saldo where Numero_tarjeta = '" & Tarjeta & "'", cn)
    '    cmd.Parameters.AddWithValue("Saldo", SaldoNuevo)
    '    cmd.ExecuteNonQuery()
    'End Sub

    'Public Function Ingresar(pin As String)
    '    Dim contador As Integer = 0
    '    Try
    '        'permite realizar instrucciones sql
    '        cmd = New SqlCommand(("Select * from Usuarios where Numero_tarjeta='" & (Tarjeta & "'")), cn)
    '        'realzar la instruccion anterior
    '        dr = cmd.ExecuteReader
    '        'recorriendo para ver si encuentra registros con el expendiente anterior

    '        While dr.Read
    '            contador = (contador + 1)
    '        End While

    '    Catch ex As Exception

    '    End Try
    '    cn.Close()
    '    Return contador
    'End Function

    Public Function ValidarPIN(ActualPIN As String)
        Dim Tarjeta As String
        Tarjeta = System.Configuration.ConfigurationManager.AppSettings("tarjeta")
        Dim usuario As Boolean = False
        Try
            cmd = New SqlCommand("Select * from Usuarios where Numero_tarjeta='" & Tarjeta & "' and PIN= " & ActualPIN, cn)
            dr = cmd.ExecuteReader()
            If (dr.Read()) Then
                usuario = True
            Else
                usuario = False
            End If
            dr.Close()
        Catch ex As Exception

        End Try
        Return usuario

    End Function

    'Public Function CambiarPIN(NuevoPIN As Integer, confirmar As Boolean)

    '    Dim Resultado As String = "El PIN fue cambiado con exito"
    '    Try
    '        If (confirmar = True) Then
    '            cmd = New SqlCommand("update Usuarios set PIN = " & NuevoPIN & " where Numero_tarjeta = '" & Tarjeta & "'", cn)
    '            cmd.ExecuteNonQuery()
    '        Else
    '            Resultado = "Contraseña actual incorrecta"
    '        End If

    '    Catch ex As Exception

    '        Resultado = "Ha ucurrido un error " + ex.ToString()
    '    End Try
    '    dr.Close()
    '    Return Resultado
    'End Function
    'Public Sub mostrarMovimientos(dg As DataGridView)
    '    Dim sql As String = "Select Tarjeta,TipoMovimiento,CantidadMovimiento from Movimientos where Tarjeta=" & Tarjeta
    '    Dim cmd As New SqlCommand(sql, cn)

    '    Try
    '        Dim da As New SqlDataAdapter(cmd)
    '        Dim ds As New DataSet

    '        da.Fill(ds, "Movimientos")

    '        dg.DataSource = ds.Tables("Movimientos")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
End Class