@Code
    ViewData("Title") = "Home"
End Code
@*
@Styles.Render("~/Content/Bootstrap.css")
@Styles.Render("~/Content/StylesOne.css")
@Styles.Render("~/Content/bootstrap-select.min.css")
@Styles.Render("~/Content/magnific-popup.css")
@Styles.Render("~/Content/owl.carousel.css")
@Styles.Render("~/Content/owl.transitions.css")
@Styles.Render("~/Content/jquery.slider.min.css")
@Scripts.Render("~/Scripts/bootstrap-select.min.js")
@Scripts.Render("~/Scripts/bootstrap.min.js")
@Scripts.Render("~/Scripts/custom.js")
@Scripts.Render("~/jquery-2.1.0.min.js")
@Scripts.Render("~/Scripts2/smoothscroll.js")
*@


<!DOCTYPE html>

<html lang="en-US">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <link href='http://fonts.googleapis.com/css?family=Roboto:300,400,700' rel='stylesheet' type='text/css'>
    <script src="https://kit.fontawesome.com/ef4e2c1ac6.js" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="~/Content/bootstrap.css" type="text/css">
    <link rel="stylesheet" href="~/Content/bootstrap-select.min.css" type="text/css">
    <link rel="stylesheet" href="~/Content2/jquery.slider.min.css" type="text/css">
    <link rel="stylesheet" href="~/Content2/owl.carousel.css" type="text/css">
    <link rel="stylesheet" href="~/Content2/owl.transitions.css" type="text/css">
    <link rel="stylesheet" href="~/Content/StyleSheet1.css" type="text/css">
    <link rel="stylesheet" href="~/Content/bootstrap-grid.css" type="text/css">

    <title>Auction-Prop.com | Home</title>

</head>

<body class="page-homepage navigation-fixed-top page-slider horizontal-search-float" id="page-top" data-spy="scroll" data-target=".navigation" data-offset="90">
    <div class="wrapper">
        <!-- Slider -->
        <div id="slider" class="loading has-parallax">
            <div id="loading-icon"><i class="fa fa-cog fa-spin"></i></div>
            <div class="owl-carousel homepage-slider carousel-full-width">
                <div class="slide">
                    <div class="container">
                        <div class="overlay">
                            <div class="info">
                                <div class="tag date">12 May at 2020</div>
                                <h3>3398 Lodgeville Road</h3>
                                <figure>Golden Valley, MN 55427</figure>
                            </div>
                            <hr>
                            <a href="property-detail.html" class="link-arrow">Read More</a>
                        </div>
                    </div>
                    <img alt="" src="Bungalow.jpg">
                </div>
                <div class="slide">
                    <div class="container">
                        <div class="overlay">
                            <div class="info">
                                <div class="tag date">18 May at 11:00am</div>
                                <h3>987 Cantebury Drive</h3>
                                <figure>Chicago, IL 60610</figure>
                            </div>
                            <hr>
                            <a href="property-detail.html" class="link-arrow">Read More</a>
                        </div>
                    </div>
                    <img alt="" src="Carousel3.jpg" height="500px" width="900px">
                </div>
                <div class="slide">
                    <div class="container">
                        <div class="overlay">
                            <div class="info">
                                <div class="tag date">
                                    25 May at 11:00am
                                </div>
                                <h3>1866 Clement Street</h3>
                                <figure>Atlanta, GA 30303</figure>
                            </div>
                            <hr>
                            <a href="property-detail.html" class="link-arrow">Read More</a>
                        </div>
                    </div>
                    <img alt="" src="Glass Dining.jpg">
                </div>
            </div>
        </div>
        <!-- end Slider -->
        <div class="search-box-wrapper">
            <div class="search-box-inner">
                <div class="container">
                    <div class="search-box map">
                        <form role="form" id="form-map-sale" class="form-map form-search clearfix">
                            <div class="row">
                                <div class="col-md-2 col-sm-4">
                                    <div class="form-group">
                                        <select name="form-sale-country">
                                            <option value="">Country</option>
                                            <option value="1">South Africa</option>
                                        </select>
                                    </div><!-- /.form-group -->
                                </div>
                                <div class="col-md-2 col-sm-4">
                                    <div class="form-group">
                                        <select name="form-sale-district">
                                            <option value="">Province</option>
                                            <option value="1">Gauteng</option>
                                            <option value="2">Free State</option>
                                            <option value="3">North West</option>
                                            <option value="4">Limpopo</option>
                                            <option value="5">Mpumalanga</option>
                                            <option value="6">Kwazulu-Natal</option>
                                            <option value="7">Western Cape</option>
                                            <option value="8">Northern Cape</option>
                                            <option value="9">Eastern Cape</option>
                                        </select>
                                    </div><!-- /.form-group -->
                                </div>
                                <div class="col-md-2 col-sm-4">
                                    <div class="form-group">
                                        <select name="form-sale-city">
                                            <option value="">City</option>
                                            <option value="1">Johannesburg</option>
                                            <option value="2">Pretoria</option>
                                            <option value="3">Cape Town</option>
                                            <option value="4">Bloemfontein</option>
                                            <option value="5">Durban</option>
                                            <option value="6">Nelspruit</option>
                                        </select>
                                    </div><!-- /.form-group -->
                                </div>
                                <div class="col-md-2 col-sm-4">
                                    <div class="form-group">
                                        <select name="form-sale-property-type">
                                            <option value="">Property Type</option>
                                            <option value="1">Residential</option>
                                            <option value="2">Commercial</option>
                                            <option value="3">Agricultural</option>
                                            <option value="4">Investment</option>
                                            <option value="5">Bank Instruction</option>
                                        </select>
                                    </div><!-- /.form-group -->
                                </div>
                                <div class="col-md-2 col-sm-4">
                                    <div class="form-group">
                                        <select name="form-sale-price">
                                            <option value="">Property Status</option>
                                            <option value="1">Auction</option>
                                            <option value="2">For Sale</option>
                                        </select>
                                    </div>
                                </div>
                                <div class="col-md-2 col-sm-4">
                                    <div class="form-group">
                                        <button type="submit" class="btn btn-default">Search Now</button>
                                    </div><!-- /.form-group -->
                                </div>
                            </div>
                        </form><!-- /#form-map -->
                    </div><!-- /.search-box -->
                </div><!-- /.container -->
            </div><!-- /.search-box-inner -->
        </div>
        <!-- end Search Box -->
        <!-- Page Content -->
        <div id="page-content">
            <section id="banner">
                <div class="block has-dark-background background-color-default-darker center text-banner">
                    <div class="container">
                        <h1 class="no-bottom-margin no-border">View our Comprehensive <a href="#" class="text-underline">Buyers</a> and  <a href="#" class="text-underline">Sellers</a> Guides to get you started</h1>
                    </div>
                </div>
            </section><!-- /#banner -->
            <section id="our-services" class="block">
                <div class="container">
                    <header class="section-title"><h2>Our Services</h2></header>
                    <div class="row">
                        <div class="col-md-4 col-sm-4">
                            <div class="feature-box equal-height">
                                <figure class="icon"><i class="fa fa-folder"></i></figure>
                                <aside class="description">
                                    <header><h3>Wide Range of Properties</h3></header>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit</p>
                                    <a href="properties-listing.html" class="link-arrow">Read More</a>
                                </aside>
                            </div><!-- /.feature-box -->
                        </div><!-- /.col-md-4 -->
                        <div class="col-md-4 col-sm-4">
                            <div class="feature-box equal-height">
                                <figure class="icon"><i class="fa fa-users"></i></figure>
                                <aside class="description">
                                    <header><h3>14 Agents for Your Service</h3></header>
                                    <p>Aliquam gravida magna et fringilla convallis. Pellentesque habitant morbi </p>
                                    <a href="agents-listing.html" class="link-arrow">Read More</a>
                                </aside>
                            </div><!-- /.feature-box -->
                        </div><!-- /.col-md-4 -->
                        <div class="col-md-4 col-sm-4">
                            <div class="feature-box equal-height">
                                <figure class="icon"><i class="fa fa-money"></i></figure>
                                <aside class="description">
                                    <header><h3>Best Price Guarantee!</h3></header>
                                    <p>Phasellus non viverra tortor, id auctor leo. Suspendisse id nibh placerat</p>
                                    <a href="#" class="link-arrow">Read More</a>
                                </aside>
                            </div><!-- /.feature-box -->
                        </div><!-- /.col-md-4 -->
                    </div><!-- /.row -->
                </div><!-- /.container -->
            </section><!-- /#our-services -->
            <section id="price-drop" class="block">
                <div class="container">
                    <header class="section-title">
                        <h2>Upcoming Auctions</h2>
                        <a href="properties-listing.html" class="link-arrow">All Properties</a>
                    </header>
                    <div class="row">
                        <div class="col-md-3 col-sm-6">
                            <div class="property">
                                <a href="property-detail.html">
                                    <div class="property-image">
                                        <img alt="" src="~/img/properties/property-06.jpg">
                                    </div>
                                    <div class="overlay">
                                        <div class="info">
                                            <div class="tag date">25 May at 11:00am</div>
                                            <h3>3398 Lodgeville Road</h3>
                                            <figure>Golden Valley, MN 55427</figure>
                                        </div>
                                        <ul class="additional-info">
                                            <li>
                                                <header>Area:</header>
                                                <figure>240m<sup>2</sup></figure>
                                            </li>
                                            <li>
                                                <header>Beds:</header>
                                                <figure>2</figure>
                                            </li>
                                            <li>
                                                <header>Baths:</header>
                                                <figure>2</figure>
                                            </li>
                                            <li>
                                                <header>Garages:</header>
                                                <figure>0</figure>
                                            </li>
                                        </ul>
                                    </div>
                                </a>
                            </div><!-- /.property -->
                        </div><!-- /.col-md-3 -->
                        <div class="col-md-3 col-sm-6">
                            <div class="property">
                                <a href="property-detail.html">
                                    <div class="property-image">
                                        <img alt="" src="~/img/properties/property-04.jpg">
                                    </div>
                                    <div class="overlay">
                                        <div class="info">
                                            <div class="tag date">01 June at 11:00am</div>
                                            <h3>2186 Rinehart Road</h3>
                                            <figure>Doral, FL 33178 </figure>
                                        </div>
                                        <ul class="additional-info">
                                            <li>
                                                <header>Area:</header>
                                                <figure>240m<sup>2</sup></figure>
                                            </li>
                                            <li>
                                                <header>Beds:</header>
                                                <figure>3</figure>
                                            </li>
                                            <li>
                                                <header>Baths:</header>
                                                <figure>1</figure>
                                            </li>
                                            <li>
                                                <header>Garages:</header>
                                                <figure>1</figure>
                                            </li>
                                        </ul>
                                    </div>
                                </a>
                            </div><!-- /.property -->
                        </div><!-- /.col-md-3 -->
                        <div class="col-md-3 col-sm-6">
                            <div class="property">
                                <a href="property-detail.html">
                                    <div class="property-image">
                                        <img alt="" src="~/img/properties/property-07.jpg">
                                    </div>
                                    <div class="overlay">
                                        <div class="info">
                                            <div class="tag date">08 June at 11:00am</div>
                                            <h3>3705 Brighton Circle Road</h3>
                                            <figure>Glenwood, MN 56334</figure>
                                        </div>
                                        <ul class="additional-info">
                                            <li>
                                                <header>Area:</header>
                                                <figure>240m<sup>2</sup></figure>
                                            </li>
                                            <li>
                                                <header>Beds:</header>
                                                <figure>3</figure>
                                            </li>
                                            <li>
                                                <header>Baths:</header>
                                                <figure>1</figure>
                                            </li>
                                            <li>
                                                <header>Garages:</header>
                                                <figure>1</figure>
                                            </li>
                                        </ul>
                                    </div>
                                </a>
                            </div><!-- /.property -->
                        </div><!-- /.col-md-3 -->
                        <div class="col-md-3 col-sm-6">
                            <div class="property">
                                <a href="property-detail.html">
                                    <div class="property-image">
                                        <img alt="" src="~/img/properties/property-08.jpg">
                                    </div>
                                    <div class="overlay">
                                        <div class="info">
                                            <div class="tag date">12 June 11:00am</div>
                                            <h3>362 Lynn Ogden Lane</h3>
                                            <figure>Galveston, TX 77550</figure>
                                        </div>
                                        <ul class="additional-info">
                                            <li>
                                                <header>Area:</header>
                                                <figure>240m<sup>2</sup></figure>
                                            </li>
                                            <li>
                                                <header>Beds:</header>
                                                <figure>3</figure>
                                            </li>
                                            <li>
                                                <header>Baths:</header>
                                                <figure>1</figure>
                                            </li>
                                            <li>
                                                <header>Garages:</header>
                                                <figure>1</figure>
                                            </li>
                                        </ul>
                                    </div>
                                </a>
                            </div><!-- /.property -->
                        </div><!-- /.col-md-3 -->
                    </div><!-- /.row-->
                </div><!-- /.container -->
            </section><!-- /#price-drop -->
            <aside id="advertising" class="block">
                <div class="container">
                    <a href="submit.html">
                        <div class="banner">
                            <div class="wrapper">
                                <span class="title">Want to list your property with us?</span>
                                <span class="submit">Contact us now! <i class="fa fa-plus-square"></i></span>
                            </div>
                        </div><!-- /.banner-->
                    </a>
                </div>
            </aside><!-- /#adveritsing-->
            <!-- /#banner Start -->
            <section id="banner">
                <div class="block has-dark-background background-color-default-darker center text-banner">
                    <div class="container">
                        <h1 class="no-bottom-margin no-border">Insert Property or Real Estate related qoute here (Maybe even replace this with Jumbotron)</h1>
                    </div>
                </div>
            </section>
            <!-- /#banner End -->
            <!-- /#testimonials Start -->
            <section id="testimonials" class="block">
                <div class="container">
                    <header class="section-title"><h2>What our Clients say about Us</h2></header>
                    <div class="owl-carousel testimonials-carousel">
                        <blockquote class="testimonial">
                            <figure>
                                <div class="image">
                                    <img alt="" src="~/img/Woman.jpg">
                                </div>
                            </figure>
                            <aside class="cite">
                                <p>Fusce risus metus, placerat in consectetur eu, porttitor a est sed sed dolor lorem cras adipiscing</p>
                                <footer>Natalie Jenkins</footer>
                            </aside>
                        </blockquote>
                        <blockquote class="testimonial">
                            <figure>
                                <div class="image">
                                    <img alt="" src="~/img/Guy.jpg">
                                </div>
                            </figure>
                            <aside class="cite">
                                <p>Fusce risus metus, placerat in consectetur eu, porttitor a est sed sed dolor lorem cras adipiscing</p>
                                <footer>Martin Schimms</footer>
                            </aside>
                        </blockquote>
                    </div><!-- /.testimonials-carousel -->
                </div><!-- /.container -->
            </section><!-- /#testimonials End -->
            <section id="new-properties" class="block">
                <div class="container">
                    <header class="section-title">
                        <h2>Recently Sold Properties</h2>
                    </header>
                    <div class="row">
                        <div class="col-md-3 col-sm-6">
                            <div class="property">
                                <div class="property-image">
                                    <img alt="" src="~/img/Floridian.jpg">
                                </div>
                                <div class="overlay">
                                    <div class="info">
                                        <div class="tag sold">SOLD!</div>
                                        <h3>3398 Lodgeville Road</h3>
                                        <figure>Golden Valley, MN 55427</figure>
                                    </div>
                                    <ul class="additional-info">
                                        <li>
                                            <header>Area:</header>
                                            <figure>240m<sup>2</sup></figure>
                                        </li>
                                        <li>
                                            <header>Beds:</header>
                                            <figure>2</figure>
                                        </li>
                                        <li>
                                            <header>Baths:</header>
                                            <figure>2</figure>
                                        </li>
                                        <li>
                                            <header>Garages:</header>
                                            <figure>0</figure>
                                        </li>
                                    </ul>
                                </div>
                            </div><!-- /.property -->
                        </div><!-- /.col-md-3 -->
                        <div class="col-md-3 col-sm-6">
                            <div class="property">
                                <div class="property-image">
                                    <img alt="" src="~/img/Old Charm.jpg">
                                </div>
                                <div class="overlay">
                                    <div class="info">
                                        <div class="tag sold">SOLD!</div>
                                        <h3>2186 Rinehart Road</h3>
                                        <figure>Doral, FL 33178 </figure>
                                    </div>
                                    <ul class="additional-info">
                                        <li>
                                            <header>Area:</header>
                                            <figure>240m<sup>2</sup></figure>
                                        </li>
                                        <li>
                                            <header>Beds:</header>
                                            <figure>3</figure>
                                        </li>
                                        <li>
                                            <header>Baths:</header>
                                            <figure>1</figure>
                                        </li>
                                        <li>
                                            <header>Garages:</header>
                                            <figure>1</figure>
                                        </li>
                                    </ul>
                                </div>
                            </div><!-- /.property -->
                        </div><!-- /.col-md-3 -->
                        <div class="col-md-3 col-sm-6">
                            <div class="property">
                                <div class="property-image">
                                    <img alt="" src="~/img/Open Bed.jpg">
                                </div>
                                <div class="overlay">
                                    <div class="info">
                                        <div class="tag sold">SOLD!</div>
                                        <h3>3705 Brighton Circle Road</h3>
                                        <figure>Glenwood, MN 56334</figure>
                                    </div>
                                    <ul class="additional-info">
                                        <li>
                                            <header>Area:</header>
                                            <figure>240m<sup>2</sup></figure>
                                        </li>
                                        <li>
                                            <header>Beds:</header>
                                            <figure>3</figure>
                                        </li>
                                        <li>
                                            <header>Baths:</header>
                                            <figure>1</figure>
                                        </li>
                                        <li>
                                            <header>Garages:</header>
                                            <figure>1</figure>
                                        </li>
                                    </ul>
                                </div>
                            </div><!-- /.property -->
                        </div><!-- /.col-md-3 -->
                        <div class="col-md-3 col-sm-6">
                            <div class="property">
                                <div class="property-image">
                                    <img alt="" src="~/img/Fireplace.jpg">
                                </div>
                                <div class="overlay">
                                    <div class="info">
                                        <div class="tag sold">SOLD!</div>
                                        <h3>362 Lynn Ogden Lane</h3>
                                        <figure>Galveston, TX 77550</figure>
                                    </div>
                                    <ul class="additional-info">
                                        <li>
                                            <header>Area:</header>
                                            <figure>240m<sup>2</sup></figure>
                                        </li>
                                        <li>
                                            <header>Beds:</header>
                                            <figure>3</figure>
                                        </li>
                                        <li>
                                            <header>Baths:</header>
                                            <figure>1</figure>
                                        </li>
                                        <li>
                                            <header>Garages:</header>
                                            <figure>1</figure>
                                        </li>
                                    </ul>
                                </div>
                            </div><!-- /.property -->
                        </div><!-- /.col-md-3 -->
                    </div><!-- /.container-->
            </section><!-- /#new-properties-->
            <section id="partners" class="block">
                <div class="container">
                    <header class="section-title"><h2>Our Partners</h2></header>
                    <div class="logos">
                        <div class="logo"><a href="https://www.sahomeloans.com/"><img src="~/img/SA Home Loans.png" width="120px" height="100px" alt=""></a></div>
                        <div class="logo"><a href="https://www.standardbank.co.za/"><img src="~/img/StandardBank.png" width="140px" height="140px" alt=""></a></div>
                        <div class="logo"><a href="https://www.nedbank.co.za/content/nedbank/desktop/gt/en/personal.html"><img src="~/img/NEDBANK.png" width="70px" height="70px" alt=""></a></div>
                        <div class="logo"><a href="https://www.fnb.co.za/"><img src="~/img/FNB.png" width="120px" height="80px" alt=""></a></div>
                        <div class="logo"><a href="https://www.absa.co.za/personal/"><img src="~/img/absa.png" width="80px" height="80px" alt=""></a></div>
                    </div>
                </div><!-- /.container -->
            </section><!-- /#partners -->
        </div>
        <!-- end Page Content -->
    </div>
    <div id="overlay"></div>
    <script>
        $(window).load(function () {
            initializeOwl(false);
        });
    </script>

    <script type="text/javascript" src="~/Scripts2/jquery-2.1.0.min.js"></script>
    <script type="text/javascript" src="~/Scripts2/jquery-migrate-1.2.1.min.js"></script>
    <script type="text/javascript" src="~/Scripts2/bootstrap.min.js"></script>
    <script type="text/javascript" src="~/Scripts2/smoothscroll.js"></script>
    <script type="text/javascript" src="~/Scripts2/owl.carousel.min.js"></script>
    <script type="text/javascript" src="~/Scripts2/bootstrap-select.min.js"></script>
    <script type="text/javascript" src="~/Scripts2/jquery.validate.min.js"></script>
    <script type="text/javascript" src="~/Scripts2/jquery.placeholder.js"></script>
    <script type="text/javascript" src="~/Scripts2/icheck.min.js"></script>
    <script type="text/javascript" src="~/Scripts2/jquery.vanillabox-0.1.5.min.js"></script>
    <script type="text/javascript" src="~/Scripts2/retina-1.1.0.min.js"></script>
    <script type="text/javascript" src="~/Scripts2/jshashtable-2.1_src.js"></script>
    <script type="text/javascript" src="~/Scripts2/jquery.numberformatter-1.2.3.js"></script>
    <script type="text/javascript" src="~/Scripts2/tmpl.js"></script>
    <script type="text/javascript" src="~/Scripts2/jquery.dependClass-0.1.js"></script>
    <script type="text/javascript" src="~/Scripts2/draggable-0.1.js"></script>
    <script type="text/javascript" src="~/Scripts2/jquery.slider.js"></script>
    <script type="text/javascript" src="~/Scripts2/custom.js"></script>

</body>
</html>
