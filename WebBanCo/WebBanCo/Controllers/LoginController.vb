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
            System.Configuration.ConfigurationManager.AppSettings("tipo_usuario") = con.VerificarUsuario(Convert.ToString(Request.Form("txtTarjeta")))
            If System.Configuration.ConfigurationManager.AppSettings("tipo_usuario") IsNot "-1" Then
                System.Configuration.ConfigurationManager.AppSettings("tarjeta") = Convert.ToString(Request.Form("txtTarjeta"))
                Return View()
            Else
                Return View("Index")
            End If

        End Function
        Function Usuario() As ActionResult
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

        End Function

        Function Usuario_Nuevo() As ActionResult
            If System.Configuration.ConfigurationManager.AppSettings("sesion") Then
                Return View()
            Else
                Return View("Index")
            End If
        End Function

        Function Menu() As ActionResult
            Dim flag As String = "block"
            If System.Configuration.ConfigurationManager.AppSettings("tipo_usuario").ToString() Is "1" Then
                flag = "none"
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

    End Class
End Namespace