<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EducationSystem.Login" %>

<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <link rel="icon" type="image/png" href="assets/img/favicon.ico">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />

    <title>Admin | Education System</title>

    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <meta name="viewport" content="width=device-width" />


    <!-- Bootstrap core CSS     -->
    <link href="Admin/css/bootstrap.min.css" rel="stylesheet" />

    <!-- Animation library for notifications   -->
    <link href="Admin/css/animate.min.css" rel="stylesheet" />

    <!--  Light Bootstrap Table core CSS    -->
    <link href="Admin/css/light-bootstrap-dashboard.css" rel="stylesheet" />

    <!--     Fonts and icons     -->
    <link href="http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css" rel="stylesheet">
    <link href='http://fonts.googleapis.com/css?family=Roboto:400,700,300' rel='stylesheet' type='text/css'>
    <link href="Admin/css/pe-icon-7-stroke.css" rel="stylesheet" />
        

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="content">
                <div class="row">
                    <div class="col-sm-4"></div>
                    <div class="col-sm-4">
                        <br />
                        <br />
                        <div class="card">
                            <h3 class="text-center">Login</h3>
                            <br />                           
                            <div class="alert <%= alertType +" "+ hidden %>" id="alertDiv">
                                <asp:Label Text="" ID="alertMsg" runat="server" />
                            </div>
                            <div class="form-group">
                                <label for="txtTopicName">Username</label>
                                <input type="text" class="form-control" placeholder="Username" runat="server" id="username" required />
                            </div>
                            <div class="form-group">
                                <label for="txtTopicName">Password</label>
                                <input type="password" class="form-control" placeholder="Password" runat="server" id="password" required />
                            </div>
                            <asp:Button Text="Login" ID="loginBtn" runat="server" OnClick="loginBtn_Click" CssClass="btn btn-success btn-block" />
                        </div>
                    </div>
                    <div class="col-sm-4"></div>
                </div>
            </div>
        </div>
    </form>
</body>

<script src="Admin/js/jquery-1.10.2.js" type="text/javascript"></script>
<script src="Admin/js/bootstrap.min.js" type="text/javascript"></script>

<!--  Checkbox, Radio & Switch Plugins -->
<script src="Admin/js/bootstrap-checkbox-radio-switch.js"></script>

<!--  Charts Plugin -->
<script src="Admin/js/chartist.min.js"></script>

<!--  Notifications Plugin    -->
<script src="Admin/js/bootstrap-notify.js"></script>

<!--  Google Maps Plugin    -->
<script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?sensor=false"></script>

<!-- Light Bootstrap Table Core javascript and methods for Demo purpose -->
<script src="Admin/js/light-bootstrap-dashboard.js"></script>

<!-- Light Bootstrap Table DEMO methods, don't include it in your project! -->
<script src="Admin/js/demo.js"></script>

</html>
</html>
