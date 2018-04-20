Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        routes.MapRoute(
            name:="Default",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Login", .action = "Index", .id = UrlParameter.Optional}
        )
        routes.MapRoute(
            name:="PIN",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Login", .action = "LoginPIN", .id = UrlParameter.Optional}
        )
        routes.MapRoute(
            name:="Menu",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Login", .action = "Menu", .id = UrlParameter.Optional}
        )
        routes.MapRoute(
            name:="Retiros",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Login", .action = "Retiros", .id = UrlParameter.Optional}
        )
        routes.MapRoute(
            name:="Movimientos",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Login", .action = "Movimientos", .id = UrlParameter.Optional}
        )
        routes.MapRoute(
            name:="Pagos",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Login", .action = "Pagos", .id = UrlParameter.Optional}
        )
        routes.MapRoute(
            name:="CambiarNIP",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Login", .action = "CambiarNIP", .id = UrlParameter.Optional}
        )
    End Sub
End Module