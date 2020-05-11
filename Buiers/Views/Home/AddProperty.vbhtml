﻿@Code
    ViewData("Title") = "AddProperty"
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

<!DOCTYPE html>

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

    <title>Auction-Prop.com | Add Your Property</title>

</head>

<body class="page-sub-page page-submit" id="page-top">
    <!-- Page Content -->
    <div id="page-content">
        <!-- Breadcrumb -->
        <div class="container">
            <ol class="breadcrumb">
                <li><a href="#">Home</a></li>
                <li class="active">Add your property</li>
            </ol>
        </div>
        <!-- end Breadcrumb -->

        <div class="container">
            <header><h1>Add Your Property</h1></header>
            <div class="row">
                <!-- Submit-->
                <div class="col-md-9 col-sm-9">
                    <section id="submit" class="submit">
                        <section id="select-package">
                            <div class="table-responsive submit-pricing">
                                <table class="table">
                                    <thead>
                                        <tr>
                                            <th>Your Package:</th>
                                            <th class="title">Bronze</th>
                                            <th class="title">Silver</th>
                                            <th class="title">Gold</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr class="prices">
                                            <td></td>
                                            <td>R500</td>
                                            <td>R995</td>
                                            <td>R2000</td>
                                        </tr>
                                        <tr>
                                            <td>Property Submit Limit</td>
                                            <td>1</td>
                                            <td>20</td>
                                            <td>Unlimited</td>
                                        </tr>
                                        <tr>
                                            <td>Agent Profiles</td>
                                            <td>1</td>
                                            <td>10</td>
                                            <td>Unlimited</td>
                                        </tr>
                                        <tr>
                                            <td>Agency Profiles</td>
                                            <td class="not-available"><i class="fa fa-times"></i></td>
                                            <td>5</td>
                                            <td>Unlimited</td>
                                        </tr>
                                        <tr>
                                            <td>Featured Properties</td>
                                            <td class="not-available"><i class="fa fa-times"></i></td>
                                            <td class="available"><i class="fa fa-check"></i></td>
                                            <td class="available"><i class="fa fa-check"></i></td>
                                        </tr>
                                        <tr class="buttons">
                                            <td></td>
                                            <td class="package-selected" data-package="free"><button type="button" class="btn btn-default small">Select</button></td>
                                            <td data-package="silver"><button type="button" class="btn btn-default small">Select</button></td>
                                            <td data-package="gold"><button type="button" class="btn btn-default small">Select</button></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div><!-- /.submit-pricing -->
                        </section><!-- /#select-package -->
                    </section><!-- /#submit -->
                </div><!-- /.col-md-9 -->
                <aside class="col-md-3 col-sm-3">
                    <div class="submit-step">
                        <figure class="step-number">1</figure>
                        <div class="description">
                            <h4>Select Your Price Package</h4>
                            <p>
                                Choose a price package that would suit your needs. If you have chosen package before,
                                it will be automatically selected.
                            </p>
                        </div>
                    </div><!-- /.submit-step -->
                </aside><!-- /.col-md-3 -->
            </div><!-- /.row -->
            <form role="form" id="form-submit" class="form-submit" action="thank-you.html">
                <div class="row">
                    <div class="block">
                        <div class="col-md-9 col-sm-9">
                            <section id="submit-form">
                                <section id="basic-information">
                                    <header><h2>Basic Information</h2></header>
                                    <div class="row">
                                        <div class="col-md-8">
                                            <div class="form-group">
                                                <label for="submit-title">Title</label>
                                                <input type="text" class="form-control" id="submit-title" name="title" required>
                                            </div><!-- /.form-group -->
                                        </div>
                                        <div class="col-md-4">
                                            <div class="form-group">
                                                <label for="submit-price">Price</label>
                                                <div class="input-group">
                                                    <span class="input-group-addon">R</span>
                                                    <input type="text" class="form-control" id="submit-price" name="price" pattern="\d*" required>
                                                </div>
                                            </div><!-- /.form-group -->
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="submit-description">Description</label>
                                        <textarea class="form-control" id="submit-description" rows="8" name="submit-description" required></textarea>
                                    </div><!-- /.form-group -->
                                </section><!-- /#basic-information -->

                                <section>
                                    <div class="row">
                                        <div class="block clearfix">
                                            <div class="col-md-6 col-sm-6">
                                                <section id="summary">
                                                    <header><h2>Summary</h2></header>
                                                    <div class="form-group">
                                                        <label for="submit-location">Province</label>
                                                        <select name="type" id="submit-location">
                                                            <option value="1">Free State</option>
                                                            <option value="2">Gauteng</option>
                                                            <option value="3">Limpopo</option>
                                                            <option value="4">Mpumalanga</option>
                                                            <option value="5">North West</option>
                                                            <option value="6">Kwazulu-Natal</option>
                                                            <option value="7">Eastern Cape</option>
                                                            <option value="8">Northern Cape</option>
                                                            <option value="9">Western Cape</option>
                                                        </select>
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="submit-location">Town/City</label>
                                                        <select name="type" id="submit-location">
                                                            <option value="1">Johannesburg</option>
                                                            <option value="2">Pretoria</option>
                                                            <option value="3">Bloemfontein</option>
                                                            <option value="4">Nelspruit</option>
                                                            <option value="5">Polokwane</option>
                                                            <option value="6">Durban</option>
                                                            <option value="7">Cape Town</option>
                                                            <option value="8">Port Elizabath</option>
                                                        </select>
                                                    </div>
                                                    <div class="row">
                                                        <div class="col-md-6 col-sm-6">
                                                            <div class="form-group">
                                                                <label for="submit-property-type">Property Type</label>
                                                                <select name="type" id="submit-property-type">
                                                                    <option value="1">House</option>
                                                                    <option value="2">Apartment</option>
                                                                    <option value="3">Town House</option>
                                                                    <option value="4">Farm</option>
                                                                    <option value="5">Office</option>
                                                                </select>
                                                            </div><!-- /.form-group -->
                                                        </div><!-- /.col-md-6 -->
                                                        <div class="col-md-6 col-sm-6">
                                                            <div class="form-group">
                                                                <label for="submit-status">Status</label>
                                                                <select name="type" id="submit-status">
                                                                    <option value="1">For Sale</option>
                                                                    <option value="2">On Auction</option>
                                                                </select>
                                                            </div><!-- /.form-group -->
                                                        </div><!-- /.col-md-6 -->
                                                    </div><!-- /.row -->
                                                    <div class="row">
                                                        <div class="col-md-6 col-sm-6">
                                                            <div class="form-group">
                                                                <label for="submit-Beds">Beds</label>
                                                                <input type="text" class="form-control" id="submit-Beds" name="Beds" pattern="\d*" required>
                                                            </div><!-- /.form-group -->
                                                        </div><!-- /.col-md-6 -->
                                                        <div class="col-md-6 col-sm-6">
                                                            <div class="form-group">
                                                                <label for="submit-Baths">Baths</label>
                                                                <input type="text" class="form-control" id="submit-Baths" name="Baths" pattern="\d*" required>
                                                            </div><!-- /.form-group -->
                                                        </div><!-- /.col-md-6 -->
                                                    </div><!-- /.row -->
                                                    <div class="row">
                                                        <div class="col-md-6 col-sm-6">
                                                            <div class="form-group">
                                                                <label for="submit-area">Area</label>
                                                                <div class="input-group">
                                                                    <input type="text" class="form-control" id="submit-area" name="area" pattern="\d*" required>
                                                                    <span class="input-group-addon">m<sup>2</sup></span>
                                                                </div>
                                                            </div><!-- /.form-group -->
                                                        </div><!-- /.col-md-6 -->
                                                        <div class="col-md-6 col-sm-6">
                                                            <div class="form-group">
                                                                <label for="submit-garages">Garages</label>
                                                                <input type="text" class="form-control" id="submit-garages" name="garages" pattern="\d*" required>
                                                            </div><!-- /.form-group -->
                                                        </div><!-- /.col-md-6 -->
                                                    </div><!-- /.row -->
                                                    <div class="checkbox">
                                                        <label>
                                                            <input type="checkbox">Allow user rating <i class="fa fa-question-circle tool-tip" data-toggle="tooltip" data-placement="right" title="Users can give you a stars rating which is displayed in property detail"></i>
                                                        </label>
                                                    </div>
                                                </section><!-- /#summary -->
                                            </div><!-- /.col-md-6 -->
                                            <div class="col-md-6 col-sm-6">
                                                <section id="place-on-map">
                                                    <header class="section-title">
                                                        <h2>Place on Map</h2>
                                                        <span class="link-arrow geo-location">Get My Position</span>
                                                    </header>
                                                    <div class="form-group">
                                                        <label for="address-map">Address</label>
                                                        <input type="text" class="form-control" id="address-map" name="address">
                                                    </div><!-- /.form-group -->
                                                    <label for="address-map">Or drag the marker to property position</label>
                                                    <div id="submit-map"></div>
                                                    <div class="row">
                                                        <div class="col-md-6">
                                                            <div class="form-group">
                                                                <input type="text" class="form-control" id="latitude" name="latitude" readonly>
                                                            </div><!-- /.form-group -->
                                                        </div>
                                                        <div class="col-md-6">
                                                            <div class="form-group">
                                                                <input type="text" class="form-control" id="longitude" name="longitude" readonly>
                                                            </div><!-- /.form-group -->
                                                        </div>
                                                    </div>
                                                </section><!-- /#place-on-map -->
                                            </div><!-- /.col-md-6 -->
                                        </div><!-- /.block -->
                                    </div><!-- /.row -->
                                </section>

                                <section class="block" id="gallery">
                                    <header><h2>Gallery</h2></header>
                                    <div class="center">
                                        <div class="form-group">
                                            <input id="file-upload" type="file" class="file" multiple="true" data-show-upload="false" data-show-caption="false" data-show-remove="false" accept="image/jpeg,image/png" data-browse-class="btn btn-default" data-browse-label="Browse Images">
                                            <figure class="note"><strong>Hint:</strong> You can upload all images at once!</figure>
                                        </div>
                                    </div>
                                </section>

                                <section id="property-features" class="block">
                                    <section>
                                        <header><h2>Property Features</h2></header>
                                        <ul class="submit-features">
                                            <li><div class="checkbox"><label><input type="checkbox">Air conditioning</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Fibre Connection</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Staff Quaters</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Pets allowed</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Pool</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Smoking allowed</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Garden</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Balcony</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Garage</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Cable TV</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Parquet</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Roof terrace</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Terrace</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Balcony</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Iron</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Hi-Fi</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Beach</label></div></li>
                                            <li><div class="checkbox"><label><input type="checkbox">Garage</label></div></li>
                                        </ul>
                                    </section>
                                </section>
                                <hr>
                            </section>
                        </div><!-- /.col-md-9 -->
                        <div class="col-md-3 col-sm-3">
                            <aside class="submit-step">
                                <figure class="step-number">2</figure>
                                <div class="description">
                                    <h4>Enter Information About Your Property</h4>
                                    <p>
                                        Supply as much information about your property as possible. Be descriptive.
                                    </p>
                                </div>
                            </aside><!-- /.submit-step -->
                        </div><!-- /.col-md-3 -->
                    </div>
                </div><!-- /.row -->
                <div class="row">
                    <div class="block">
                        <div class="col-md-9 col-sm-9">
                            <div class="center">
                                <div class="form-group">
                                    <button type="submit" class="btn btn-default large">Submit Your Property</button>
                                </div><!-- /.form-group -->
                                <figure class="note block">By clicking the “Submit” button you agree with our <a href="terms-conditions.html">Terms and conditions</a></figure>
                            </div>
                        </div>
                        <div class="col-md-3 col-sm-3">
                            <aside class="submit-step">
                                <figure class="step-number">3</figure>
                                <div class="description">
                                    <h4>Review the Information and Proceed to Submit your Property</h4>
                                    <p>
                                        Carefully check entered information and then click the "Submit Your Property" button to submit and proceed with pyament.
                                    </p>
                                </div>
                            </aside><!-- /.submit-step -->
                        </div><!-- /.col-md-3 -->
                    </div>
                </div>
            </form><!-- /#form-submit -->
        </div><!-- /.container -->
    </div>
    <!-- end Page Content -->

    <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false&libraries=places"></script>
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