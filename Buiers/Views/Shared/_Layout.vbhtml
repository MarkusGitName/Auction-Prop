<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    <div class="navigation">
        <div class="container">
            <header class="navbar" id="top" role="banner">
                <div class="navbar-header">
                    <button class="navbar-toggle" type="button" data-toggle="collapse" data-target=".bs-navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <div class="navbar-brand nav" id="brand">
                        <a href="index-slider.html"><img src="Logo.png" width="250px" height="35px" alt="Auction-Prop Logo"></a>
                    </div>
                </div>
                <nav class="collapse navbar-collapse bs-navbar-collapse navbar-right" role="navigation">
                    <ul class="nav navbar-nav">
                        <li>
                            <a href="Auction Listings.html">Auctions</a>
                        </li>
                        <li class="has-child">
                            <a href="#">How It Works</a>
                            <ul class="child-navigation">
                                <li><a href="buyers-guide">Buyers Guide</a></li>
                                <li><a href="buyers-guide">Sellers Guide</a></li>
                            </ul>
                        </li>
                        <li>
                            <a href="this-is-us.html">This Is Us</a>
                        </li>
                        <li><a href="faq.html">FAQ</a></li>
                        <li><a href="contact-us.html">Contact</a></li>
                        <li><a href="register.html" class="promoted">Register</a></li>
                        <li>
                            <a href="sign-in.html">Sign In</a>
                        </li>
                    </ul>
                </nav><!-- /.navbar collapse-->
                <div class="add-your-property">
                    <a href="submit.html" class="btn btn-default"><i class="fa fa-plus"></i><span class="text">Add Your Property</span></a>
                </div>
            </header><!-- /.navbar -->
        </div><!-- /.container -->
    </div><!-- /.navigation -->

    <div class="container">
        @RenderBody()
        <hr/>
    </div>
    <footer>
        <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
    </footer>
    

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
