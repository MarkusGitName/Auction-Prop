﻿Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function FAQ() As ActionResult
        ViewData("Message") = "Your FAQ page."

        Return View()
    End Function
    Function Listings() As ActionResult
        ViewData("Message") = "Your Auction Listings."

        Return View()
    End Function
End Class
