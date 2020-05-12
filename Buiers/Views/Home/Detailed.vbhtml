@Code
    ViewData("Title") = "Detailed"
End Code


<!DOCTYPE html>

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
@Scripts.Render("~/Scripts/jquery.countTo.js")
*@

<html lang="en-US">
<head>

    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <link href='http://fonts.googleapis.com/css?family=Roboto:300,400,700' rel='stylesheet' type='text/css'>
    <script src="https://kit.fontawesome.com/ef4e2c1ac6.js" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="~/Content/bootstrap.css" type="text/css">
    <link rel="stylesheet" href="~/Content2/bootstrap-select.min.css" type="text/css">
    <link rel="stylesheet" href="~/Content2/jquery.slider.min.css" type="text/css">
    <link rel="stylesheet" href="~/Content2/owl.carousel.css" type="text/css">
    <link rel="stylesheet" href="~/Content2/owl.transitions.css" type="text/css">
    <link rel="stylesheet" href="~/Content/StyleSheet1.css" type="text/css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>

    <title>Auction-Prop | Property Detail</title>

</head>

<body class="page-sub-page page-listing page-grid page-search-results" id="page-top">
    <!-- Page Content -->
    <div id="page-content">
        <!-- Breadcrumb -->
        <div class="container">
            <ol class="breadcrumb">
                <li><a href="#">Home</a></li>
                <li class="active">338 Lodgeville Road</li>
            </ol>
        </div>
        <!-- end Breadcrumb -->

        <div class="container">
            <div class="row">
                <!-- Property Detail Content -->
                <div class="col-md-9 col-sm-9">
                    <section id="property-detail">
                        <header class="property-title">
                            <h1>338 Lodgeville Road</h1>
                            <figure>Newlands, Cape Town</figure>
                            <span class="actions">
                                <!--<a href="#" class="fa fa-print"></a>-->
                                <a href="#" class="bookmark" data-bookmark-state="empty"><span class="title-add">Add to bookmark</span><span class="title-added">Added</span></a>
                            </span>
                        </header>
                        <section id="property-gallery">
                            <div class="owl-carousel property-carousel">
                                <div class="property-slide">
                                    <a href="~/img/properties/property-detail-01.jpg" class="image-popup">
                                        <div class="overlay"><h3>Front View</h3></div>
                                        <img alt="" src="~/img/properties/property-detail-01.jpg">
                                    </a>
                                </div><!-- /.property-slide -->
                                <div class="property-slide">
                                    <a href="~/img/properties/property-detail-02.jpg" class="image-popup">
                                        <div class="overlay"><h3>Bedroom</h3></div>
                                        <img alt="" src="~/img/properties/property-detail-02.jpg">
                                    </a>
                                </div><!-- /.property-slide -->
                                <div class="property-slide">
                                    <a href="~/img/properties/property-detail-03.jpg" class="image-popup">
                                        <div class="overlay"><h3>Bathroom</h3></div>
                                        <img alt="" src="~/img/properties/property-detail-03.jpg">
                                    </a>
                                </div><!-- /.property-slide -->
                            </div><!-- /.property-carousel -->
                        </section>
                        <div class="row">
                            <div class="col-md-4 col-sm-12">
                                <section id="quick-summary" class="clearfix">
                                    <header><h2>Quick Summary</h2></header>
                                    <dl>
                                        <dt>Location:</dt>
                                        <dd>Cape Town, Western Cape</dd>
                                        <dt>Auction Date:</dt>
                                        <dd>15 May at 11:00</dd>
                                        <dt>Property Type:</dt>
                                        <dd>House</dd>
                                        <dt>Status:</dt>
                                        <dd>Auction</dd>
                                        <dt>Area:</dt>
                                        <dd>240 m<sup>2</sup></dd>
                                        <dt>Beds:</dt>
                                        <dd>2</dd>
                                        <dt>Baths:</dt>
                                        <dd>2</dd>
                                        <dt>Garages:</dt>
                                        <dd>0</dd>
                                    </dl>
                                </section><!-- /#quick-summary -->
                            </div><!-- /.col-md-4 -->
                            <div class="col-md-8 col-sm-12">
                                <section id="description">
                                    <header><h2>Property Description</h2></header>
                                    <p>
                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras et dui vestibulum,
                                        bibendum purus sit amet, vulputate mauris. Ut adipiscing gravida tincidunt.
                                        Duis euismod placerat rhoncus. Phasellus mollis imperdiet placerat. Sed ac
                                        turpis nisl. Mauris at ante mauris. Aliquam posuere fermentum lorem, a aliquam
                                        mauris rutrum a. Curabitur sit amet pretium lectus, nec consequat orci.
                                    </p>
                                    <p>
                                        Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos
                                        himenaeos. Duis et metus in libero sollicitudin venenatis eu sed enim. Nam felis
                                        lorem, suscipit ac nisl ac, iaculis dapibus tellus. Cras ante justo, aliquet quis
                                        placerat nec, molestie id turpis. Cras at tincidunt magna. Mauris aliquam sem sit
                                        amet dapibus venenatis. Sed metus orci, tincidunt sed fermentum non, ornare non quam.
                                        Aenean nec turpis at libero lobortis pretium.
                                    </p>
                                </section><!-- /#description -->
                                <section id="property-features">
                                    <header><h2>Property Description</h2></header>
                                    <ul class="list-unstyled property-features-list">
                                        <li>Sauna</li>
                                        <li>Fireplace or fire pit</li>
                                        <li>Outdoor Kitchen</li>
                                        <li>Tennis Courts</li>
                                        <li>Trees and Landscaping</li>
                                        <li>Sun Room</li>
                                        <li>Family Room</li>
                                        <li>Concrete Flooring</li>
                                    </ul>
                                </section><!-- /#property-features -->
                                <section id="floor-plans">
                                    <div class="floor-plans">
                                        <header><h2>Floor Plans</h2></header>
                                        <a href="~/img/properties/floor-plan-big.jpg" class="image-popup"><img alt="" src="~/img/properties/floor-plan-01.jpg"></a>
                                        <a href="~/img/properties/floor-plan-big.jpg" class="image-popup"><img alt="" src="~/img/properties/floor-plan-02.jpg"></a>
                                    </div>
                                </section><!-- /#floor-plans -->
                                <section id="property-map">
                                    <header><h2>Map</h2></header>
                                    <div class="property-detail-map-wrapper">
                                        <div class="property-detail-map" id="property-detail-map"></div>
                                    </div>
                                </section><!-- /#property-map -->
                                <section id="property-rating">
                                    <header><h2>Rating</h2></header>
                                    <div class="clearfix">
                                        <aside>
                                            <header>Your Rating</header>
                                            <div class="rating rating-user">
                                                <div class="inner"></div>
                                            </div>
                                        </aside>
                                        <figure>
                                            <header>Overall Rating</header>
                                            <div class="rating rating-overall" data-score="4"></div>
                                        </figure>
                                    </div>
                                    <div class="rating-form">
                                        <header>Thank you! Please describe your rating</header>
                                        <form role="form" id="form-rating" method="post" class="clearfix">
                                            <div class="row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label for="form-rating-name">Your Name<em>*</em></label>
                                                        <input type="text" class="form-control" id="form-rating-name" name="form-rating-name" required>
                                                    </div><!-- /.form-group -->
                                                </div><!-- /.col-md-6 -->
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label for="form-rating-email">Your Email<em>*</em></label>
                                                        <input type="email" class="form-control" id="form-rating-email" name="form-rating-email" required>
                                                    </div><!-- /.form-group -->
                                                </div><!-- /.col-md-6 -->
                                            </div><!-- /.row -->
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <div class="form-group">
                                                        <label for="form-rating-message">Your Message<em>*</em></label>
                                                        <textarea class="form-control" id="form-rating-message" rows="6" name="form-rating-message" required></textarea>
                                                    </div><!-- /.form-group -->
                                                </div><!-- /.col-md-12 -->
                                            </div><!-- /.row -->
                                            <div class="form-group">
                                                <button type="submit" class="btn pull-right btn-default" id="form-rating-submit">Send a Message</button>
                                            </div><!-- /.form-group -->
                                            <div id="form-rating-status"></div>
                                        </form><!-- /#form-contact -->
                                    </div><!-- /.rating-form -->
                                </section><!-- /#property-rating -->
                                <section id="video-presentation">
                                    <header><h2>Video Presentation</h2></header>
                                    <div class="video">
                                        <iframe src="//player.vimeo.com/video/34741214?title=0&amp;byline=0&amp;portrait=0&amp;color=ffffff" width="500" height="281"></iframe>
                                    </div>
                                </section><!-- /#video-presentation -->
                            </div><!-- /.col-md-8 -->
                            <div class="col-md-12 col-sm-12">
                                <section id="contact-agent">
                                    <header><h2>Contact Agent</h2></header>
                                    <div class="row">
                                        <section class="agent-form">
                                            <div class="col-md-7 col-sm-12">
                                                <aside class="agent-info clearfix">
                                                    <figure><a href="agent-detail.html"><img alt="" src="assets/img/agent-01.jpg"></a></figure>
                                                    <div class="agent-contact-info">
                                                        <h3>John Doe</h3>
                                                        <p>
                                                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras et dui vestibulum,
                                                            bibendum purus sit amet, vulputate mauris. Ut adipiscing gravida tincidunt.
                                                            Duis euismod placerat rhoncus.
                                                        </p>
                                                        <dl>
                                                            <dt>Phone:</dt>
                                                            <dd>(123) 456 789</dd>
                                                            <dt>Mobile:</dt>
                                                            <dd>888 123 456 789</dd>
                                                            <dt>Email:</dt>
                                                            <dd><a href="mailto:#">john.doe@example.com</a></dd>
                                                            <dt>Skype:</dt>
                                                            <dd>john.doe</dd>
                                                        </dl>
                                                        <hr>
                                                        <a href="agent-detail.html" class="link-arrow">Full Profile</a>
                                                    </div>
                                                </aside><!-- /.agent-info -->
                                            </div><!-- /.col-md-7 -->
                                            <div class="col-md-5 col-sm-12">
                                                <div class="agent-form">
                                                    <form role="form" id="form-contact-agent" method="post" class="clearfix">
                                                        <div class="form-group">
                                                            <label for="form-contact-agent-name">Your Name<em>*</em></label>
                                                            <input type="text" class="form-control" id="form-contact-agent-name" name="form-contact-agent-name" required>
                                                        </div><!-- /.form-group -->
                                                        <div class="form-group">
                                                            <label for="form-contact-agent-email">Your Email<em>*</em></label>
                                                            <input type="email" class="form-control" id="form-contact-agent-email" name="form-contact-agent-email" required>
                                                        </div><!-- /.form-group -->
                                                        <div class="form-group">
                                                            <label for="form-contact-agent-message">Your Message<em>*</em></label>
                                                            <textarea class="form-control" id="form-contact-agent-message" rows="2" name="form-contact-agent-message" required></textarea>
                                                        </div><!-- /.form-group -->
                                                        <div class="form-group">
                                                            <button type="submit" class="btn pull-right btn-default" id="form-contact-agent-submit">Send a Message</button>
                                                        </div><!-- /.form-group -->
                                                        <div id="form-contact-agent-status"></div>
                                                    </form><!-- /#form-contact -->
                                                </div><!-- /.agent-form -->
                                            </div><!-- /.col-md-5 -->
                                        </section><!-- /.agent-form -->
                                    </div><!-- /.row -->
                                </section><!-- /#contact-agent -->
                            </div><!-- /.col-md-12 -->
                        </div><!-- /.row -->
                    </section><!-- /#property-detail -->
                </div><!-- /.col-md-9 -->
                <!-- end Property Detail Content -->
                <!-- sidebar -->
                <div class="col-md-3 col-sm-3">
                    <section id="sidebar">
                        <aside id="edit-search">
                            <header><h3>Search Properties</h3></header>
                            <form role="form" id="form-sidebar" class="form-search" action="properties-listing.html">
                                <div class="form-group">
                                    <select name="type">
                                        <option value="">Status</option>
                                        <option value="1">Auction</option>
                                        <option value="2">For Sale</option>
                                    </select>
                                </div><!-- /.form-group -->
                                <div class="form-group">
                                    <select name="country">
                                        <option value="">Country</option>
                                        <option value="1">South Africa</option>
                                    </select>
                                </div><!-- /.form-group -->
                                <div class="form-group">
                                    <select name="city">
                                        <option value="">City</option>
                                        <option value="1">Johannesburg</option>
                                        <option value="2">Pretoria</option>
                                        <option value="3">Cape Town</option>
                                        <option value="4">Durban</option>
                                        <option value="5">Nelspruit</option>
                                    </select>
                                </div><!-- /.form-group -->
                                <div class="form-group">
                                    <select name="district">
                                        <option value="">Province</option>
                                        <option value="1">Gauteng</option>
                                        <option value="2">Free State</option>
                                        <option value="3">Mpumalanga</option>
                                        <option value="4">Limpopo</option>
                                        <option value="5">North West</option>
                                        <option value="6">Kwazulu Natal</option>
                                        <option value="7">Western Cape</option>
                                        <option value="8">Northern Cape</option>
                                        <option value="9">Eastern Cape</option>
                                    </select>
                                </div><!-- /.form-group -->
                                <div class="form-group">
                                    <select name="property-type">
                                        <option value="">Property Type</option>
                                        <option value="1">Residential</option>
                                        <option value="2">Commercial</option>
                                        <option value="3">Agricultural</option>
                                        <option value="4">Investment</option>
                                    </select>
                                </div><!-- /.form-group -->
                                <div class="form-group">
                                    <button type="submit" class="btn btn-default">Search Now</button>
                                </div><!-- /.form-group -->
                            </form><!-- /#form-map -->
                        </aside><!-- /#edit-search -->
                        <aside id="featured-properties">
                            <header><h3>Featured Properties</h3></header>
                            <div class="property small">
                                <a href="property-detail.html">
                                    <div class="property-image">
                                        <img alt="" src="~/img/properties/property-08.jpg">
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
                                        <img alt="" src="~/img/properties/property-08.jpg">
                                    </div>
                                </a>
                                <div class="info">
                                    <a href="property-detail.html"><h4>249 Murphy Court</h4></a>
                                    <figure>Sandhurst, Johannesburg</figure>
                                    <div class="tag price">22 June at 14:00</div>
                                </div>
                            </div><!-- /.property -->
                            <div class="property small">
                                <a href="property-detail.html">
                                    <div class="property-image">
                                        <img alt="" src="~/img/properties/property-08.jpg">
                                    </div>
                                </a>
                                <div class="info">
                                    <a href="property-detail.html"><h4>194 Tennessee Avenue</h4></a>
                                    <figure>Faerie Glen, Pretoria</figure>
                                    <div class="tag price">22 June at 15:00</div>
                                </div>
                            </div><!-- /.property -->
                        </aside><!-- /#featured-properties -->
                        <aside id="our-guides">
                            <header><h3>Our Guides</h3></header>
                            <a href="#" class="universal-button">
                                <figure class="fa fa-home"></figure>
                                <span>Buyers Guide</span>
                                <span class="arrow fa fa-angle-right"></span>
                            </a><!-- /.universal-button -->
                            <a href="#" class="universal-button">
                                <figure class="fa fa-home"></figure>
                                <span>Sellers Guide</span>
                                <span class="arrow fa fa-angle-right"></span>
                            </a><!-- /.universal-button -->
                        </aside><!-- /#our-guide -->
                    </section><!-- /#sidebar -->
                </div><!-- /.row -->
            </div><!-- /.container -->
        </div>
        <!-- end Page Content -->
    </div>

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
    <!--[if gt IE 8]>
    <script type="text/javascript" src="assets/js/ie.js"></script>
    <![endif]-->
    <script type="text/javascript">
        var propertyId = 0;
        google.maps.event.addDomListener(window, 'load', initMap(propertyId));
        $(window).load(function () {
            initializeOwl(false);
        });
    </script>

</body>
</html>