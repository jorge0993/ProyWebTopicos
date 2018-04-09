Imports System.Web.Mvc

Namespace Controllers
    Public Class UsuarioController
        Inherits Controller

        ' GET: Usuario
        Function Usuario() As ActionResult

            Dim objUsuario As New Usuario()
            objUsuario.numero_tarjeta = Convert.ToString(Request.Form("numero_tarjeta"))
            objUsuario.pin = Convert.ToInt32(Request.Form("pin"))
            objUsuario.nombres = Convert.ToString(Request.Form("nombres"))
            objUsuario.apellidos = Convert.ToString(Request.Form("apellidos"))
            objUsuario.direccion = Convert.ToString(Request.Form("direccion"))
            objUsuario.saldo = Convert.ToDouble(Request.Form("saldo"))
            objUsuario.fecha_alta = Convert.ToDateTime(Request.Form("fecha_alta"))
            objUsuario.tipo_usuario = Convert.ToInt16(Request.Form("tipo_usuario"))

            Return View()
        End Function
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace