Imports System.Web.Mvc

Namespace Controllers
    Public Class LoginController
        Inherits Controller
        Public numero_tarjeta As String
        Public tipo_usuario As Integer
        Public sesion As Boolean = False
        ' GET: Login

        Function Index() As ActionResult
            sesion = False
            numero_tarjeta = ""
            tipo_usuario = Nothing
            Return View()
        End Function
        Function LoginPIN() As ActionResult

            'If Convert.ToString(Request.Form("numTarjeta")) = "0" Then
            '    numero_tarjeta = "0"
            Return View()
            'Else
            '    Return View("Index")
            'End If

        End Function
        Function Usuario() As ActionResult

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
        End Function

        Function Usuario_Nuevo() As ActionResult

            Return View()
        End Function

        Function Menu() As ActionResult
            'If Convert.ToString(Request.Form("txtNIP")) = "1" Then
            '    sesion = True
            Return View()
            'Else
            '    Return View("LoginPIN")
            'End If

        End Function

        Function Retiros() As ActionResult
            'If sesion Then
            Return View()
            'Else
            '    Return View("Index")
            'End If
        End Function

        Function Movimientos() As ActionResult
            'If sesion Then
            Return View()
            'Else
            'Return View("Index")
            'End If
        End Function

        Function Pagos() As ActionResult
            'If sesion Then
            Return View()
            'Else
            'Return View("Index")
            'End If
        End Function

        Function CambiarNIP() As ActionResult
            'If sesion Then
            Return View()
            'Else
            'Return View("Index")
            'End If
        End Function
        Function Saldo() As ActionResult
            'If sesion Then
            Return View()
            'Else
            'Return View("Index")
            'End If
        End Function

    End Class
End Namespace