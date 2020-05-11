Public Class HomeController
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

    Function Properties() As ActionResult
        ViewData("Message") = "Your Properties page."

        Return View()
    End Function

    Function Detailed() As ActionResult
        ViewData("Message") = "Detailed property page."

        Return View()
    End Function

    Function Buyers() As ActionResult
        ViewData("Message") = "Buyers guide page."

        Return View()
    End Function

    Function Sellers() As ActionResult
        ViewData("Message") = "Sellers guide page."

        Return View()
    End Function

    Function Home() As ActionResult
        ViewData("Message") = "Home page."

        Return View()
    End Function

    Function ThankYou() As ActionResult
        ViewData("Message") = "Thank you for your submission."

        Return View()
    End Function

    Function MyProperties() As ActionResult
        ViewData("Message") = "My properties page."

        Return View()
    End Function

    Function AddProperty() As ActionResult
        ViewData("Message") = "Add your property page."

        Return View()
    End Function

    Function Register() As ActionResult
        ViewData("Message") = "Account Registration page."

        Return View()
    End Function

End Class
