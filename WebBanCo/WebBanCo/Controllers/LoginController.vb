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
                objUsuario.numero_tarjeta = Convert.ToString(Request.Form("numero_tarjeta"))
                objUsuario.pin = Convert.ToString(Request.Form("pin"))
                objUsuario.nombres = Convert.ToString(Request.Form("nombres"))
                objUsuario.apellidos = Convert.ToString(Request.Form("apellidos"))
                objUsuario.direccion = Convert.ToString(Request.Form("direccion"))
                objUsuario.saldo = Convert.ToDouble(Request.Form("saldo"))
                objUsuario.fecha_alta = Convert.ToDateTime(Request.Form("fecha_alta"))
                objUsuario.tipo_usuario = Convert.ToInt16(Request.Form("tipo_usuario"))

                Return View(objUsuario)
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
            Dim tipo As String, flag As Boolean = False
            tipo = System.Configuration.ConfigurationManager.AppSettings("tipo_usuario").ToString()
            If System.Configuration.ConfigurationManager.AppSettings("tipo_usuario").ToString() IsNot "-1" Then
                If con.ValidarPIN(Convert.ToString(Request.Form("txtNIP"))) Then
                    System.Configuration.ConfigurationManager.AppSettings("sesion") = True
                    If tipo Is "1" Then
                        flag = True
                    End If
                    ViewData("flag") = flag
                    Return View()
                Else
                    Return View("LoginPIN")
                End If
            Else
                Return View("Index")
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
            If System.Configuration.ConfigurationManager.AppSettings("sesion") Then
                Return View()
            Else
                Return View("Index")
            End If
        End Function

    End Class
End Namespace