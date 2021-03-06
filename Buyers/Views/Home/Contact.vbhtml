﻿@Code
    ViewData("Title") = "Contact"
End Code

@Styles.Render("~/Content/Bootstrap.css")
@Styles.Render("~/Content/StylesOne.css")
@Styles.Render("~/Content/bootstrap-select.min.css")
@Styles.Render("~/Content/magnific-popup.css")
@Scripts.Render("~/Scripts/bootstrap-select.min.js")
@Scripts.Render("~/Scripts/bootstrap.min.js")
@Scripts.Render("~/Scripts/custom.js")
@Scripts.Render("~/jquery-2.1.0.min.js")

<!DOCTYPE html>

<html lang="en-US">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>Auction-Prop | Contact Us</title>

</head>

<body class="page-sub-page page-listing page-grid page-search-results" id="page-top">
        <!-- Page Content -->
        <div id="page-content">
            <!-- Breadcrumb -->
            <div class="container">
                <ol class="breadcrumb">
                    <li><a href="#">Home</a></li>
                    <li class="active">Contact Us</li>
                </ol>
            </div>
            <!-- end Breadcrumb -->

            <div class="container">
                <div class="row">
                    <!-- Contact -->
                    <div class="col-md-9 col-sm-9">
                        <section id="agent-detail">
                            <header><h1>Contact Us</h1></header>
                            <section id="contact-information">
                                <div class="row">
                                    <div class="col-md-4 col-sm-5">
                                        <section id="address">
                                            <header><h3>Address</h3></header>
                                            <address>
                                                <strong>Auction-Prop</strong><br>
                                                Fintech Campus<br>
                                                81 Botterklapper Street<br>
                                                The Willows, 0081
                                            </address>
                                            082 316 3702<br>
                                            <a href="#">info@auction-prop.com</a><br>
                                        </section><!-- /#address -->
                                        <section id="social">
                                            <div class="agent-social">
                                                <a href="#" class="fa fa-twitter btn"></a>
                                                <a href="#" class="fa fa-facebook btn"></a>
                                                <a href="#" class="fa fa-linkedin btn"></a>
                                            </div>
                                        </section><!-- /#social -->
                                    </div><!-- /.col-md-4 -->
                                    <div class="col-md-8 col-sm-7">
                                        <header><h3>Where We Are</h3></header>
                                        <div id="contact-map"></div>
                                    </div><!-- /.col-md-8 -->
                                </div><!-- /.row -->
                            </section><!-- /#agent-info -->
                            <hr class="thick">
                            <section id="form">
                                <header><h3>Send Us a Message</h3></header>
                                <form role="form" id="form-contact" method="post" class="clearfix">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label for="form-contact-name">Your Name<em>*</em></label>
                                                <input type="text" class="form-control" id="form-contact-name" name="form-contact-name" required>
                                            </div><!-- /.form-group -->
                                        </div><!-- /.col-md-6 -->
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label for="form-contact-email">Your Email<em>*</em></label>
                                                <input type="email" class="form-control" id="form-contact-email" name="form-contact-email" required>
                                            </div><!-- /.form-group -->
                                        </div><!-- /.col-md-6 -->
                                    </div><!-- /.row -->
                                    <div class="row">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label for="form-contact-message">Your Message<em>*</em></label>
                                                <textarea class="form-control" id="form-contact-message" rows="8" name="form-contact-message" required></textarea>
                                            </div><!-- /.form-group -->
                                        </div><!-- /.col-md-12 -->
                                    </div><!-- /.row -->
                                    <div class="form-group clearfix">
                                        <button type="submit" class="btn pull-right btn-default" id="form-contact-submit">Send a Message</button>
                                    </div><!-- /.form-group -->
                                    <div id="form-status"></div>
                                </form><!-- /#form-contact -->
                            </section>
                        </section><!-- /#agent-detail -->
                    </div><!-- /.col-md-9 -->
                    <!-- end Contact -->
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
                                            <img alt="" src="Modern House.jpg">
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
                                            <img alt="" src="OfficeSpace.jpg">
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
                                            <img alt="" src="Living Room.jpg">
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
                    </div><!-- /.col-md-3 -->
                    <!-- end Page Content -->
                </div>

</body>
</html>