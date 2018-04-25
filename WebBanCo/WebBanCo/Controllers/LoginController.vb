Imports System.Web.Mvc

Namespace Controllers
    Public Class LoginController
        Inherits Controller

        ' GET: Login
        Dim con As New Conexion
        Function Index() As ActionResult
            System.Configuration.ConfigurationManager.AppSettings("tarjeta") = Nothing
            System.Configuration.ConfigurationManager.AppSettings("sesion") = False
            System.Configuration.ConfigurationManager.AppSettings("tipo_usuario") = "-1"
            Return View()
        End Function
        Function LoginPIN() As ActionResult
            Dim mensaje As String = Nothing
            System.Configuration.ConfigurationManager.AppSettings("tipo_usuario") = con.VerificarUsuario(Convert.ToString(Request.Form("txtTarjeta")))
            If System.Configuration.ConfigurationManager.AppSettings("tipo_usuario") IsNot "-1" Then
                System.Configuration.ConfigurationManager.AppSettings("tarjeta") = Convert.ToString(Request.Form("txtTarjeta"))
                Return View()
            Else
                mensaje = "Introduzca bien su número de tarjeta"
                ViewData("mensaje") = mensaje
                Return View("Index")
            End If

        End Function
        Function Usuario() As ActionResult
            ViewData("error") = Nothing
            Try
                If System.Configuration.ConfigurationManager.AppSettings("sesion") Then

                    Dim objUsuario As New Usuario()
                    objUsuario.numero_tarjeta = Request.Form("numero_tarjeta").ToString()
                    objUsuario.pin = Request.Form("pin").ToString()
                    objUsuario.nombres = Request.Form("nombres")
                    objUsuario.apellidos = Request.Form("apellidos")
                    objUsuario.direccion = Request.Form("direccion")
                    objUsuario.saldo = 0.0
                    objUsuario.fecha_alta = Convert.ToDateTime(Request.Form("fecha_alta"))
                    objUsuario.tipo_usuario = Convert.ToInt16(Request.Form("tipo_usuario"))
                    If con.agregarUsuario(objUsuario.numero_tarjeta, objUsuario.pin, objUsuario.nombres, objUsuario.apellidos, objUsuario.direccion, objUsuario.fecha_alta, objUsuario.tipo_usuario) Then
                        Return View(objUsuario)
                    Else
                        Return View("Usuario_Nuevo")
                    End If

                Else
                    Return View("Index")
                End If

            Catch ex As Exception
                ViewData("error") = "Ha ocurrido un error"
                Return View("Usuario_Nuevo")
            End Try

        End Function

        Function Usuario_Nuevo() As ActionResult
            If System.Configuration.ConfigurationManager.AppSettings("sesion") Then
                Return View()
            Else
                Return View("Index")
            End If
        End Function

        Function Menu() As ActionResult
            Dim mensaje As String = Nothing
            Dim flag As Boolean = True
            If System.Configuration.ConfigurationManager.AppSettings("tipo_usuario").ToString() Is "1" Then
                flag = False
            End If
            ViewData("flag") = flag
            If System.Configuration.ConfigurationManager.AppSettings("sesion") Then
                Return View()
            Else
                If Request.Form("txtNIP") IsNot Nothing Or Request.Form("txtNIP") IsNot "" Then
                    If con.ValidarPIN(Convert.ToString(Request.Form("txtNIP"))) Then
                        System.Configuration.ConfigurationManager.AppSettings("sesion") = True
                        Return View()
                    Else
                        mensaje = "PIN incorrecto"
                        ViewData("mensaje") = mensaje
                        Return View("LoginPIN")
                    End If
                Else
                    Return View("Index")
                End If
            End If

        End Function

        Function Retiros() As ActionResult
            If System.Configuration.ConfigurationManager.AppSettings("sesion") Then
                Return View()
            Else
                Return View("Index")
            End If
        End Function

        Function Movimientos() As ActionResult
            If System.Configuration.ConfigurationManager.AppSettings("sesion") Then
                Return View()
            Else
                Return View("Index")
            End If
        End Function

        Function Pagos() As ActionResult
            If System.Configuration.ConfigurationManager.AppSettings("sesion") Then
                Return View()
            Else
                Return View("Index")
            End If
        End Function

        Function CambiarNIP() As ActionResult
            If System.Configuration.ConfigurationManager.AppSettings("sesion") Then
                Return View()
            Else
                Return View("Index")
            End If
        End Function

        Function CambiarNIP2() As ActionResult
            ViewData("error") = Nothing
            Try
                If System.Configuration.ConfigurationManager.AppSettings("sesion") Then
                    Dim nipActual = If(Request.Form("nipActual") IsNot Nothing, Request.Form("nipActual").ToString(), "")
                    Dim nuevoNip = If(Request.Form("nuevoNip") IsNot Nothing, Request.Form("nuevoNip").ToString(), "")
                    Dim confirmar = If(Request.Form("confirmar") IsNot Nothing, Request.Form("confirmar").ToString(), "")
                    If nipActual <> "" And nuevoNip <> "" And confirmar <> "" Then
                        Dim result = con.CambiarPIN(Convert.ToInt16(nuevoNip), Convert.ToInt16(confirmar))
                        If result.Equals("Exito") Then
                            Return Redirect("/Login/Menu")
                        Else
                            Return View("CambiarNIP")
                        End If
                    End If

                Else
                    Return View("Index")
                End If
            Catch ex As Exception
                ViewData("error") = "Ha ocurrido un error"
                Return View("CambiarNIP")
            End Try

        End Function

        Function Saldo() As ActionResult
            If Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings("sesion")) Then
                Dim monto As Double
                monto = Convert.ToDouble(con.ConsultarSaldo())
                ViewData("monto") = monto
                Return View()
            Else
                Return View("Index")
            End If
        End Function

        Function Retiro(cantidad As String) As ActionResult
            Dim mensaje As String = Nothing
            Try
                Dim result = con.RealizarMovimiento("Retiro", Convert.ToInt32(cantidad), "Retiro")
                If Not result.Equals("No cuenta con el saldo suficiente") Then
                    mensaje = "Retiro exitoso"
                    ViewData("mensaje") = mensaje
                    Return View("Retiros")
                Else
                    mensaje = "No cuenta con el saldo suficiente"
                    ViewData("mensaje") = mensaje
                    'Redireccionar a ventana con mensaje de confirmacion
                    Return View("Retiros")

                End If
            Catch ex As Exception
            End Try

        End Function

        Function RealizarPago() As ActionResult
            Dim mensaje As String = Nothing
            ViewData("error") = Nothing
            Try
                Dim result = con.RealizarMovimiento(Request.Form("servicio"), Convert.ToInt32(Request.Form("cantidad")), "Pago")
                mensaje = result
                ViewData("mensaje") = mensaje
                Return View("Pagos")
            Catch ex As Exception
                mensaje = "Ha ocurrido un error"
                ViewData("error") = mensaje
                Return View("Pagos")
            End Try

        End Function

    End Class
End Namespace