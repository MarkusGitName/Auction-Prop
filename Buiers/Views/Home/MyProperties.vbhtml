﻿@Code
    ViewData("Title") = "MyProperties"
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

    <title>Auction-Prop.com | My Properties</title>

</head>

<body class="page-sub-page page-my-properties page-account" id="page-top">
    <!-- Page Content -->
    <div id="page-content">
        <!-- Breadcrumb -->
        <div class="container">
            <ol class="breadcrumb">
                <li><a href="#">Home</a></li>
                <li><a href="#">Account</a></li>
                <li class="active">My Properties</li>
            </ol>
        </div>
        <!-- end Breadcrumb -->

        <div class="container">
            <div class="row">
                <!-- sidebar -->
                <div class="col-md-3 col-sm-2">
                    <section id="sidebar">
                        <header><h3>Account</h3></header>
                        <aside>
                            <ul class="sidebar-navigation">
                                <li><a href="profile.html"><i class="fa fa-user"></i><span>Profile</span></a></li>
                                <li class="active"><a href="my-properties.html"><i class="fa fa-home"></i><span>My Properties</span></a></li>
                                <li><a href="bookmarked.html"><i class="fa fa-heart"></i><span>Bookmarked Properties</span></a></li>
                            </ul>
                        </aside>
                    </section><!-- /#sidebar -->
                </div><!-- /.col-md-3 -->
                <!-- end Sidebar -->
                <!-- My Properties -->
                <div class="col-md-9 col-sm-10">
                    <section id="my-properties">
                        <header><h1>My Properties</h1></header>
                        <div class="my-properties">
                            <div class="table-responsive">
                                <table class="table">
                                    <thead>
                                        <tr>
                                            <th>Property</th>
                                            <th></th>
                                            <th>Date Added</th>
                                            <th>Views</th>
                                            <th>Actions</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td class="image">
                                                <a href="property-detail.html"><img alt="" src="~/img/properties/property-04.jpg"></a>
                                            </td>
                                            <td>
                                                <div class="inner">
                                                    <a href="property-detail.html"><h2>987 Cantebury Drive</h2></a>
                                                    <figure>Golden Valley, MN 55427</figure>
                                                    <div class="tag date">10 May at 11:00am</div>
                                                </div>
                                            </td>
                                            <td>01.05.2020</td>
                                            <td>236</td>
                                            <td class="actions">
                                                <a href="#" class="edit"><i class="fa fa-pencil"></i>Edit</a>
                                                <a href="#"><i class="delete fa fa-trash-o"></i></a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="image">
                                                <a href="property-detail.html"><img alt="" src="~/img/properties/property-02.jpg"></a>
                                            </td>
                                            <td>
                                                <div class="inner">
                                                    <a href="property-detail.html"><h2>3398 Lodgeville Road</h2></a>
                                                    <figure>Golden Valley, MN 55427</figure>
                                                    <div class="tag date">15 May at 11:00am</div>
                                                </div>
                                            </td>
                                            <td>06.05.2020</td>
                                            <td>662</td>
                                            <td class="actions">
                                                <a href="#" class="edit"><i class="fa fa-pencil"></i>Edit</a>
                                                <a href="#"><i class="delete fa fa-trash-o"></i></a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="image">
                                                <a href="property-detail.html"><img alt="" src="~/img/properties/property-01.jpg"></a>
                                            </td>
                                            <td>
                                                <div class="inner">
                                                    <a href="property-detail.html"><h2>1179 Stroop Hill Road</h2></a>
                                                    <figure>Atlanta, GA 30309</figure>
                                                    <div class="tag date">20 May at 11:00am</div>
                                                </div>
                                            </td>
                                            <td>06.05.2020</td>
                                            <td>85</td>
                                            <td class="actions">
                                                <a href="#" class="edit"><i class="fa fa-pencil"></i>Edit</a>
                                                <a href="#"><i class="delete fa fa-trash-o"></i></a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="image">
                                                <a href="property-detail.html"><img alt="" src="~/img/properties/property-06.jpg"></a>
                                            </td>
                                            <td>
                                                <div class="inner">
                                                    <a href="property-detail.html"><h2>1028 Henery Street</h2></a>
                                                    <figure>Wichita, KS 67202</figure>
                                                    <div class="tag date">26 May at 11:00am</div>
                                                </div>
                                            </td>
                                            <td>22.05.2020</td>
                                            <td>357</td>
                                            <td class="actions">
                                                <a href="#" class="edit"><i class="fa fa-pencil"></i>Edit</a>
                                                <a href="#"><i class="delete fa fa-trash-o"></i></a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="image">
                                                <a href="property-detail.html"><img alt="" src="~/img/properties/property-07.jpg"></a>
                                            </td>
                                            <td>
                                                <div class="inner">
                                                    <a href="property-detail.html"><h2>4068 Diamond Street</h2></a>
                                                    <figure>Charlotte, NC 28217 </figure>
                                                    <div class="tag date">27 May at 11:00am</div>
                                                </div>
                                            </td>
                                            <td>23.05.2020</td>
                                            <td>456</td>
                                            <td class="actions">
                                                <a href="#" class="edit"><i class="fa fa-pencil"></i>Edit</a>
                                                <a href="#"><i class="delete fa fa-trash-o"></i></a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="image">
                                                <a href="property-detail.html"><img alt="" src="~/img/properties/property-08.jpg"></a>
                                            </td>
                                            <td>
                                                <div class="inner">
                                                    <a href="property-detail.html"><h2>2088 May Street</h2></a>
                                                    <figure>Somerset, KY 42503 </figure>
                                                    <div class="tag date">05 June at 11:00am</div>
                                                </div>
                                            </td>
                                            <td>28.05.2020</td>
                                            <td>267</td>
                                            <td class="actions">
                                                <a href="#" class="edit"><i class="fa fa-pencil"></i>Edit</a>
                                                <a href="#"><i class="delete fa fa-trash-o"></i></a>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div><!-- /.table-responsive -->
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
                        </div><!-- /.my-properties -->
                    </section><!-- /#my-properties -->
                </div><!-- /.col-md-9 -->
                <!-- end My Properties -->
            </div><!-- /.row -->
        </div><!-- /.container -->
    </div>
    <!-- end Page Content -->

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