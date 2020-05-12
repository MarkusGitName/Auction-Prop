﻿@Code
    ViewData("Title") = "Properties"
End Code
@*
@Styles.Render("~/Content/bootstrap.css")
@Styles.Render("~/Content/StyleSheet1.css")
@Styles.Render("~/Content2/bootstrap-select.min.css")
@Styles.Render("~/Content2/magnific-popup.css")
@Scripts.Render("~/Scripts2/bootstrap-select.min.js")
@Scripts.Render("~/Scripts2/bootstrap.min.js")
@Scripts.Render("~/Scripts2/custom.js")
@Scripts.Render("~/Scripts2/jquery-2.1.0.min.js")
*@
<!DOCTYPE html>

<html lang="en-US">
<head>

    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <link href='http://fonts.googleapis.com/css?family=Roboto:300,400,700' rel='stylesheet' type='text/css'>
    <script src="https://kit.fontawesome.com/ef4e2c1ac6.js" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="~/Content/bootstrap.css" type="text/css">
    <link rel="stylesheet" href="assets/css/bootstrap-select.min.css" type="text/css">
    <link rel="stylesheet" href="~/Content2/magnific-popup.css" type="text/css">
    <link rel="stylesheet" href="~/Content2/jquery.slider.min.css" type="text/css">
    <link rel="stylesheet" href="~/Content2/owl.carousel.css" type="text/css">
    <link rel="stylesheet" href="~/Content/StyleSheet1.css" type="text/css">

    <title>Auction-Prop.com | Auctions Listings</title>

</head>
<body>
    <!-- Page Content -->
    <div id="page-content">
        <!-- Breadcrumb -->
        <div class="container">
            <ol class="breadcrumb">
                <li><a href="#">Home</a></li>
                <li class="active">Auction Listings</li>
            </ol>
        </div>
        <!-- end Breadcrumb -->

        <div class="container">
            <div class="row">
                <!-- Results -->
                <div class="col-md-9 col-sm-9">
                    <section id="results">
                        <header><h1>Auction Listings</h1></header>
                        <section id="search-filter">
                            <figure>
                                <h3><i class="fa fa-search"></i>Search Results:</h3>
                                <span class="search-count">28</span>
                                <div class="sorting">
                                    <div class="form-group">
                                        <select name="sorting">
                                            <option value="">Sort By</option>
                                            <option value="1">Lowest price first</option>
                                            <option value="2">Highest price first</option>
                                            <option value="3">Date added</option>
                                        </select>
                                    </div><!-- /.form-group -->
                                </div>
                            </figure>
                        </section>
                        <section id="properties">
                            <div class="row">
                                <div class="col-md-4 col-sm-4">
                                    <div class="property equal-height">
                                        <a href="property-detail-page.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>338 Lodgeville Road</h3>
                                                    <figure>Newlands, Cape Town</figure>
                                                    <div class="tag price">15 May at 11:00</div>
                                                </div>
                                                <ul class="additional-info">
                                                    <li>
                                                        <header>Size:</header>
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
                                <div class="col-md-4 col-sm-4">
                                    <div class="property equal-height">
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>218 Rinehart Road</h3>
                                                    <figure>Olivedale, Johannesburg </figure>
                                                    <div class="tag price">15 May at 14:00</div>
                                                </div>
                                                <ul class="additional-info">
                                                    <li>
                                                        <header>Size:</header>
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
                                <div class="col-md-4 col-sm-4">
                                    <div class="property equal-height">
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>370 Brighton Circle Road</h3>
                                                    <figure>Glenwood East, Durban</figure>
                                                    <div class="tag price">19 May at 12:00</div>
                                                </div>
                                                <ul class="additional-info">
                                                    <li>
                                                        <header>Size:</header>
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
                            <div class="row">
                                <div class="col-md-4 col-sm-4">
                                    <div class="property">
                                        <figure class="tag status">Recently Listed</figure>
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>250B Harrow Street</h3>
                                                    <figure>Garsfontein, Pretoria</figure>
                                                    <div class="tag price">22 May at 11:00</div>
                                                </div>
                                                <ul class="additional-info">
                                                    <li>
                                                        <header>Size:</header>
                                                        <figure>280m<sup>2</sup></figure>
                                                    </li>
                                                    <li>
                                                        <header>Beds:</header>
                                                        <figure>3</figure>
                                                    </li>
                                                    <li>
                                                        <header>Baths:</header>
                                                        <figure>2</figure>
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
                                <div class="col-md-4 col-sm-4">
                                    <div class="property">
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>36 via Veneto</h3>
                                                    <figure>Lombardy Estate, Pretoria</figure>
                                                    <div class="tag price">24 May at 12:00</div>
                                                </div>
                                                <ul class="additional-info">
                                                    <li>
                                                        <header>Size:</header>
                                                        <figure>30m<sup>2</sup></figure>
                                                    </li>
                                                    <li>
                                                        <header>Beds:</header>
                                                        <figure>1</figure>
                                                    </li>
                                                    <li>
                                                        <header>Baths:</header>
                                                        <figure>1</figure>
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
                                <div class="col-md-4 col-sm-4">
                                    <div class="property">
                                        <figure class="tag status">Recently Listed</figure>
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>297 Olive-Bee Eater Cres</h3>
                                                    <figure>Olympus, Pretoria </figure>
                                                    <div class="tag price">24 May at 14:00</div>
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
                            <div class="row">
                                <div class="col-md-4 col-sm-4">
                                    <div class="property">
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>266 West Avenue</h3>
                                                    <figure>Houhton, Johannesburg</figure>
                                                    <div class="tag price">28 May at 11:00</div>
                                                </div>
                                                <ul class="additional-info">
                                                    <li>
                                                        <header>Size:</header>
                                                        <figure>280m<sup>2</sup></figure>
                                                    </li>
                                                    <li>
                                                        <header>Beds:</header>
                                                        <figure>3</figure>
                                                    </li>
                                                    <li>
                                                        <header>Baths:</header>
                                                        <figure>2</figure>
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
                                <div class="col-md-4 col-sm-4">
                                    <div class="property">
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>18 Stormberg Street</h3>
                                                    <figure>Midrand, Johannesburg</figure>
                                                    <div class="tag price">28 May at 14:00</div>
                                                </div>
                                                <ul class="additional-info">
                                                    <li>
                                                        <header>Size:</header>
                                                        <figure>30m<sup>2</sup></figure>
                                                    </li>
                                                    <li>
                                                        <header>Beds:</header>
                                                        <figure>1</figure>
                                                    </li>
                                                    <li>
                                                        <header>Baths:</header>
                                                        <figure>1</figure>
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
                                <div class="col-md-4 col-sm-4">
                                    <div class="property">
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>138 Sundown Lane</h3>
                                                    <figure>Mooikloof, Pretoria</figure>
                                                    <div class="tag price">01 June at 11:00</div>
                                                </div>
                                                <ul class="additional-info">
                                                    <li>
                                                        <header>Size:</header>
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
                            <section id="advertising">
                                <a href="submit.html">
                                    <div class="banner">
                                        <div class="wrapper">
                                            <span class="title">Do you want your property to be listed here?</span>
                                            <span class="submit">Contact us now! <i class="fa fa-plus-square"></i></span>
                                        </div>
                                    </div><!-- /.banner-->
                                </a>
                            </section><!-- /#adveritsing-->
                            <div class="row">
                                <div class="col-md-4 col-sm-4">
                                    <div class="property">
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>486 Olympus Drive</h3>
                                                    <figure>Olympus, Pretoria</figure>
                                                    <div class="tag price">12 June at 11:00</div>
                                                </div>
                                                <ul class="additional-info">
                                                    <li>
                                                        <header>Size:</header>
                                                        <figure>280m<sup>2</sup></figure>
                                                    </li>
                                                    <li>
                                                        <header>Beds:</header>
                                                        <figure>3</figure>
                                                    </li>
                                                    <li>
                                                        <header>Baths:</header>
                                                        <figure>2</figure>
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
                                <div class="col-md-4 col-sm-4">
                                    <div class="property">
                                        <figure class="tag status">Rencently Listed</figure>
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>53 Oxpecker Street</h3>
                                                    <figure>Riverside Park, Nelspruit</figure>
                                                    <div class="tag price">19 June at 11:00</div>
                                                </div>
                                                <ul class="additional-info">
                                                    <li>
                                                        <header>Size:</header>
                                                        <figure>30m<sup>2</sup></figure>
                                                    </li>
                                                    <li>
                                                        <header>Beds:</header>
                                                        <figure>1</figure>
                                                    </li>
                                                    <li>
                                                        <header>Baths:</header>
                                                        <figure>1</figure>
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
                                <div class="col-md-4 col-sm-4">
                                    <div class="property">
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>23 Park Street</h3>
                                                    <figure>Riverside Park, Nelspruit </figure>
                                                    <div class="tag price">19 June at 14:00</div>
                                                </div>
                                                <ul class="additional-info">
                                                    <li>
                                                        <header>Size:</header>
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
                            <div class="row">
                                <div class="col-md-4 col-sm-4">
                                    <div class="property">
                                        <figure class="tag status">Recently Listed</figure>
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>98 Lodgeville Road</h3>
                                                    <figure>Umhlanga, Kwazulu Natal</figure>
                                                    <div class="tag price">21 June at 11:00</div>
                                                </div>
                                                <ul class="additional-info">
                                                    <li>
                                                        <header>Size:</header>
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
                                <div class="col-md-4 col-sm-4">
                                    <div class="property">
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>21 Ocean Drive</h3>
                                                    <figure>Bloubergstrand, Western Cape </figure>
                                                    <div class="tag price">22 June at 12:00</div>
                                                </div>
                                                <ul class="additional-info">
                                                    <li>
                                                        <header>Size:</header>
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
                                <div class="col-md-4 col-sm-4">
                                    <div class="property">
                                        <a href="property-detail.html">
                                            <div class="property-image">
                                                <img alt="" src="~/img/properties/property-06.jpg">
                                            </div>
                                            <div class="overlay">
                                                <div class="info">
                                                    <h3>337 Vista Drive</h3>
                                                    <figure>Faerie Glen, Pretoria</figure>
                                                    <div class="tag price">22 June at 13:00</div>
                                                </div>
                                                <ul class="additional-info">
                                                    <li>
                                                        <header>Size:</header>
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
                            <!-- Pagination -->
                            <div class="center">
                                <ul class="pagination">
                                    <li class="active"><a href="#">1</a></li>
                                    <li><a href="#">2</a></li>
                                    <li><a href="#">3</a></li>
                                    <li><a href="#">4</a></li>
                                    <li><a href="#">5</a></li>
                                </ul><!-- /.pagination-->
                            </div><!-- /.center-->

                        </section><!-- /#properties-->
                    </section><!-- /#results -->
                </div><!-- /.col-md-9 -->
                <!-- end Results -->
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
                            <div class="property small">
                                <a href="property-detail.html">
                                    <div class="property-image">
                                        <img alt="" src="~/img/properties/property-06.jpg">
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
                <!-- end Sidebar -->
            </div><!-- /.row -->
        </div><!-- /.container -->
    </div>
    <!-- end Page Content -->

    <script type="text/javascript" src="~/Scripts/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="~/Scripts2/jquery-migrate-1.2.1.min.js"></script>
    <script type="text/javascript" src="~/Scripts/bootstrap.min.js"></script>
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

    <script type="text/javascript" src="~/Scripts2/custom.js"></script>

</body>
</html>