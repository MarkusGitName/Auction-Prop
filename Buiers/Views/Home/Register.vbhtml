@Code
    ViewData("Title") = "Register"
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

    <title>Auction-Prop | Account Registration</title>

</head>

<body class="page-sub-page page-create-account page-account" id="page-top">
    <!-- Wrapper -->
    <div class="wrapper">
        <!-- Page Content -->
        <div id="page-content">
            <!-- Breadcrumb -->
            <div class="container">
                <ol class="breadcrumb">
                    <li><a href="#">Home</a></li>
                    <li class="active">Create an Account</li>
                </ol>
            </div>
            <!-- end Breadcrumb -->

            <div class="container">
                <header><h1>Create an Account</h1></header>
                <div class="row">
                    <div class="col-md-4 col-sm-6 col-md-offset-4 col-sm-offset-3">
                        <h3>Account Type</h3>
                        <form role="form" id="form-create-account" method="post">
                            <div class="radio" id="create-account-user">
                                <label>
                                    <input type="radio" id="account-type-user" name="account-type" required>Cash Buyer
                                </label>
                            </div>
                            <div class="radio" id="agent-switch" data-agent-state="">
                                <label>
                                    <input type="radio" id="account-type-agent" name="account-type" required>Bonded Buyer
                                </label>
                            </div>
                            <hr>
                            <div class="form-group">
                                <label for="form-create-account-full-name">Full Name:</label>
                                <input type="text" class="form-control" id="form-create-account-full-name" required>
                            </div><!-- /.form-group -->
                            <div class="form-group">
                                <label for="form-create-account-email">Email:</label>
                                <input type="email" class="form-control" id="form-create-account-email" required>
                            </div><!-- /.form-group -->
                            <div class="form-group">
                                <label for="form-create-account-password">Password:</label>
                                <input type="password" class="form-control" id="form-create-account-password" required>
                            </div><!-- /.form-group -->
                            <div class="form-group">
                                <label for="form-create-account-confirm-password">Confirm Password:</label>
                                <input type="password" class="form-control" id="form-create-account-confirm-password" required>
                            </div><!-- /.form-group -->
                            <div class="checkbox pull-left">
                                <label>
                                    <input type="radio" id="account-type-newsletter" name="account-newsletter">Join Our Mailing List
                                </label>
                            </div>
                            <div class="form-group clearfix">
                                <button type="submit" class="btn pull-right btn-default" id="account-submit">Create an Account</button>
                            </div><!-- /.form-group -->
                        </form>
                        <hr>
                        <div class="center">
                            <figure class="note">By clicking the “Create an Account” button you agree with our <a href="terms-conditions.html">Terms and conditions</a></figure>
                        </div>
                    </div>
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

</body>
</html>