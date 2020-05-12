<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Auction-Prop</title>

    <script src="https://kit.fontawesome.com/ef4e2c1ac6.js" crossorigin="anonymous"></script>

    @Styles.Render("~/Content/Bootstrap.css")
    @Styles.Render("~/Content/StylesOne.css")
    @Styles.Render("~/Content/bootstrap.min") 

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
                        <a href="#"><img src="~/Logo/Asset 1.png" width="230px" height="35px" alt="Auction-Prop Logo"></a>
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
    </div>
    <footer>
        <!-- Page Footer -->
        <footer id="page-footer">
            <div class="inner">
                <aside id="footer-main">
                    <div class="container">
                        <div class="row">
                            <div class="col-md-3 col-sm-3">
                                <article>
                                    <a href="#"><img src="~/Logo/Asset 1.png" width="150px" height="35px" alt="Auction-Prop Logo"></a>
                                    <address>
                                        <br>
                                        Fintech Campus<br>
                                        81 Botterklapper Street<br>
                                        The Willows, 0083<br>
                                        Pretoria East
                                    </address>
                                    083 556 3529<br>
                                    <a href="mailto:info@auction-prop.com">info@auction-prop.com</a>
                                </article>
                            </div><!-- /.col-sm-3 -->
                            <div class="col-md-3 col-sm-3">
                                <article>
                                    <h3>Auctions</h3>
                                    <ul class="list-unstyled list-links">
                                        <li><a href="#">Residential</a></li>
                                        <li><a href="#">Commercial</a></li>
                                        <li><a href="#">Agricultural</a></li>
                                        <li><a href="#">Investment</a></li>
                                    </ul>
                                </article>
                            </div><!-- /.col-sm-3 -->
                            <div class="col-md-3 col-sm-3">
                                <article>
                                    <h3>Useful Links</h3>
                                    <ul class="list-unstyled list-links">
                                        <li><a href="#">This Is Us</a></li>
                                        <li><a href="#">Contact</a></li>
                                        <li><a href="#">FAQ</a></li>
                                        <li><a href="#">Privacy Policy</a></li>
                                        <li><a href="#">Terms and Conditions</a></li>
                                    </ul>
                                </article>
                            </div><!-- /.col-sm-3 -->
                            <div class="col-md-3 col-sm-3">
                                <article>
                                    <h3>Recent Properties</h3>
                                    <div class="property small">
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                        </a>
                                        <div class="info">
                                            <a href="property-detail.html"><h4>218 Rinehart Road</h4></a>
                                            <figure>Olivedale, Johannesburg </figure>
                                            <div class="tag price">15 May at 14:00</div>
                                        </div>
                                    </div><!-- /.property -->
                                    <div class="property small">
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                        </a>
                                        <div class="info">
                                            <a href="property-detail.html"><h4>249 Murphy Court</h4></a>
                                            <figure>Sandhurst, Johannesburg</figure>
                                            <div class="tag price">22 June at 14:00</div>
                                        </div>
                                    </div><!-- /.property -->
                                </article>
                            </div><!-- /.col-sm-3 -->
                        </div><!-- /.row -->
                    </div><!-- /.container -->
                </aside><!-- /#footer-main -->
                <aside id="footer-thumbnails" class="footer-thumbnails"></aside><!-- /#footer-thumbnails -->
                <aside id="footer-copyright">
                    <div class="container">
                        <span>All Rights Reserved Auction-Prop. Copyright © 2020.</span>
                        <span class="pull-right"><a href="#page-top" class="roll">Go to top</a></span>
                    </div>
                </aside>
            </div><!-- /.inner -->
        </footer>
        <!-- end Page Footer -->
        </footer>

        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/bundles/bootstrap")
        @RenderSection("scripts", required:=False)
        
    </body>
    </html>
